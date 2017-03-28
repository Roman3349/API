using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vektory
{
    public partial class Form1 : Form
    {
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
            this.gfx = this.pictureBox1.CreateGraphics();
        }

        private void vykresliOsy(Graphics gfx)
        {
            gfx.DrawLine(Pens.Black, 0, 240, 480, 240);
            gfx.DrawLine(Pens.Black, 240, 0, 240, 480);
        }

        private void vykresliVektory(Graphics gfx, int v1, int v2, int u1, int u2)
        {
            int s = 240;
            int _u1 = s + u1;
            int _u2 = s - u2;
            int _v1 = s + v1;
            int _v2 = s - v2;
            gfx.Clear(this.pictureBox1.BackColor);
            gfx.DrawLine(Pens.Blue, s, s, _v1, _v2);
            gfx.DrawLine(Pens.Green, s, s, _u1, _u2);
            //gfx.DrawLine(Pens.Green, _v1, _v2, _v1 + u1, _v2 - u2);
            //gfx.DrawLine(Pens.Green, _u1, _u2, _u1 + v1, _u2 - v2);
            gfx.DrawLine(Pens.Red, s, s, _u1 + v1, _u2 - v2);
            gfx.DrawLine(Pens.Violet, _v1, _v2, _u1, _u2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.vykresliOsy(this.gfx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int u1 = Convert.ToInt32(this.u1.Text);
            int u2 = Convert.ToInt32(this.u2.Text);
            int v1 = Convert.ToInt32(this.v1.Text);
            int v2 = Convert.ToInt32(this.v2.Text);
            this.vykresliVektory(this.gfx, v1, v2, u1, u2);
            this.vykresliOsy(this.gfx);
        }
    }
}
