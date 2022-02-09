namespace AttributesEditor
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("המחשב שלי");
            this.ChkHide = new System.Windows.Forms.CheckBox();
            this.BtnApplyChanges = new System.Windows.Forms.Button();
            this.ChkArchive = new System.Windows.Forms.CheckBox();
            this.ChkReadOnly = new System.Windows.Forms.CheckBox();
            this.ChkSystem = new System.Windows.Forms.CheckBox();
            this.BtnApplyNormal = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TrvBrowser = new System.Windows.Forms.TreeView();
            this.LblCaption = new System.Windows.Forms.Label();
            this.ChkInternet = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpCreate = new System.Windows.Forms.DateTimePicker();
            this.dtpAccess = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpChange = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpMP3 = new System.Windows.Forms.GroupBox();
            this.LblProgressPlay = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSize = new System.Windows.Forms.Label();
            this.LblSizeCaption = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveTags = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.קובץToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.חפשתמונותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עזרהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אודותעורךהתגיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הצגעזרהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpMP3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stsStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkHide
            // 
            this.ChkHide.Location = new System.Drawing.Point(187, 61);
            this.ChkHide.Name = "ChkHide";
            this.ChkHide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkHide.Size = new System.Drawing.Size(127, 24);
            this.ChkHide.TabIndex = 1;
            this.ChkHide.Text = "מוסתר";
            this.ChkHide.UseVisualStyleBackColor = true;
            // 
            // BtnApplyChanges
            // 
            this.BtnApplyChanges.Location = new System.Drawing.Point(177, 294);
            this.BtnApplyChanges.Name = "BtnApplyChanges";
            this.BtnApplyChanges.Size = new System.Drawing.Size(136, 25);
            this.BtnApplyChanges.TabIndex = 2;
            this.BtnApplyChanges.Text = "החל שינויים";
            this.BtnApplyChanges.UseVisualStyleBackColor = true;
            this.BtnApplyChanges.Click += new System.EventHandler(this.BtnApplyChanges_Click);
            // 
            // ChkArchive
            // 
            this.ChkArchive.Location = new System.Drawing.Point(15, 61);
            this.ChkArchive.Name = "ChkArchive";
            this.ChkArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkArchive.Size = new System.Drawing.Size(127, 24);
            this.ChkArchive.TabIndex = 3;
            this.ChkArchive.Text = "ארכיון";
            this.ChkArchive.UseVisualStyleBackColor = true;
            // 
            // ChkReadOnly
            // 
            this.ChkReadOnly.Location = new System.Drawing.Point(187, 121);
            this.ChkReadOnly.Name = "ChkReadOnly";
            this.ChkReadOnly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkReadOnly.Size = new System.Drawing.Size(127, 24);
            this.ChkReadOnly.TabIndex = 4;
            this.ChkReadOnly.Text = "קריאה בלבד";
            this.ChkReadOnly.UseVisualStyleBackColor = true;
            // 
            // ChkSystem
            // 
            this.ChkSystem.Location = new System.Drawing.Point(187, 91);
            this.ChkSystem.Name = "ChkSystem";
            this.ChkSystem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkSystem.Size = new System.Drawing.Size(127, 24);
            this.ChkSystem.TabIndex = 5;
            this.ChkSystem.Text = "קובץ מערכת";
            this.ChkSystem.UseVisualStyleBackColor = true;
            // 
            // BtnApplyNormal
            // 
            this.BtnApplyNormal.Location = new System.Drawing.Point(15, 294);
            this.BtnApplyNormal.Name = "BtnApplyNormal";
            this.BtnApplyNormal.Size = new System.Drawing.Size(136, 25);
            this.BtnApplyNormal.TabIndex = 6;
            this.BtnApplyNormal.Text = "החל מאפיינים רגילים";
            this.BtnApplyNormal.UseVisualStyleBackColor = true;
            this.BtnApplyNormal.Click += new System.EventHandler(this.BtnApplyNormal_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "computer.png");
            this.imageList1.Images.SetKeyName(1, "drive.png");
            this.imageList1.Images.SetKeyName(2, "folder.png");
            this.imageList1.Images.SetKeyName(3, "file_text.png");
            // 
            // TrvBrowser
            // 
            this.TrvBrowser.ImageIndex = 0;
            this.TrvBrowser.ImageList = this.imageList1;
            this.TrvBrowser.Indent = 12;
            this.TrvBrowser.Location = new System.Drawing.Point(712, 30);
            this.TrvBrowser.Name = "TrvBrowser";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Node0";
            treeNode1.Text = "המחשב שלי";
            this.TrvBrowser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TrvBrowser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TrvBrowser.RightToLeftLayout = true;
            this.TrvBrowser.SelectedImageIndex = 0;
            this.TrvBrowser.Size = new System.Drawing.Size(300, 459);
            this.TrvBrowser.TabIndex = 0;
            this.TrvBrowser.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TrvBrowser_BeforeExpand_1);
            this.TrvBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvBrowser_AfterSelect);
            // 
            // LblCaption
            // 
            this.LblCaption.Location = new System.Drawing.Point(14, 24);
            this.LblCaption.Name = "LblCaption";
            this.LblCaption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblCaption.Size = new System.Drawing.Size(273, 23);
            this.LblCaption.TabIndex = 8;
            this.LblCaption.Text = "המחשב שלי";
            this.LblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChkInternet
            // 
            this.ChkInternet.Location = new System.Drawing.Point(15, 91);
            this.ChkInternet.Name = "ChkInternet";
            this.ChkInternet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkInternet.Size = new System.Drawing.Size(127, 24);
            this.ChkInternet.TabIndex = 10;
            this.ChkInternet.Text = "קובץ זמני";
            this.ChkInternet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(186, 188);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "תאריך יצירה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpCreate
            // 
            this.DtpCreate.CustomFormat = "HH:mm dd/MM/yyyy ";
            this.DtpCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCreate.Location = new System.Drawing.Point(14, 188);
            this.DtpCreate.Name = "DtpCreate";
            this.DtpCreate.Size = new System.Drawing.Size(135, 20);
            this.DtpCreate.TabIndex = 13;
            // 
            // dtpAccess
            // 
            this.dtpAccess.CustomFormat = "HH:mm dd/MM/yyyy ";
            this.dtpAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAccess.Location = new System.Drawing.Point(13, 220);
            this.dtpAccess.Name = "dtpAccess";
            this.dtpAccess.Size = new System.Drawing.Size(135, 20);
            this.dtpAccess.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(185, 220);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "תאריך פתיחה אחרונה";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpChange
            // 
            this.dtpChange.CustomFormat = "HH:mm dd/MM/yyyy ";
            this.dtpChange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChange.Location = new System.Drawing.Point(14, 252);
            this.dtpChange.Name = "dtpChange";
            this.dtpChange.Size = new System.Drawing.Size(135, 20);
            this.dtpChange.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(186, 252);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "תאריך שינוי אחרון";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpMP3
            // 
            this.GrpMP3.Controls.Add(this.LblProgressPlay);
            this.GrpMP3.Controls.Add(this.BtnPause);
            this.GrpMP3.Controls.Add(this.BtnPlay);
            this.GrpMP3.Controls.Add(this.LblDuration);
            this.GrpMP3.Controls.Add(this.label7);
            this.GrpMP3.Controls.Add(this.LblRate);
            this.GrpMP3.Controls.Add(this.label6);
            this.GrpMP3.Location = new System.Drawing.Point(352, 361);
            this.GrpMP3.Name = "GrpMP3";
            this.GrpMP3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrpMP3.Size = new System.Drawing.Size(328, 128);
            this.GrpMP3.TabIndex = 21;
            this.GrpMP3.TabStop = false;
            this.GrpMP3.Text = "מאפייני קובץ שמע";
            this.GrpMP3.Visible = false;
            // 
            // LblProgressPlay
            // 
            this.LblProgressPlay.Location = new System.Drawing.Point(125, 74);
            this.LblProgressPlay.Name = "LblProgressPlay";
            this.LblProgressPlay.Size = new System.Drawing.Size(97, 17);
            this.LblProgressPlay.TabIndex = 26;
            this.LblProgressPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDuration
            // 
            this.LblDuration.Location = new System.Drawing.Point(148, 52);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblDuration.Size = new System.Drawing.Size(87, 17);
            this.LblDuration.TabIndex = 23;
            this.LblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(241, 52);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "אורך";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRate
            // 
            this.LblRate.Location = new System.Drawing.Point(29, 29);
            this.LblRate.Name = "LblRate";
            this.LblRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblRate.Size = new System.Drawing.Size(206, 17);
            this.LblRate.TabIndex = 21;
            this.LblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(241, 29);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "קצב לשניה";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSize);
            this.groupBox1.Controls.Add(this.LblSizeCaption);
            this.groupBox1.Controls.Add(this.LblCaption);
            this.groupBox1.Controls.Add(this.ChkHide);
            this.groupBox1.Controls.Add(this.BtnApplyNormal);
            this.groupBox1.Controls.Add(this.ChkArchive);
            this.groupBox1.Controls.Add(this.BtnApplyChanges);
            this.groupBox1.Controls.Add(this.ChkReadOnly);
            this.groupBox1.Controls.Add(this.dtpChange);
            this.groupBox1.Controls.Add(this.ChkSystem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtpAccess);
            this.groupBox1.Controls.Add(this.ChkInternet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpCreate);
            this.groupBox1.Location = new System.Drawing.Point(352, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(328, 329);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מאפיינים";
            // 
            // LblSize
            // 
            this.LblSize.Location = new System.Drawing.Point(14, 160);
            this.LblSize.Name = "LblSize";
            this.LblSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblSize.Size = new System.Drawing.Size(262, 17);
            this.LblSize.TabIndex = 21;
            this.LblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSizeCaption
            // 
            this.LblSizeCaption.Location = new System.Drawing.Point(279, 160);
            this.LblSizeCaption.Name = "LblSizeCaption";
            this.LblSizeCaption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblSizeCaption.Size = new System.Drawing.Size(36, 17);
            this.LblSizeCaption.TabIndex = 20;
            this.LblSizeCaption.Text = "גודל:";
            this.LblSizeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveTags);
            this.groupBox2.Controls.Add(this.btnSaveImage);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblTrack);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblAlbum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblGenre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblArtist);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(10, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(328, 463);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "תגיות";
            // 
            // btnRemoveTags
            // 
            this.btnRemoveTags.Location = new System.Drawing.Point(15, 432);
            this.btnRemoveTags.Name = "btnRemoveTags";
            this.btnRemoveTags.Size = new System.Drawing.Size(136, 25);
            this.btnRemoveTags.TabIndex = 34;
            this.btnRemoveTags.Text = "מחק תגיות";
            this.btnRemoveTags.UseVisualStyleBackColor = true;
            this.btnRemoveTags.Click += new System.EventHandler(this.btnRemoveTags_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(172, 432);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(136, 25);
            this.btnSaveImage.TabIndex = 33;
            this.btnSaveImage.Text = "שמור תמונה";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.Location = new System.Drawing.Point(15, 186);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTrack.Size = new System.Drawing.Size(215, 17);
            this.lblTrack.TabIndex = 31;
            this.lblTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(236, 186);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 30;
            this.label17.Text = "מספר רצועה";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlbum
            // 
            this.lblAlbum.Location = new System.Drawing.Point(15, 70);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAlbum.Size = new System.Drawing.Size(215, 17);
            this.lblAlbum.TabIndex = 29;
            this.lblAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(236, 70);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "אלבום";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(15, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(215, 17);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(236, 99);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "כותרת";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(15, 128);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGenre.Size = new System.Drawing.Size(215, 17);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(236, 128);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "סגנון";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(15, 157);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYear.Size = new System.Drawing.Size(215, 17);
            this.lblYear.TabIndex = 23;
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(236, 157);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "שנה";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtist
            // 
            this.lblArtist.Location = new System.Drawing.Point(15, 41);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblArtist.Size = new System.Drawing.Size(215, 17);
            this.lblArtist.TabIndex = 21;
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(236, 41);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "אמן";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsStatus
            // 
            this.stsStatus.BackColor = System.Drawing.SystemColors.Control;
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 496);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stsStatus.Size = new System.Drawing.Size(1024, 22);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 28;
            this.stsStatus.Visible = false;
            this.stsStatus.VisibleChanged += new System.EventHandler(this.stsStatus_VisibleChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 17);
            this.lblStatus.Text = "מעבד...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttributesEditor.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(294, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPause
            // 
            this.BtnPause.Image = global::AttributesEditor.Properties.Resources.pause;
            this.BtnPause.Location = new System.Drawing.Point(257, 74);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(28, 28);
            this.BtnPause.TabIndex = 24;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Image = global::AttributesEditor.Properties.Resources.play;
            this.BtnPlay.Location = new System.Drawing.Point(285, 74);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(28, 28);
            this.BtnPlay.TabIndex = 22;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.קובץToolStripMenuItem,
            this.עזרהToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // קובץToolStripMenuItem
            // 
            this.קובץToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.חפשתמונותToolStripMenuItem,
            this.יציאהToolStripMenuItem});
            this.קובץToolStripMenuItem.Name = "קובץToolStripMenuItem";
            this.קובץToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.קובץToolStripMenuItem.Text = "&קובץ";
            // 
            // חפשתמונותToolStripMenuItem
            // 
            this.חפשתמונותToolStripMenuItem.Name = "חפשתמונותToolStripMenuItem";
            this.חפשתמונותToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.חפשתמונותToolStripMenuItem.Text = "&חפש תמונות בקבצים...";
            this.חפשתמונותToolStripMenuItem.Click += new System.EventHandler(this.חפשתמונותToolStripMenuItem_Click);
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.יציאהToolStripMenuItem.Text = "&יציאה";
            // 
            // עזרהToolStripMenuItem
            // 
            this.עזרהToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הצגעזרהToolStripMenuItem,
            this.אודותעורךהתגיםToolStripMenuItem});
            this.עזרהToolStripMenuItem.Name = "עזרהToolStripMenuItem";
            this.עזרהToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.עזרהToolStripMenuItem.Text = "&עזרה";
            // 
            // אודותעורךהתגיםToolStripMenuItem
            // 
            this.אודותעורךהתגיםToolStripMenuItem.Name = "אודותעורךהתגיםToolStripMenuItem";
            this.אודותעורךהתגיםToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.אודותעורךהתגיםToolStripMenuItem.Text = "&אודות עורך התגים";
            // 
            // הצגעזרהToolStripMenuItem
            // 
            this.הצגעזרהToolStripMenuItem.Name = "הצגעזרהToolStripMenuItem";
            this.הצגעזרהToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.הצגעזרהToolStripMenuItem.Text = "הצג &עזרה";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 518);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpMP3);
            this.Controls.Add(this.TrvBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "עורך המאפיינים";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GrpMP3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkHide;
        private System.Windows.Forms.Button BtnApplyChanges;
        private System.Windows.Forms.CheckBox ChkArchive;
        private System.Windows.Forms.CheckBox ChkReadOnly;
        private System.Windows.Forms.CheckBox ChkSystem;
        private System.Windows.Forms.Button BtnApplyNormal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView TrvBrowser;
        private System.Windows.Forms.Label LblCaption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChkInternet;
        private System.Drawing.Image shapeContainer1;
        private System.Drawing.Image lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpCreate;
        private System.Windows.Forms.DateTimePicker dtpAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrpMP3;
        private System.Windows.Forms.Label LblRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPause;
        private System.Drawing.Image shapeContainer2;
        private System.Drawing.Image lineShape2;
        private System.Drawing.Image ShpProgressPlay;
        private System.Windows.Forms.Label LblProgressPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label LblSizeCaption;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRemoveTags;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem קובץToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem חפשתמונותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עזרהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הצגעזרהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אודותעורךהתגיםToolStripMenuItem;
    }
}

