using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_6
{
	

	public partial class Form1 : Form
	{
		Event_Drawing ed;

		public Form1()
		{
			InitializeComponent();

			ed = new Event_Drawing(new Bitmap(pictureBox1.Width, pictureBox1.Height));
		}

		private void button_Start_Click(object sender, EventArgs e)
		{

			ed = new Event_Drawing(new Bitmap(pictureBox1.Width, pictureBox1.Height));

			ed.ClearEvents();

			for ( int i = 0; i < numericUpDown_Rocket.Value; i++)
			{
				ed.Sign(new Rocket().Draw);
			}

			for (int i = 0; i < numericUpDown_Cloud.Value; i++)
			{
				ed.Sign(new Cloud().Draw);
			}

			pictureBox1.Image = ed.Output();

		}
	}
}
