using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Cisum.DataAccess
{
    class FormControls
    {
        //The user interface Form controls
        public static Label currentSongLabel;
        public static MetroUserControl repeatButton;
        public static MetroUserControl shuffleButton;
        public static MetroUserControl playButton;
        public static MetroTrackBar volumeTrackbar;
        public static Panel panelSongList;
        public static MetroLabel labelDuration;
        public static MetroTrackBar trackbarDuration;
        public static Timer timerDuration;
        public static MetroUserControl muteButton;
        public static MetroTextBox txtLyric;
        public static int sleeper;
        public static PictureBox magicBox;
        public static Panel panelPlaylist;
    }
}
