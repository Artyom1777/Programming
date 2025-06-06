using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easy_animation
{
    public partial class Form1 : Form
    {
        int d = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + d;
            if (pictureBox1.Left>=640 || pictureBox1.Left<=0)
            {
                if (d > 0) pictureBox1.Image = Image.FromFile("ris2.jpg");
                if (d < 0) pictureBox1.Image = Image.FromFile("ris.jpg");
                d = -d;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (d <= 0) d = trackBar1.Value;
            if (d < 0) d = -trackBar1.Value;

        }
    }
}
