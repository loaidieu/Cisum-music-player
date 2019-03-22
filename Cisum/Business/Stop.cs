using Cisum.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cisum.Business
{
    class Stop : IMusicOperation
    {
        public void Execute()
        {
            DataAccess.MainConnection.GetInstance().controls.stop();
            FormControls.playButton.BackgroundImage = new Bitmap(Cisum.Properties.Resources.play);
        }
    }
}
