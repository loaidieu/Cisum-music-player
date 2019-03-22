using Cisum.DataAccess;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cisum.Business
{
    class Back : IMusicOperation
    {
        public void Execute()
        {
            DataAccess.MainConnection.GetInstance().controls.previous();
            FormControls.trackbarDuration.Maximum = Convert.ToInt16(MainConnection.GetInstance().currentMedia.duration);
            Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(MainConnection.GetInstance().currentMedia.sourceURL);
            FormControls.txtLyric.Text = (file.TagHandler.Lyrics != "") ? file.TagHandler.Lyrics : "No lyric";
            MetroTile tempButton = new MetroTile();
            for (int i = 0; i < FormControls.panelSongList.Controls.Count; i++)
            {
                if (MainConnection.GetInstance().currentMedia.name == FormControls.panelSongList.Controls[i].Text)
                {
                    tempButton =(MetroTile) FormControls.panelSongList.Controls[i];
                    break;
                }
            }          
            tempButton.BackColor = Color.DarkCyan;
            MainConnection.currentSongObject.BackColor = Color.Transparent;
            MainConnection.currentSongObject = tempButton;
        }
    }
}
