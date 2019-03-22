namespace Cisum
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTaskBar = new System.Windows.Forms.Panel();
            this.btnAddPlaylist = new MetroFramework.Controls.MetroUserControl();
            this.metroUserControlAddSong = new MetroFramework.Controls.MetroUserControl();
            this.metroUserControlSetting = new MetroFramework.Controls.MetroUserControl();
            this.btnMinimize = new MetroFramework.Controls.MetroUserControl();
            this.btnClose = new MetroFramework.Controls.MetroUserControl();
            this.btnHideList = new MetroFramework.Controls.MetroUserControl();
            this.panelList = new System.Windows.Forms.Panel();
            this.metroTextBoxLyric = new MetroFramework.Controls.MetroTextBox();
            this.metroUserControlSleeper = new MetroFramework.Controls.MetroUserControl();
            this.labelSleeper = new System.Windows.Forms.Label();
            this.metroUserControlAddLyric = new MetroFramework.Controls.MetroUserControl();
            this.metroButtonSaveLyric = new MetroFramework.Controls.MetroButton();
            this.labelCurrentSong = new System.Windows.Forms.Label();
            this.metroTrackBarVolume = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabelCurrentPosition = new MetroFramework.Controls.MetroLabel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.metroUserControlMute = new MetroFramework.Controls.MetroUserControl();
            this.btnShuffle = new MetroFramework.Controls.MetroUserControl();
            this.btnLoop = new MetroFramework.Controls.MetroUserControl();
            this.trackbarVolume = new MetroFramework.Controls.MetroTrackBar();
            this.btnVolumeUp = new MetroFramework.Controls.MetroUserControl();
            this.btnVolumeDown = new MetroFramework.Controls.MetroUserControl();
            this.btnPrevious = new MetroFramework.Controls.MetroUserControl();
            this.btnNext = new MetroFramework.Controls.MetroUserControl();
            this.btnPlay = new MetroFramework.Controls.MetroUserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListSong = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTextBoxShowLyric = new MetroFramework.Controls.MetroTextBox();
            this.picCurrentSong = new System.Windows.Forms.PictureBox();
            this.metroUserControlShowHideLyric = new MetroFramework.Controls.MetroUserControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAllSongs = new MetroFramework.Controls.MetroTile();
            this.pictureBoxMagic = new System.Windows.Forms.PictureBox();
            this.panelTaskBar.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentSong)).BeginInit();
            this.flowLayoutPanelPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskBar
            // 
            this.panelTaskBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTaskBar.Controls.Add(this.btnAddPlaylist);
            this.panelTaskBar.Controls.Add(this.metroUserControlAddSong);
            this.panelTaskBar.Controls.Add(this.metroUserControlSetting);
            this.panelTaskBar.Controls.Add(this.btnMinimize);
            this.panelTaskBar.Controls.Add(this.btnClose);
            this.panelTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskBar.Location = new System.Drawing.Point(0, 0);
            this.panelTaskBar.Name = "panelTaskBar";
            this.panelTaskBar.Size = new System.Drawing.Size(1080, 30);
            this.panelTaskBar.TabIndex = 0;
            this.panelTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTaskBar_MouseDown);
            this.panelTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTaskBar_MouseMove);
            this.panelTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTaskBar_MouseUp);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.BackgroundImage = global::Cisum.Properties.Resources.addList;
            this.btnAddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPlaylist.Location = new System.Drawing.Point(70, 0);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(30, 30);
            this.btnAddPlaylist.TabIndex = 9;
            this.btnAddPlaylist.UseSelectable = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // metroUserControlAddSong
            // 
            this.metroUserControlAddSong.BackColor = System.Drawing.Color.Transparent;
            this.metroUserControlAddSong.BackgroundImage = global::Cisum.Properties.Resources.add;
            this.metroUserControlAddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroUserControlAddSong.Location = new System.Drawing.Point(36, 0);
            this.metroUserControlAddSong.Name = "metroUserControlAddSong";
            this.metroUserControlAddSong.Size = new System.Drawing.Size(30, 30);
            this.metroUserControlAddSong.TabIndex = 9;
            this.metroUserControlAddSong.UseSelectable = true;
            this.metroUserControlAddSong.Click += new System.EventHandler(this.metroUserControl1_Click);
            // 
            // metroUserControlSetting
            // 
            this.metroUserControlSetting.BackColor = System.Drawing.Color.Transparent;
            this.metroUserControlSetting.BackgroundImage = global::Cisum.Properties.Resources.setting;
            this.metroUserControlSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroUserControlSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroUserControlSetting.Location = new System.Drawing.Point(0, 0);
            this.metroUserControlSetting.Name = "metroUserControlSetting";
            this.metroUserControlSetting.Size = new System.Drawing.Size(30, 30);
            this.metroUserControlSetting.TabIndex = 8;
            this.metroUserControlSetting.UseSelectable = true;
            this.metroUserControlSetting.Click += new System.EventHandler(this.metroUserControlSetting_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Cisum.Properties.Resources.mini;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Location = new System.Drawing.Point(1020, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Cisum.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1050, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHideList
            // 
            this.btnHideList.BackColor = System.Drawing.Color.Transparent;
            this.btnHideList.BackgroundImage = global::Cisum.Properties.Resources.hideList;
            this.btnHideList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideList.Location = new System.Drawing.Point(49, 47);
            this.btnHideList.Name = "btnHideList";
            this.btnHideList.Size = new System.Drawing.Size(30, 30);
            this.btnHideList.TabIndex = 10;
            this.btnHideList.UseSelectable = true;
            this.btnHideList.Click += new System.EventHandler(this.btnHideList_Click);
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.Transparent;
            this.panelList.Controls.Add(this.metroTextBoxLyric);
            this.panelList.Controls.Add(this.metroUserControlSleeper);
            this.panelList.Controls.Add(this.labelSleeper);
            this.panelList.Controls.Add(this.metroUserControlAddLyric);
            this.panelList.Controls.Add(this.metroButtonSaveLyric);
            this.panelList.Controls.Add(this.labelCurrentSong);
            this.panelList.Controls.Add(this.metroTrackBarVolume);
            this.panelList.Controls.Add(this.metroLabelCurrentPosition);
            this.panelList.Controls.Add(this.panelControl);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelList.Location = new System.Drawing.Point(0, 459);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(1080, 141);
            this.panelList.TabIndex = 1;
            // 
            // metroTextBoxLyric
            // 
            this.metroTextBoxLyric.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // 
            // 
            this.metroTextBoxLyric.CustomButton.Image = null;
            this.metroTextBoxLyric.CustomButton.Location = new System.Drawing.Point(270, 2);
            this.metroTextBoxLyric.CustomButton.Name = "";
            this.metroTextBoxLyric.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.metroTextBoxLyric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLyric.CustomButton.TabIndex = 1;
            this.metroTextBoxLyric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLyric.CustomButton.UseSelectable = true;
            this.metroTextBoxLyric.CustomButton.Visible = false;
            this.metroTextBoxLyric.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroTextBoxLyric.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBoxLyric.Location = new System.Drawing.Point(594, 32);
            this.metroTextBoxLyric.MaxLength = 32767;
            this.metroTextBoxLyric.Multiline = true;
            this.metroTextBoxLyric.Name = "metroTextBoxLyric";
            this.metroTextBoxLyric.PasswordChar = '\0';
            this.metroTextBoxLyric.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLyric.SelectedText = "";
            this.metroTextBoxLyric.SelectionLength = 0;
            this.metroTextBoxLyric.SelectionStart = 0;
            this.metroTextBoxLyric.ShortcutsEnabled = true;
            this.metroTextBoxLyric.Size = new System.Drawing.Size(364, 96);
            this.metroTextBoxLyric.TabIndex = 19;
            this.metroTextBoxLyric.Text = "metroTextBox1";
            this.metroTextBoxLyric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxLyric.UseCustomBackColor = true;
            this.metroTextBoxLyric.UseCustomForeColor = true;
            this.metroTextBoxLyric.UseSelectable = true;
            this.metroTextBoxLyric.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLyric.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroUserControlSleeper
            // 
            this.metroUserControlSleeper.BackColor = System.Drawing.Color.Transparent;
            this.metroUserControlSleeper.BackgroundImage = global::Cisum.Properties.Resources.sleeper;
            this.metroUserControlSleeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroUserControlSleeper.Location = new System.Drawing.Point(270, 99);
            this.metroUserControlSleeper.Name = "metroUserControlSleeper";
            this.metroUserControlSleeper.Size = new System.Drawing.Size(30, 30);
            this.metroUserControlSleeper.TabIndex = 15;
            this.metroUserControlSleeper.UseSelectable = true;
            this.metroUserControlSleeper.Click += new System.EventHandler(this.metroUserControlSleeper_Click);
            // 
            // labelSleeper
            // 
            this.labelSleeper.AutoSize = true;
            this.labelSleeper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSleeper.Location = new System.Drawing.Point(230, 106);
            this.labelSleeper.Name = "labelSleeper";
            this.labelSleeper.Size = new System.Drawing.Size(34, 13);
            this.labelSleeper.TabIndex = 18;
            this.labelSleeper.Text = "00:00";
            // 
            // metroUserControlAddLyric
            // 
            this.metroUserControlAddLyric.BackColor = System.Drawing.Color.Transparent;
            this.metroUserControlAddLyric.BackgroundImage = global::Cisum.Properties.Resources.icons8_Music_Notation_104px;
            this.metroUserControlAddLyric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroUserControlAddLyric.Location = new System.Drawing.Point(1038, 99);
            this.metroUserControlAddLyric.Name = "metroUserControlAddLyric";
            this.metroUserControlAddLyric.Size = new System.Drawing.Size(30, 30);
            this.metroUserControlAddLyric.TabIndex = 15;
            this.metroUserControlAddLyric.UseSelectable = true;
            this.metroUserControlAddLyric.Click += new System.EventHandler(this.metroUserControlAddLyric_Click);
            // 
            // metroButtonSaveLyric
            // 
            this.metroButtonSaveLyric.Location = new System.Drawing.Point(964, 99);
            this.metroButtonSaveLyric.Name = "metroButtonSaveLyric";
            this.metroButtonSaveLyric.Size = new System.Drawing.Size(68, 29);
            this.metroButtonSaveLyric.TabIndex = 9;
            this.metroButtonSaveLyric.Text = "Save Lyric";
            this.metroButtonSaveLyric.UseSelectable = true;
            this.metroButtonSaveLyric.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // labelCurrentSong
            // 
            this.labelCurrentSong.AutoEllipsis = true;
            this.labelCurrentSong.AutoSize = true;
            this.labelCurrentSong.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCurrentSong.Location = new System.Drawing.Point(227, 47);
            this.labelCurrentSong.Name = "labelCurrentSong";
            this.labelCurrentSong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCurrentSong.Size = new System.Drawing.Size(226, 34);
            this.labelCurrentSong.TabIndex = 5;
            this.labelCurrentSong.Text = "Let Me Down Slowly";
            // 
            // metroTrackBarVolume
            // 
            this.metroTrackBarVolume.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarVolume.Location = new System.Drawing.Point(233, 5);
            this.metroTrackBarVolume.Name = "metroTrackBarVolume";
            this.metroTrackBarVolume.Size = new System.Drawing.Size(814, 10);
            this.metroTrackBarVolume.TabIndex = 7;
            this.metroTrackBarVolume.TabStop = false;
            this.metroTrackBarVolume.Text = "metroTrackBar1";
            this.metroTrackBarVolume.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBarVolume.Value = 0;
            this.metroTrackBarVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroTrackBarVolume_MouseDown);
            this.metroTrackBarVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroTrackBarVolume_MouseUp);
            // 
            // metroLabelCurrentPosition
            // 
            this.metroLabelCurrentPosition.AutoSize = true;
            this.metroLabelCurrentPosition.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelCurrentPosition.ForeColor = System.Drawing.Color.Snow;
            this.metroLabelCurrentPosition.Location = new System.Drawing.Point(603, 18);
            this.metroLabelCurrentPosition.Name = "metroLabelCurrentPosition";
            this.metroLabelCurrentPosition.Size = new System.Drawing.Size(0, 0);
            this.metroLabelCurrentPosition.TabIndex = 6;
            this.metroLabelCurrentPosition.UseCustomBackColor = true;
            this.metroLabelCurrentPosition.UseCustomForeColor = true;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.pictureBoxDelete);
            this.panelControl.Controls.Add(this.metroUserControlMute);
            this.panelControl.Controls.Add(this.btnHideList);
            this.panelControl.Controls.Add(this.btnShuffle);
            this.panelControl.Controls.Add(this.btnLoop);
            this.panelControl.Controls.Add(this.trackbarVolume);
            this.panelControl.Controls.Add(this.btnVolumeUp);
            this.panelControl.Controls.Add(this.btnVolumeDown);
            this.panelControl.Controls.Add(this.btnPrevious);
            this.panelControl.Controls.Add(this.btnNext);
            this.panelControl.Controls.Add(this.btnPlay);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(200, 141);
            this.panelControl.TabIndex = 2;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDelete.BackgroundImage = global::Cisum.Properties.Resources.Delete;
            this.pictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDelete.Location = new System.Drawing.Point(121, 47);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDelete.TabIndex = 18;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // metroUserControlMute
            // 
            this.metroUserControlMute.BackColor = System.Drawing.Color.Transparent;
            this.metroUserControlMute.BackgroundImage = global::Cisum.Properties.Resources.mute;
            this.metroUserControlMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroUserControlMute.Location = new System.Drawing.Point(85, 47);
            this.metroUserControlMute.Name = "metroUserControlMute";
            this.metroUserControlMute.Size = new System.Drawing.Size(30, 30);
            this.metroUserControlMute.TabIndex = 14;
            this.metroUserControlMute.UseSelectable = true;
            this.metroUserControlMute.Click += new System.EventHandler(this.metroUserControlMute_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.BackgroundImage = global::Cisum.Properties.Resources.shuffle;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffle.Location = new System.Drawing.Point(157, 4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(30, 30);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.UseSelectable = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.BackgroundImage = global::Cisum.Properties.Resources.repeate;
            this.btnLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoop.Location = new System.Drawing.Point(12, 4);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(30, 30);
            this.btnLoop.TabIndex = 12;
            this.btnLoop.UseSelectable = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // trackbarVolume
            // 
            this.trackbarVolume.BackColor = System.Drawing.Color.Transparent;
            this.trackbarVolume.Location = new System.Drawing.Point(36, 106);
            this.trackbarVolume.Name = "trackbarVolume";
            this.trackbarVolume.Size = new System.Drawing.Size(122, 15);
            this.trackbarVolume.TabIndex = 2;
            this.trackbarVolume.TabStop = false;
            this.trackbarVolume.Text = "metroTrackBar1";
            this.trackbarVolume.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackbarVolume.ValueChanged += new System.EventHandler(this.trackbarVolume_ValueChanged);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumeUp.BackgroundImage = global::Cisum.Properties.Resources.up;
            this.btnVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumeUp.Location = new System.Drawing.Point(167, 99);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(30, 30);
            this.btnVolumeUp.TabIndex = 11;
            this.btnVolumeUp.UseSelectable = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumeDown.BackgroundImage = global::Cisum.Properties.Resources.down1;
            this.btnVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumeDown.Location = new System.Drawing.Point(3, 99);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(30, 30);
            this.btnVolumeDown.TabIndex = 11;
            this.btnVolumeDown.UseSelectable = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::Cisum.Properties.Resources.previous;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Location = new System.Drawing.Point(49, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Cisum.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(121, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 9;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Cisum.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(85, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseSelectable = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 2);
            this.label1.TabIndex = 6;
            // 
            // panelListSong
            // 
            this.panelListSong.AllowDrop = true;
            this.panelListSong.AutoScroll = true;
            this.panelListSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelListSong.BackColor = System.Drawing.Color.Transparent;
            this.panelListSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListSong.Location = new System.Drawing.Point(106, 30);
            this.panelListSong.Name = "panelListSong";
            this.panelListSong.Size = new System.Drawing.Size(373, 427);
            this.panelListSong.TabIndex = 8;
            this.panelListSong.WrapContents = false;
            this.panelListSong.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelListSong_DragDrop);
            this.panelListSong.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelListSong_DragEnter);
            this.panelListSong.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListSong_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTextBoxShowLyric
            // 
            // 
            // 
            // 
            this.metroTextBoxShowLyric.CustomButton.Image = null;
            this.metroTextBoxShowLyric.CustomButton.Location = new System.Drawing.Point(-86, 2);
            this.metroTextBoxShowLyric.CustomButton.Name = "";
            this.metroTextBoxShowLyric.CustomButton.Size = new System.Drawing.Size(383, 383);
            this.metroTextBoxShowLyric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxShowLyric.CustomButton.TabIndex = 1;
            this.metroTextBoxShowLyric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxShowLyric.CustomButton.UseSelectable = true;
            this.metroTextBoxShowLyric.CustomButton.Visible = false;
            this.metroTextBoxShowLyric.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroTextBoxShowLyric.Lines = new string[0];
            this.metroTextBoxShowLyric.Location = new System.Drawing.Point(768, 52);
            this.metroTextBoxShowLyric.MaxLength = 32767;
            this.metroTextBoxShowLyric.Multiline = true;
            this.metroTextBoxShowLyric.Name = "metroTextBoxShowLyric";
            this.metroTextBoxShowLyric.PasswordChar = '\0';
            this.metroTextBoxShowLyric.ReadOnly = true;
            this.metroTextBoxShowLyric.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.metroTextBoxShowLyric.SelectedText = "";
            this.metroTextBoxShowLyric.SelectionLength = 0;
            this.metroTextBoxShowLyric.SelectionStart = 0;
            this.metroTextBoxShowLyric.ShortcutsEnabled = true;
            this.metroTextBoxShowLyric.Size = new System.Drawing.Size(300, 388);
            this.metroTextBoxShowLyric.TabIndex = 16;
            this.metroTextBoxShowLyric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxShowLyric.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxShowLyric.UseCustomBackColor = true;
            this.metroTextBoxShowLyric.UseCustomForeColor = true;
            this.metroTextBoxShowLyric.UseSelectable = true;
            this.metroTextBoxShowLyric.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxShowLyric.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picCurrentSong
            // 
            this.picCurrentSong.BackColor = System.Drawing.Color.Transparent;
            this.picCurrentSong.BackgroundImage = global::Cisum.Properties.Resources.song;
            this.picCurrentSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCurrentSong.Location = new System.Drawing.Point(419, 52);
            this.picCurrentSong.Name = "picCurrentSong";
            this.picCurrentSong.Size = new System.Drawing.Size(310, 388);
            this.picCurrentSong.TabIndex = 2;
            this.picCurrentSong.TabStop = false;
            // 
            // metroUserControlShowHideLyric
            // 
            this.metroUserControlShowHideLyric.BackColor = System.Drawing.Color.Transparent;
            this.metroUserControlShowHideLyric.BackgroundImage = global::Cisum.Properties.Resources.hide;
            this.metroUserControlShowHideLyric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroUserControlShowHideLyric.Location = new System.Drawing.Point(735, 410);
            this.metroUserControlShowHideLyric.Name = "metroUserControlShowHideLyric";
            this.metroUserControlShowHideLyric.Size = new System.Drawing.Size(30, 30);
            this.metroUserControlShowHideLyric.TabIndex = 9;
            this.metroUserControlShowHideLyric.UseSelectable = true;
            this.metroUserControlShowHideLyric.Click += new System.EventHandler(this.metroUserControlShowHideLyric_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // flowLayoutPanelPlaylist
            // 
            this.flowLayoutPanelPlaylist.AutoScroll = true;
            this.flowLayoutPanelPlaylist.AutoSize = true;
            this.flowLayoutPanelPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelPlaylist.Controls.Add(this.btnAllSongs);
            this.flowLayoutPanelPlaylist.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelPlaylist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPlaylist.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanelPlaylist.Name = "flowLayoutPanelPlaylist";
            this.flowLayoutPanelPlaylist.Size = new System.Drawing.Size(106, 427);
            this.flowLayoutPanelPlaylist.TabIndex = 7;
            this.flowLayoutPanelPlaylist.WrapContents = false;
            this.flowLayoutPanelPlaylist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanelPlaylist_MouseDown);
            // 
            // btnAllSongs
            // 
            this.btnAllSongs.ActiveControl = null;
            this.btnAllSongs.AllowDrop = true;
            this.btnAllSongs.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAllSongs.Location = new System.Drawing.Point(3, 3);
            this.btnAllSongs.Name = "btnAllSongs";
            this.btnAllSongs.Size = new System.Drawing.Size(100, 40);
            this.btnAllSongs.TabIndex = 10;
            this.btnAllSongs.Text = "All Songs";
            this.btnAllSongs.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAllSongs.UseCustomBackColor = true;
            this.btnAllSongs.UseSelectable = true;
            this.btnAllSongs.Click += new System.EventHandler(this.btnAllSongs_Click);
            this.btnAllSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnAllSongs_DragDrop);
            this.btnAllSongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnAllSongs_DragEnter);
            // 
            // pictureBoxMagic
            // 
            this.pictureBoxMagic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMagic.Location = new System.Drawing.Point(106, 30);
            this.pictureBoxMagic.Name = "pictureBoxMagic";
            this.pictureBoxMagic.Size = new System.Drawing.Size(373, 424);
            this.pictureBoxMagic.TabIndex = 17;
            this.pictureBoxMagic.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelListSong);
            this.Controls.Add(this.flowLayoutPanelPlaylist);
            this.Controls.Add(this.metroUserControlShowHideLyric);
            this.Controls.Add(this.metroTextBoxShowLyric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelTaskBar);
            this.Controls.Add(this.picCurrentSong);
            this.Controls.Add(this.pictureBoxMagic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panelTaskBar.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentSong)).EndInit();
            this.flowLayoutPanelPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTaskBar;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelControl;
        private MetroFramework.Controls.MetroUserControl btnMinimize;
        private MetroFramework.Controls.MetroUserControl btnClose;
        private MetroFramework.Controls.MetroUserControl btnPrevious;
        private MetroFramework.Controls.MetroUserControl btnNext;
        private MetroFramework.Controls.MetroUserControl btnPlay;
        private MetroFramework.Controls.MetroUserControl btnVolumeUp;
        private MetroFramework.Controls.MetroUserControl btnVolumeDown;
        private MetroFramework.Controls.MetroTrackBar trackbarVolume;
        private System.Windows.Forms.PictureBox picCurrentSong;
        private System.Windows.Forms.Label labelCurrentSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelListSong;
        private MetroFramework.Controls.MetroUserControl btnLoop;
        private MetroFramework.Controls.MetroUserControl btnShuffle;
        private MetroFramework.Controls.MetroLabel metroLabelCurrentPosition;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarVolume;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButtonSaveLyric;
        private MetroFramework.Controls.MetroUserControl metroUserControlAddLyric;
        private MetroFramework.Controls.MetroTextBox metroTextBoxShowLyric;
        private MetroFramework.Controls.MetroUserControl metroUserControlSetting;
        private MetroFramework.Controls.MetroUserControl metroUserControlMute;
        private MetroFramework.Controls.MetroUserControl metroUserControlShowHideLyric;
        private MetroFramework.Controls.MetroUserControl metroUserControlSleeper;
        private System.Windows.Forms.Label labelSleeper;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroUserControl metroUserControlAddSong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPlaylist;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLyric;
        private MetroFramework.Controls.MetroTile btnAllSongs;
        private MetroFramework.Controls.MetroUserControl btnAddPlaylist;
        private System.Windows.Forms.PictureBox pictureBoxMagic;
        private MetroFramework.Controls.MetroUserControl btnHideList;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
    }
}

