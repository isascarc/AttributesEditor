using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using IdSharp.Tagging.ID3v2;
using System.Drawing;

namespace AttributesEditor
{
    public partial class FrmMain : Form
    {
        enum Status { computer = 0, directory = 2, file = 4, error = 5 }
        FileAttributes attRead = new FileAttributes();
        FileAttributes AttWrite;
        Status status = (int)Status.computer;
        ID3v2Tag tags = new ID3v2Tag();
        int mp3Counter = 0;
        bool NowPlayng = false;
        string pathOfMP3 = "";
        // Shower progress of play
        const int StartLocation = 263;
        const double ShapeLength = 263 - 10;
        double Duration = 0;
        double buffer = 0;
        double CountSeconds = 0;
        int AllProgress = 263;
        Timer Advance = new Timer() { Interval = 1000 };
        public FrmMain()
        {
            InitializeComponent();
            // Add drives list
            DriveInfo[] Drives = System.IO.DriveInfo.GetDrives();
            string[] x;
            for (int i = 0; i < Drives.Length; i++)
            {
                try
                {
                    // Add device to list
                    TrvBrowser.Nodes[0].Nodes.Add("0", Drives[i].Name, 1, 1);
                    // Add all folders that exist in top-level in all device
                    x = Directory.GetDirectories(Drives[i].Name);
                    for (int z = 0; z < x.Length; z++)
                        // if the folder contains anything - add one item into the dir, and check this with "0" value in tag property.
                        // else - write her as is.
                        try
                        {
                            if (Directory.GetFiles(x[z]).Length > 0 || Directory.GetDirectories(x[z]).Length > 0)
                            {
                                TrvBrowser.Nodes[0].Nodes[i].Nodes.Add("0", Path.GetFileName(x[z]), 2, 2).Tag = "0";
                                TrvBrowser.Nodes[0].Nodes[i].Nodes[z].Nodes.Add("0");
                            }
                            else
                            {
                                TrvBrowser.Nodes[0].Nodes[i].Nodes.Add("0", Path.GetFileName(x[z]), 2, 2);
                            }
                        }
                        // if this catch, write the name of folder only
                        catch
                        {
                            TrvBrowser.Nodes[0].Nodes[i].Nodes.Add("0", Path.GetFileName(x[z]), 2, 2);
                        }
                }

                catch { }
                // add files from root directory of the drive
                x = Directory.GetFiles(Drives[i].Name);
                for (int z = 0; z < x.Length; z++)
                {
                    TrvBrowser.Nodes[0].Nodes[i].Nodes.Add("0", Path.GetFileName(x[z]), 3, 3);
                }
            }
            Advance.Tick += Advance_Tick;
        }

        void Advance_Tick(object sender, EventArgs e)
        {
            CountSeconds++;
            AllProgress = (int)(buffer * CountSeconds);
            /*if (ShpProgressPlay.Left > 10)
                ShpProgressPlay.Left = StartLocation - AllProgress;
            else
                ((Timer)sender).Stop();*/
            LblProgressPlay.Text = string.Format("{2} / {0}:{1:00}", (int)(CountSeconds / 60), (int)(CountSeconds % 60), LblDuration.Text);
        }

        private void TrvBrowser_BeforeExpand_1(object sender, TreeViewCancelEventArgs e)
        {
            //אם נבחרה תקית דמה
            if (e.Node.Level > 1 & e.Node.Tag != null)
            {
                string[] directs = Directory.GetDirectories(e.Node.FullPath.Substring(10));
                // אם יש כמות סבירה של תיקות
                // המחשב יסמן + רק לצד התיקיות שמכילות חומר
                if (directs.Length < 100)
                {
                    for (int i = 0; i < directs.Length; i++)
                    {
                        try
                        {
                            if (Directory.GetDirectories(directs[i]).Length > 0 || Directory.GetFiles(directs[i]).Length > 0)
                            // and possible write like this:
                            // if (Directory.GetFileSystemEntries(directs[i]).Length > 0)
                            {
                                e.Node.Nodes.Add("0", Path.GetFileName(directs[i]), 2, 2).Tag = "0";
                                e.Node.Nodes[i + 1].Nodes.Add("0");
                            }
                            else
                            {
                                e.Node.Nodes.Add("0", Path.GetFileName(directs[i]), 2, 2);
                            }
                        }
                        // if call is exception, add just the name directory
                        catch
                        {
                            e.Node.Nodes.Add("0", Path.GetFileName(directs[i]), 2, 2);
                        }
                    }
                }
                // if this path contains up to 100 directoryes
                // check '+' for all dir, without calculate if this dir empty or not.
                else
                {
                    for (int i = 0; i < directs.Length; i++)
                    {
                        e.Node.Nodes.Add("0", Path.GetFileName(directs[i]), 2, 2).Tag = "0";
                        e.Node.Nodes[i + 1].Nodes.Add("0");
                    }
                }
                // add files
                directs = Directory.GetFiles(e.Node.FullPath.Substring(10));
                for (int z = 0; z < directs.Length; z++)
                {
                    e.Node.Nodes.Add("0", Path.GetFileName(directs[z]), 3, 3);
                }
                e.Node.Nodes[0].Remove();
                e.Node.Tag = null;
            }
        }

