using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cisum.Business;
using Cisum.DataAccess;
using TagLib;
using Mp3Lib;
using System.IO;
using WMPLib;
using MetroFramework.Controls;

namespace Cisum
{
    public partial class Form1 : Form
    {
        private static int indexForHidingPlaylistAndSongs = 1;
        private Point downPoint = new Point();
        public Form1()
        {
            InitializeComponent();
            panelListSong.FlowDirection = FlowDirection.TopDown;
            DataAccess.Initialization.InitializePlayList(panelListSong);
            Initialization.FillPlaylistPanel(panelListSong, Application.StartupPath + "\\storage.bin", flowLayoutPanelPlaylist);
            DataAccess.Initialization.InitializeFormControls(this.labelCurrentSong, btnLoop, btnShuffle, btnPlay, trackbarVolume, panelListSong, metroLabelCurrentPosition, metroTrackBarVolume, timer1, metroUserControlMute, metroTextBoxShowLyric,pictureBoxMagic, flowLayoutPanelPlaylist);

            //settup settings for player and other interfaces
            FormControls.currentSongLabel.Text = MainConnection.GetInstance().currentMedia.name;
            FormControls.volumeTrackbar.Value = MainConnection.GetInstance().settings.volume;
            FormControls.muteButton.BackColor = (MainConnection.GetInstance().settings.mute) ? Color.DarkCyan : Color.Transparent;
            metroTextBoxLyric.Visible = false;
            metroButtonSaveLyric.Visible = false;
        }

