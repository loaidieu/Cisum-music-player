using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cisum.DataAccess;

namespace Cisum.Business
{
    class Play : IMusicOperation
    {
        public void Execute()
        {
            DataAccess.MainConnection.GetInstance().controls.play();
            FormControls.playButton.BackgroundImage = new Bitmap(Cisum.Properties.Resources.pause);
            FormControls.trackbarDuration.Maximum = Convert.ToInt16(MainConnection.GetInstance().currentMedia.duration);
            Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(MainConnection.GetInstance().currentMedia.sourceURL);
            FormControls.txtLyric.Text = (file.TagHandler.Lyrics != "")? file.TagHandler.Lyrics:"No lyric";
        }
        public static void PlayItem(string songIndex)
        {
            DataAccess.MainConnection.GetInstance().controls.playItem((DataAccess.MainConnection.GetInstance().currentPlaylist.Item[Convert.ToInt16(songIndex)]));
            FormControls.playButton.BackgroundImage = new Bitmap(Cisum.Properties.Resources.pause);
            FormControls.trackbarDuration.Maximum = Convert.ToInt16(MainConnection.GetInstance().currentMedia.duration);
            Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(MainConnection.GetInstance().currentMedia.sourceURL);
            FormControls.txtLyric.Text = (file.TagHandler.Lyrics != "") ? file.TagHandler.Lyrics : "No lyric";
        }
    }
}
