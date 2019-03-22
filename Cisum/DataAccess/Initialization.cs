using Cisum.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using MetroFramework.Controls;
using System.Threading;

namespace Cisum.DataAccess
{
    static class Initialization
    {
        public static string path = Application.StartupPath + "\\songs";

        public static void InitializeFormControls(Label songname, MetroUserControl repeat, MetroUserControl shuffle, MetroUserControl play, MetroTrackBar volumeTrackbar, Panel panelSongList, MetroLabel labelDuration, MetroTrackBar trackbarDuration, System.Windows.Forms.Timer timerDuration, MetroUserControl muteButton, MetroTextBox txtLyric, PictureBox magicBox, Panel panelPlaylist)
        {
            FormControls.currentSongLabel = songname;
            FormControls.repeatButton = repeat;
            FormControls.shuffleButton = shuffle;
            FormControls.playButton = play;
            FormControls.volumeTrackbar = volumeTrackbar;
            FormControls.panelSongList = panelSongList;
            FormControls.labelDuration = labelDuration;
            FormControls.trackbarDuration = trackbarDuration;
            FormControls.timerDuration = (System.Windows.Forms.Timer)timerDuration;
            FormControls.muteButton = muteButton;
            FormControls.txtLyric = txtLyric;
            FormControls.magicBox = magicBox;
            FormControls.panelPlaylist = panelPlaylist;
        }

        public static void InitializePlayList(Panel panel)
        {
            string[] songs = Directory.GetFiles(path, "*.mp3");
            if (songs == null)
            {
                MessageBox.Show("No Song in the app. Please Add song to the app");
            }
            else
            {
                IWMPPlaylist playlist = MainConnection.GetInstance().playlistCollection.newPlaylist("All Music");
                panel.Controls.Clear();
                foreach (string item in songs)
                {
                    IWMPMedia media = MainConnection.GetInstance().newMedia(item);
                    playlist.appendItem(media);
                }
                MainConnection.GetInstance().currentPlaylist = playlist;
            }
            MainConnection.GetInstance().settings.setMode("shuffle", true);
            FillPanel(MainConnection.GetInstance().currentPlaylist, panel);
        }

        public static void FillPanel(IWMPPlaylist playlist, Panel panel)
        {
            void song_click(object sender, EventArgs e)
            {
                //name of the button in the playlist is the index.
                Play.PlayItem(((MetroFramework.Controls.MetroTile)sender).Name);

                if (MainConnection.currentSongObject != null)
                {
                    MainConnection.currentSongObject.BackColor = Color.Transparent;
                }
                MainConnection.currentSongObject = (MetroFramework.Controls.MetroTile)sender;
                MainConnection.currentSongObject.BackColor = Color.DarkCyan;
            }
            if (playlist.count != 0)
            {
                panel.Controls.Clear();
                for (int i = 0; i < playlist.count; i++)
                {

                    MetroTile metroTile1 = new MetroTile();
                    metroTile1.ActiveControl = null;
                    metroTile1.BackColor = Color.Transparent;
                    metroTile1.Location = new Point(3, 3);
                    //name of the button hold the song is the index of the song in the current playlist.
                    metroTile1.Name = i.ToString();
                    metroTile1.Size = new Size(346, 47);
                    metroTile1.TabIndex = 0;
                    metroTile1.Text = playlist.Item[i].name;
                    metroTile1.TextAlign = ContentAlignment.MiddleLeft;
                    metroTile1.TileImage = Properties.Resources.playing;
                    metroTile1.TileImageAlign = ContentAlignment.MiddleRight;
                    metroTile1.UseCustomBackColor = true;
                    metroTile1.UseSelectable = true;
                    metroTile1.UseTileImage = true;
                    metroTile1.UseCustomBackColor = true;
                    metroTile1.Tag = playlist.Item[i].sourceURL;
                    metroTile1.Click += new EventHandler(song_click);
                    //for drag drop effect
                    metroTile1.AllowDrop = true;
                    metroTile1.DragEnter += MetroTile1_DragEnter;
                    metroTile1.DragDrop += MetroTile1_DragDrop1;

                    panel.Controls.Add(metroTile1);
                    if (metroTile1.Text == MainConnection.GetInstance().currentMedia.name)
                    {
                        metroTile1.BackColor = System.Drawing.Color.DarkCyan;
                        MainConnection.currentSongObject = metroTile1;
                    }

                }
            }
        }