        private void TrvBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LblCaption.Text = e.Node.Text;
            // if user select item under device level (= file or directory)
            if (e.Node.Level > 1)
            {
                try
                {
                    string CurrentFile = TrvBrowser.SelectedNode.FullPath.Substring(10);
                    attRead = File.GetAttributes(CurrentFile);
                    // properties:
                    ChkHide.Checked = attRead.HasFlag(FileAttributes.Hidden);
                    ChkSystem.Checked = attRead.HasFlag(FileAttributes.System);
                    ChkReadOnly.Checked = attRead.HasFlag(FileAttributes.ReadOnly);
                    ChkArchive.Checked = attRead.HasFlag(FileAttributes.Archive);
                    ChkInternet.Checked = attRead.HasFlag(FileAttributes.Temporary);
                    // dates:
                    DtpCreate.Value = File.GetCreationTime(CurrentFile);
                    dtpChange.Value = File.GetLastWriteTime(CurrentFile);
                    dtpAccess.Value = File.GetLastAccessTime(CurrentFile);
                    // if selected folder - show folder picture
                    if (e.Node.ImageIndex == (int)Status.directory)
                    {
                        pictureBox1.Image = AttributesEditor.Properties.Resources.folder;
                        status = Status.directory;
                        LblSize.Visible = false;
                        LblSizeCaption.Visible = false;
                        GrpMP3.Visible = false;
                    }
                    // if selected file
                    else
                    {
                        pictureBox1.Image = Properties.Resources.fileText;
                        status = Status.file;
                        // show size labels, and calculate the length file, by length units.
                        LblSize.Visible = true;
                        LblSizeCaption.Visible = true;
                        long lengthBytes = new FileInfo(CurrentFile).Length;
                        if (lengthBytes < 1024)
                            LblSize.Text = lengthBytes + " בתים";
                        else if (lengthBytes < 1048576)
                            LblSize.Text = lengthBytes / 1024 + " KB";
                        else if (lengthBytes < 1073741824)
                            LblSize.Text = lengthBytes / 1048576 + " MB";
                        else
                            LblSize.Text = lengthBytes / 1073741824 + " GB";
                        // add information about mp3 file, if this mp3 file.
                        if (CurrentFile.EndsWith(".mp3"))
                        {
                            pathOfMP3 = CurrentFile;
                            GrpMP3.Visible = true;
                            /*var mp3File = IdSharp.AudioInfo.AudioFile.Create(CurrentFile, true);
                            LblRate.Text = ((int)mp3File.Bitrate).ToString() + " kbps";
                            LblDuration.Text = string.Format("{0}:{1:00}", (int)mp3File.TotalSeconds / 60, (int)mp3File.TotalSeconds % 60);
                            Duration = (int)mp3File.TotalSeconds;*/
                            tags = new ID3v2Tag(CurrentFile);
                            lblArtist.Text = tags.Artist;
                            lblAlbum.Text = tags.Album;
                            lblGenre.Text = tags.Genre;
                            lblYear.Text = tags.Year;
                            lblTrack.Text = tags.TrackNumber;
                            lblTitle.Text = tags.Title;
                            if (tags.PictureList.Count > 0)
                            {
                                pictureBox2.Image = tags.PictureList[0].Picture;
                                btnSaveImage.Visible = true;
                            }
                            else
                            {
                                pictureBox2.Image = null;
                                btnSaveImage.Visible = false;
                            }
                        }
                        else
                        {
                            GrpMP3.Visible = false;
                        }
                    }
                }
                catch { status = Status.error; }
            }
        }

        // apply attributes
        private void ApplyChangesInFile(string pathFile)
        {
            AttWrite = new FileAttributes();
            if (ChkHide.Checked)
                AttWrite |= FileAttributes.Hidden;
            if (ChkSystem.Checked)
                AttWrite |= FileAttributes.System;
            if (ChkReadOnly.Checked)
                AttWrite |= FileAttributes.ReadOnly;
            if (ChkArchive.Checked)
                AttWrite |= FileAttributes.Archive;
            if (ChkInternet.Checked)
                AttWrite |= FileAttributes.Temporary;
            File.SetAttributes(pathFile, AttWrite);
        }