        //Fanstatic fancy work for preventing flickering when adding controls into panel
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataAccess.MainConnection.OperateSong(new Business.Next());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DataAccess.MainConnection.OperateSong(new Business.Back());
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (DataAccess.MainConnection.GetInstance().playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                DataAccess.MainConnection.OperateSong(new Pause());
            }
            else
            {
                DataAccess.MainConnection.OperateSong(new Play());
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (MainConnection.GetInstance().settings.getMode("loop"))
            {
                MainConnection.GetInstance().settings.setMode("loop", false);
                MainConnection.GetInstance().settings.setMode("autoRewind", true);
            }  
            else
            {
                MainConnection.GetInstance().settings.setMode("loop", true);
                MainConnection.GetInstance().settings.setMode("autoRewind", false);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (MainConnection.GetInstance().settings.getMode("shuffle"))
            {
                MainConnection.GetInstance().settings.setMode("shuffle", false);
            }
            else
            {
                MainConnection.GetInstance().settings.setMode("shuffle", true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            if (MainConnection.GetInstance().settings.volume <= 95)
            {
                MainConnection.GetInstance().settings.volume += 5;
                FormControls.volumeTrackbar.Value = MainConnection.GetInstance().settings.volume;
            }
        }

        private void trackbarVolume_ValueChanged(object sender, EventArgs e)
        {
            MainConnection.GetInstance().settings.volume = trackbarVolume.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FormControls.trackbarDuration.Value = Convert.ToInt16(MainConnection.GetInstance().controls.currentPosition);
            FormControls.labelDuration.Text =Convert.ToInt16( MainConnection.GetInstance().controls.currentPosition / 60) + ":" + Convert.ToInt16(MainConnection.GetInstance().controls.currentPosition % 60);        
        }

        private void metroTrackBarVolume_MouseUp(object sender, MouseEventArgs e)
        {
            MainConnection.GetInstance().controls.currentPosition = FormControls.trackbarDuration.Value;
            MainConnection.GetInstance().controls.play();
            FormControls.timerDuration.Enabled = true;
        }

        private void metroTrackBarVolume_MouseDown(object sender, MouseEventArgs e)
        {
            MainConnection.GetInstance().controls.pause();
            FormControls.timerDuration.Enabled = false;
        }

        private void metroUserControlMute_Click(object sender, EventArgs e)
        {
            if (MainConnection.GetInstance().settings.mute)
            {
                MainConnection.GetInstance().settings.mute = false;
                FormControls.muteButton.BackColor = Color.Transparent;
            }
            else
            {
                MainConnection.GetInstance().settings.mute = true;
                FormControls.muteButton.BackColor = Color.DarkCyan;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia tempMedia = MainConnection.GetInstance().currentMedia;
            MainConnection.GetInstance().controls.next();
            Mp3File file = new Mp3Lib.Mp3File(tempMedia.sourceURL);
            file.TagHandler.Lyrics = metroTextBoxLyric.Text;
            file.Update();
            metroTextBoxLyric.Visible = false;
            metroButtonSaveLyric.Visible = false;
            metroTextBoxLyric.Text = "Paste your lyric here";
            metroTextBoxShowLyric.Text = file.TagHandler.Lyrics;
            MainConnection.GetInstance().controls.previous();
        }

        private void metroUserControlAddLyric_Click(object sender, EventArgs e)
        {
            if (metroTextBoxLyric.Visible && metroButtonSaveLyric.Visible )
            {
                metroTextBoxLyric.Visible = false;
                metroButtonSaveLyric.Visible = false;
            }
            else
            {
                metroTextBoxLyric.Visible = true;
                metroButtonSaveLyric.Visible = true;
            }
        }

        private void metroUserControlSetting_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"C:\";
                open.RestoreDirectory = true;
                open.Title = "Browse your back ground picture";
                open.DefaultExt = "jpg";
                open.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string temp = open.FileName;
                    this.BackgroundImage = Bitmap.FromFile(temp);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }     
            }
            catch(Exception)
            {
                MessageBox.Show("The file should be .jpg");
            }
        }

        private void panelListSong_Paint(object sender, PaintEventArgs e)
        {
            panelListSong.BackColor = Color.Transparent;
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            if (MainConnection.GetInstance().settings.volume >= 5)
            {
                MainConnection.GetInstance().settings.volume -= 5;
                FormControls.volumeTrackbar.Value = MainConnection.GetInstance().settings.volume;
            }         
        }

        private void metroUserControlShowHideLyric_Click(object sender, EventArgs e)
        {
            if (metroTextBoxShowLyric.Location.X < 1080)
            {
                metroTextBoxShowLyric.Location = new Point(1080, metroTextBoxShowLyric.Location.Y);//1038 410
                metroUserControlShowHideLyric.Location = new Point(1038, 410);
            }
            else
            {
                metroTextBoxShowLyric.Location = new Point(771, metroTextBoxShowLyric.Location.Y);
                metroUserControlShowHideLyric.Location = new Point(735, 410);
            }
        }

        private void metroUserControlSleeper_Click(object sender, EventArgs e)
        {
            FormControls.sleeper += 10;
            if (FormControls.sleeper > 0)
            {
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (FormControls.sleeper >0)
            {
                FormControls.sleeper--;
                labelSleeper.Text = (FormControls.sleeper / 60).ToString() + ":"+(FormControls.sleeper%60).ToString();
            }
             else
            {
                MainConnection.OperateSong(new Pause());
                timer2.Enabled = false;
            }
        }

        private void metroUserControl1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"C:\";
                open.RestoreDirectory = true;
                open.Title = "Browse your Music";
                open.DefaultExt = "mp3";
                open.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                open.Multiselect = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string[] paths = open.FileNames;
                    if (paths != null)
                    { 
                        if (MainConnection.GetInstance().currentPlaylist.name == "All Songs")
                        {
                            foreach (string item in paths)
                            {
                                System.IO.File.Move(item, Application.StartupPath + "\\Songs" + item.Substring(item.LastIndexOf("\\")));
                            }
                        }
                        else
                        {
                            Playlist pl = Initializer.GetPlaylistByName(MainConnection.GetInstance().currentPlaylist.name);
                            int selectedIndex = -1;
                            foreach (var control in flowLayoutPanelPlaylist.Controls)
                            {
                                if (control is MetroFramework.Controls.MetroTile && ((MetroFramework.Controls.MetroTile)control).BackColor == Color.DarkCyan)
                                {
                                    selectedIndex = Convert.ToInt16(((MetroFramework.Controls.MetroTile)control).Name);
                                }
                            }
                            foreach (string item in paths)
                            {
                                if (Initializer.allPlayLists[selectedIndex].SongPaths.Contains(Application.StartupPath + "\\songs" + item.Substring(item.LastIndexOf("\\"))))
                                {
                                    MessageBox.Show(item.Substring(item.LastIndexOf("\\")) + " already exists in the playlist.");
                                }
                                else
                                {
                                    try
                                    {
                                        System.IO.File.Move(item, Application.StartupPath + "\\songs" + item.Substring(item.LastIndexOf("\\")));
                                    }
                                    catch (Exception)
                                    {

                                    }
                                    pl.AddSongToPlaylist(Application.StartupPath + "\\songs" + item.Substring(item.LastIndexOf("\\")));
                                    Initializer.SavePlayLists(Application.StartupPath + "\\storage.bin");
                                }                                
                            }
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("There is no selected file");
                    }
                    MessageBox.Show("Successfully added song into playlist");
                    Initialization.InitializePlayList(panelListSong);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The song with the same name already exists in the app");
            }
        }

        private void btnAllSongs_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelPlaylist.Controls)
            {
                if (item is MetroFramework.Controls.MetroTile && ((MetroFramework.Controls.MetroTile)item).BackColor != Color.Transparent)
                {
                    ((MetroFramework.Controls.MetroTile)item).BackColor = Color.Transparent;
                }
            }
            ((MetroFramework.Controls.MetroTile)sender).BackColor = Color.DarkCyan;
            Initialization.InitializePlayList(panelListSong);
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the playlist", "Creating new playlist", "", 0, 0);
            if (result != "")
            {
                try
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.InitialDirectory = @"Application.StartupPath "+ "\\songs";
                    open.RestoreDirectory = true;
                    open.Title = "Ad Music to playlist";
                    open.DefaultExt = "mp3";
                    open.Filter = "mp3 files (*.mp3)|*.mp3";
                    open.Multiselect = true;
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        string[] paths = open.FileNames;
                        if (paths != null)
                        {
                            Playlist pl = new Playlist(result);
                            foreach (string item in paths)
                            {
                                pl.AddSongToPlaylist(item);
                            }
                            if(Initializer.AddPlayList(pl))
                            {
                                Initializer.SavePlayLists(Application.StartupPath + "\\storage.bin");
                                Initialization.FillPlaylistPanel(panelListSong, Application.StartupPath + "\\storage.bin", flowLayoutPanelPlaylist);
                                MessageBox.Show("Successfully added song into playlist");
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no selected file");
                        }
                    }
                }
                catch (Exception)
                {}
            }
            else
            {
                MessageBox.Show("You did not enter name for playlist");
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            foreach (Playlist item in Initializer.allPlayLists)
            {
                MessageBox.Show(item.PlaylistName);
            }
        }

