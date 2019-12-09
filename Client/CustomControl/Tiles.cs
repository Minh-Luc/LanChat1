using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.CustomControl
{
    public partial class Tiles : UserControl
    {
        public string TilesIP;
        public Tiles()
        {
            InitializeComponent();
        }

        private void Tiles_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Turquoise;
        }

        private void Tiles_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.PaleTurquoise;
        }

        private void Tiles_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.MediumTurquoise;
        }

        private void Tiles_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }
    }
}
