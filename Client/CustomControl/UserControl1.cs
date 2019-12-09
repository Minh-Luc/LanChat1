using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel5.BackColor = Color.LightGray;
            BackColor = Color.Turquoise;
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            BackColor = Color.Aquamarine;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel5.BackColor = Color.LightGray;
            BackColor = Color.Turquoise;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            BackColor = Color.Aquamarine;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel5.BackColor = Color.LightGray;
            BackColor = Color.Turquoise;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            BackColor = Color.Aquamarine;
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightSeaGreen;
        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.Turquoise;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightSeaGreen;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.Turquoise;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightSeaGreen;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.Turquoise;
        }
    }
}
