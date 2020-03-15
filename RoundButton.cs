using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoundButtons
{
    class RoundButton : Button
    { 
        protected override void OnResize(EventArgs e)
        {
            using(var path = new GraphicsPath())
            {
                path.AddEllipse(new RectangleF(2, 2, this.Width - 5, this.Height - 5));
                this.Region = new Region(path);
            }
            base.OnResize(e);
        }
 
    }
}
