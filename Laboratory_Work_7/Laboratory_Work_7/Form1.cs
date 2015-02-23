using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_7
{
	public partial class Form1 : Form
	{
		Graphics g;
		Bitmap bm;
		Line ln;

		public Form1()
		{
			InitializeComponent();

			bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bm);

			ln = new Line(30, 150);

			bm = ln.Draw(g, pictureBox1.Width, pictureBox1.Height);

			pictureBox1.Image = bm;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Link);
		}

		private void label1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
			ln += ln;
			bm = ln.Draw(g, pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Image = bm;
		}

		private void label1_DragDrop(object sender, DragEventArgs e)
		{
			bm = ln.Draw(g, pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Image = bm;
		}
	}
}