        private void btnHideList_Click(object sender, EventArgs e)
        {
            switch (indexForHidingPlaylistAndSongs)
            {
                case 1:
                    {
                        flowLayoutPanelPlaylist.Visible = true;
                        panelListSong.Visible = false;
                        indexForHidingPlaylistAndSongs = 2;
                        break;
                    }
                case 2:
                    {
                        flowLayoutPanelPlaylist.Visible = false;
                        panelListSong.Visible = false;
                        indexForHidingPlaylistAndSongs = 3;
                        break;
                    }
                case 3:
                    {
                        flowLayoutPanelPlaylist.Visible = true;
                        panelListSong.Visible = true;
                        indexForHidingPlaylistAndSongs = 1;
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //draggablize control
            //ControlExtension.Draggable(btnHideList, true);
            //ControlExtension.Draggable(pictureBox1, true);
        }

        private void flowLayoutPanelPlaylist_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBoxDelete.BackgroundImage;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBoxDelete.Image = null;
            }
        }

        private void btnAllSongs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void btnAllSongs_DragDrop(object sender, DragEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to DELETE this. Action CANNOT be retrieved back", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanelPlaylist.Controls.Remove(flowLayoutPanelPlaylist.Controls.Find("btnAllSongs", true)[0]);
            }
        }

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
            this.Opacity = 0.5;
        }

        private void panelTaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void panelTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
            this.Opacity = 1;
        }

        private void panelListSong_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void panelListSong_DragDrop(object sender, DragEventArgs e)
        {
        
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            System.IO.File.Copy(file[0], Application.StartupPath + "\\Songs" + file[0].Substring(file[0].LastIndexOf("\\")));
        }
    }
}
