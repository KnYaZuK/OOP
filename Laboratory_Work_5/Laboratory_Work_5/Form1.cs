using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_5
{
	public partial class Form1 : Form
	{
		Graphics g;
		Bitmap bm;
		public Form1()
		{
			InitializeComponent();

			bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bm);
		}

		List<GObject> GO_List = new List<GObject>();

		private void button_Start_Click(object sender, EventArgs e)
		{
			GO_List.Clear();

			Random rand = new Random();

			for ( int i = 0; i < numericUpDown_Rocket.Value; i++)
			{
				Rocket rocket = new Rocket(rand.Next(0, 946 ), rand.Next(0 , 445 ));

				GO_List.Add(rocket);
			}

			for (int i = 0; i < numericUpDown_Cloud.Value; i++)
			{
				Cloud cloud = new Cloud(rand.Next(0, 946), rand.Next(0, 445));

				GO_List.Add(cloud);
			}

			g.FillRectangle(Brushes.Cyan,0,0, pictureBox1.Width, pictureBox1.Height);

			foreach( GObject go in GO_List)
			{
				go.Draw(g);
			}

			pictureBox1.Image = bm;
		}


	}
}
