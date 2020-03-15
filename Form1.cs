using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundButtons
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {

            if(mouseDown == true)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
