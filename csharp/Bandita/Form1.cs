using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bandita
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent ();
		}

		Random rnd = new Random ();
		int[] valce = new int[3];
		int castka = 0;

		private void btnHrej_Click (object sender, EventArgs e)
		{
			if (!checkBox1.Checked) {
				valce [0] = rnd.Next (0, 6);
			}
			if (!checkBox2.Checked) {
				valce [1] = rnd.Next (0, 6);
			}
			if (!checkBox3.Checked) {
				valce [2] = rnd.Next (0, 6);
			}
			picObrazek1.Image = imageList1.Images [valce [0]];       
			picObrazek2.Image = imageList1.Images [valce [1]];
			picObrazek3.Image = imageList1.Images [valce [2]];        

			castka--;
			if ((valce [0] == valce [1]) && (valce [1] == valce [2]) && (valce [2] == valce [0])) {
				castka += 10;
				lbVyhra.Visible = true;
			} else {
				lbVyhra.Visible = false;
			}
			lbCastka.Text = castka.ToString ();
			if (castka == 0) {
				btnHrej.Enabled = false;
			}
		}

       
		private void Form1_Load (object sender, EventArgs e)
		{
			lbVyhra.Visible = false;
			btnHrej.Enabled = false;
		}

		private void btnVloz_Click (object sender, EventArgs e)
		{
			castka = castka + Convert.ToInt32 (txtVklad.Text);
			lbCastka.Text = castka.ToString ();
			btnHrej.Enabled = true;
		}

		private void pictureBox1_Click (object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click (object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click (object sender, EventArgs e)
		{

		}
	}
}