        private static void MetroTile1_DragDrop1(object sender, DragEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to DELETE this. Action CANNOT be retrieved back", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (MainConnection.GetInstance().currentPlaylist.name != "All Music")
                {
                    Initializer.GetPlaylistByName(MainConnection.GetInstance().currentPlaylist.name).SongPaths.Remove(((MetroTile)sender).Tag.ToString());
                    Initializer.SavePlayLists(Application.StartupPath + "\\storage.bin");
                    FormControls.panelSongList.Controls.Remove(FormControls.panelSongList.Controls.Find(((MetroTile)sender).Name, true)[0]);
                }
            }
        }

        //
        public static void FillPlaylistPanel(Panel panelSong, string xmlFilePath, Panel panelPlaylist)
        {
            //clear controls in panel playlist except All Music
            foreach (var item in panelPlaylist.Controls)
            {
                if (item is MetroTile && ((MetroTile)item).Text == "All Songs")
                { }
                else
                {
                    panelPlaylist.Controls.Remove((Control)item);
                }
            }

            //fill the default all songs playlist          
            Playlist allSongs = new Playlist("All Songs");
            string[] songs = Directory.GetFiles(Initialization.path, "*.mp3");
            if (songs == null)
            {
                MessageBox.Show("No Song in the app. Please Add song to the app");
            }
            else
            {
                IWMPPlaylist playlist = MainConnection.GetInstance().playlistCollection.newPlaylist("All songs");
                Initializer.allPlayLists.Add(new Playlist("All songs"));
                panelSong.Controls.Clear();
                foreach (string item in songs)
                {
                    IWMPMedia media = MainConnection.GetInstance().newMedia(item);
                    playlist.appendItem(media);
                }
                MainConnection.GetInstance().currentPlaylist = playlist;
                Initialization.FillPanel(MainConnection.GetInstance().currentPlaylist, panelSong);
            }
            if (File.Exists(xmlFilePath))
            {
                Initializer.allPlayLists = Initializer.LoadPlayLists(xmlFilePath);
                for (int i = 0; i < Initializer.allPlayLists.Count; i++)
                {
                    void playlist_click(object sender, EventArgs e)
                    {
                        foreach (var item in panelPlaylist.Controls)
                        {
                            if (item is MetroTile && ((MetroTile)item).BackColor != Color.Transparent)
                            {
                                ((MetroFramework.Controls.MetroTile)item).BackColor = Color.Transparent;
                            }
                            ((MetroTile)sender).BackColor = Color.DarkCyan;
                        }
                        panelSong.SuspendLayout();
                        IWMPPlaylist playlist = MainConnection.GetInstance().playlistCollection.newPlaylist(((MetroFramework.Controls.MetroTile)sender).Text);
                        panelSong.Controls.Clear();
                        foreach (string singleItem in Initializer.allPlayLists[Convert.ToInt16(((MetroFramework.Controls.MetroTile)sender).Name)].SongPaths)
                        {
                            IWMPMedia media = MainConnection.GetInstance().newMedia(singleItem);
                            playlist.appendItem(media);
                        }
                        MainConnection.GetInstance().currentPlaylist = playlist;
                        FillPanel(MainConnection.GetInstance().currentPlaylist, panelSong);
                        panelSong.ResumeLayout();
                    }
                    MetroTile metroTile1 = new MetroTile();
                    metroTile1.ActiveControl = null;
                    metroTile1.BackColor = Color.Transparent;
                    metroTile1.Location = new Point(3, 3);
                    //name of the button hold the song is the index of the song in the current playlist.
                    metroTile1.Name = i.ToString();
                    metroTile1.Size = new Size(100, 47);
                    metroTile1.TabIndex = 0;
                    metroTile1.Text = Initializer.allPlayLists[i].PlaylistName;
                    metroTile1.TextAlign = ContentAlignment.MiddleLeft;
                    //metroTile1.TileImage = Properties.Resources.playing;
                    //metroTile1.TileImageAlign = ContentAlignment.MiddleRight;
                    metroTile1.UseCustomBackColor = true;
                    metroTile1.UseSelectable = true;
                    //metroTile1.UseTileImage = true;
                    metroTile1.UseCustomBackColor = true;
                    metroTile1.Click += new EventHandler(playlist_click);
                    //for drag and drop effect
                    metroTile1.AllowDrop = true;
                    metroTile1.DragEnter += MetroTile1_DragEnter;
                    metroTile1.DragDrop += MetroTile1_DragDrop;
                    panelPlaylist.Controls.Add(metroTile1);


                }
            }

            //fill all playlist into playlist Panel

        }