        // apply attributes with recursion
        private void ApplyChanges(string pathFile, bool includeSubDirectorys, FileAttributes attributesSelected)
        {
            // apply attributes in directory.
            File.SetAttributes(pathFile, AttWrite);
            // apply attributes in files that exist in top-level in dir.
            string[] FilesList = Directory.GetFiles(pathFile);
            for (int i = 0; i < FilesList.Length; i++)
            {
                ApplyChangesInFile(FilesList[i]);
            }
            // recursion for sub directorys
            if (includeSubDirectorys)
            {
                string[] PathsList = Directory.GetDirectories(pathFile);
                if (PathsList.Length > 0)
                    for (int i = 0; i < PathsList.Length; i++)
                    {
                        ApplyChanges(PathsList[i], true, AttWrite);
                    }
            }
        }

        private void BtnApplyChanges_Click(object sender, EventArgs e)
        {
            // if file selected - apply changes directly to file.
            if (status == Status.file)
            {
                if (File.Exists(TrvBrowser.SelectedNode.FullPath.Substring(10)))
                {
                    ApplyChangesInFile(TrvBrowser.SelectedNode.FullPath.Substring(10));
                }
            }
            // if directory selected - ask, and apply changes by answer.
            else if (status == Status.directory)
            {
                if (Directory.Exists(TrvBrowser.SelectedNode.FullPath.Substring(10)))
                {
                    AttWrite = new FileAttributes();
                    if (ChkHide.Checked)
                        AttWrite |= AttWrite;
                    if (ChkSystem.Checked)
                        AttWrite |= FileAttributes.System;
                    if (ChkReadOnly.Checked)
                        AttWrite |= FileAttributes.ReadOnly;
                    if (ChkArchive.Checked)
                        AttWrite |= FileAttributes.Archive;
                    if (ChkInternet.Checked)
                        AttWrite |= FileAttributes.Temporary;
                    if (MessageBox.Show("האם ברצונך להחל שינויים גם על קבצי ותיקיות המשנה?", "החלת שינויים", MessageBoxButtons.YesNo)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        ApplyChanges(TrvBrowser.SelectedNode.FullPath.Substring(10), true, AttWrite);
                    }
                    else
                    {
                        ApplyChanges(TrvBrowser.SelectedNode.FullPath.Substring(10), false, AttWrite);
                    }
                    ApplyChangesInFile(TrvBrowser.SelectedNode.FullPath.Substring(10));
                }
            }
        }

        private void BtnApplyNormal_Click(object sender, EventArgs e)
        {
            // Apply normal atributes
            File.SetAttributes(TrvBrowser.SelectedNode.FullPath.Substring(10), FileAttributes.Normal);
            // Clear all checkBoxs
            ChkHide.Checked = false;
            ChkSystem.Checked = false;
            ChkReadOnly.Checked = false;
            ChkArchive.Checked = false;
            ChkInternet.Checked = false;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            BtnPlay.Enabled = false;
            BtnPause.Enabled = true;
            //
            //ShpProgressPlay.Left = StartLocation;
            if (NowPlayng)
                BtnPause_Click(sender, e);
            mp3Counter++;
            uint x = mciSendString(@"open """ + TrvBrowser.SelectedNode.FullPath.Substring(10) + @""" alias att" + mp3Counter.ToString(), null, 0, IntPtr.Zero);
            uint y = mciSendString("play att" + mp3Counter.ToString(), null, 0, IntPtr.Zero);
            NowPlayng = true;
            buffer = ((Duration) / (ShapeLength));
            Advance.Start();
        }

        /// <summary>
        /// Play mp3 file.
        /// </summary>
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hWndCallback);

        private void BtnPause_Click(object sender, EventArgs e)
        {
            BtnPause.Enabled = false;
            BtnPlay.Enabled = true;
            //
            mciSendString(@"stop att" + mp3Counter.ToString(), null, 0, IntPtr.Zero);
            NowPlayng = false;
            Advance.Stop();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(sf.FileName + "." + tags.PictureList[0].PictureExtension, tags.PictureList[0].PictureData);
                }
                catch { }
            }
        }
        private void btnRemoveTags_Click(object sender, EventArgs e)
        {
            if (ID3v2Tag.RemoveTag(pathOfMP3) == true)
            {
                lblStatus.Image = Properties.Resources.done;
                lblStatus.Text = "התגיות הוסרו מהקובץ";
                lblStatus.Visible = true;
            }
        }

        private void stsStatus_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void חפשתמונותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}