        private static void MetroTile1_DragDrop(object sender, DragEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to DELETE this. Action CANNOT be retrieved back", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Initializer.allPlayLists.Remove(Initializer.allPlayLists[Convert.ToInt16(((MetroTile)sender).Name)]);
                Initializer.SavePlayLists(Application.StartupPath + "\\storage.bin");
                FormControls.panelPlaylist.Controls.Remove(FormControls.panelPlaylist.Controls.Find(((MetroTile)sender).Name, true)[0]);
            }
        }

        private static void MetroTile1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }
    }

    class MainConnection
    {
        private static WindowsMediaPlayer player;
        public static MetroFramework.Controls.MetroTile currentSongObject;

        //event handlers declaration
        private static void player_CurrentItemChange(object pdispMedia)
        {
            FormControls.currentSongLabel.Text = player.currentMedia.name;
        }
        private static void Player_ModeChange(string ModeName, bool NewValue)
        {
            if (player.settings.getMode("loop"))
            {
                FormControls.repeatButton.BackgroundImage = new Bitmap(Properties.Resources.repeat);
            }

            if (player.settings.getMode("shuffle"))
            {
                FormControls.shuffleButton.BackgroundImage = new Bitmap(Properties.Resources.shuffle);
            }
            else
            {
                FormControls.shuffleButton.BackgroundImage = new Bitmap(Properties.Resources.order);
            }

            if (player.settings.getMode("autoRewind"))
            {
                FormControls.repeatButton.BackgroundImage = new Bitmap(Properties.Resources.repeate);
            }

        }
        private static void Player_PositionChange(double oldValue, double newValue)
        {
            FormControls.labelDuration.Text = newValue.ToString();
        }

        private static void Player_MediaChange(object Item)
        {
            FormControls.trackbarDuration.Maximum = Convert.ToInt16(MainConnection.GetInstance().currentMedia.duration);
            MetroTile tempButton = new MetroTile();
            for (int i = 0; i < FormControls.panelSongList.Controls.Count; i++)
            {
                if (MainConnection.GetInstance().currentMedia.name == FormControls.panelSongList.Controls[i].Text)
                {
                    tempButton = (MetroTile)FormControls.panelSongList.Controls[i];
                    break;
                }
            }
            tempButton.BackColor = Color.DarkCyan;
            MainConnection.currentSongObject.BackColor = Color.Transparent;
            MainConnection.currentSongObject = tempButton;
        }
        private static void Player_PlayStateChange(int NewState)
        {
            switch (NewState)
            {
                case 0:    // Undefined

                    break;

                case 1:    // Stopped

                    break;

                case 2:    // Paused

                    break;

                case 3:    // Playing

                    break;

                case 4:    // ScanForward

                    break;

                case 5:    // ScanReverse

                    break;

                case 6:    // Buffering

                    break;

                case 7:    // Waiting

                    break;

                case 8:    // MediaEnded
                    {
                        break;
                    }


                case 9:    // Transitioning
                    {
                        FormControls.trackbarDuration.Maximum = Convert.ToInt16(player.currentMedia.duration);
                        Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(MainConnection.GetInstance().currentMedia.sourceURL);
                        FormControls.txtLyric.Text = (file.TagHandler.Lyrics != "") ? file.TagHandler.Lyrics : "No lyric";

                        MetroTile tempButton = new MetroTile();
                        for (int i = 0; i < FormControls.panelSongList.Controls.Count; i++)
                        {
                            if (MainConnection.GetInstance().currentMedia.name == FormControls.panelSongList.Controls[i].Text)
                            {
                                tempButton = (MetroTile)FormControls.panelSongList.Controls[i];
                                break;
                            }
                        }
                        tempButton.BackColor = Color.DarkCyan;
                        MainConnection.currentSongObject.BackColor = Color.Transparent;
                        MainConnection.currentSongObject = tempButton;

                        break;
                    }


                case 10:   // Ready
                    {
                        FormControls.trackbarDuration.Maximum = Convert.ToInt16(player.currentMedia.duration);
                   
                        break;
                    }

                case 11:   // Reconnecting

                    break;

                case 12:   // Last

                    break;
            }

        }
        //end event handler declaration

        private MainConnection() { }


        public static WindowsMediaPlayer GetInstance()
        {
            if (player == null)
            {
                player = new WMPLib.WindowsMediaPlayer();
                player.settings.autoStart = false;
                //sleeper = 0 second;
                FormControls.sleeper = 0;
                //adding event handler into the player
                player.CurrentItemChange += player_CurrentItemChange;
                player.ModeChange += Player_ModeChange;
                player.PositionChange += new WMPLib._WMPOCXEvents_PositionChangeEventHandler(Player_PositionChange);
                player.PlayStateChange += Player_PlayStateChange;


                return player;
            }
            else
            {
                return player;
            }
        }

        public static void OperateSong(IMusicOperation operation)
        {
            if (player.URL != null)
            {
                operation.Execute();
            }
            else
            {
                MessageBox.Show("Please select the song");
            }
        }


    }

}
