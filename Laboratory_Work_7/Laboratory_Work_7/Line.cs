using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Laboratory_Work_7
{
	class Line
	{
		Point start;
		public int Width { get; private set; }

		public Line( int x, int y )
		{
			start = new Point(x, y);
			Width = 30;
		}

		public static Line operator + (Line l1, Line l2)
		{
			l1.Width += l2.Width;

			return l1;
		}

		public Bitmap Draw(Graphics g, int width, int height)
		{
			var bmp = new Bitmap(width, height);
			g = Graphics.FromImage(bmp);

			Pen p = new Pen(Color.Black);

			for (int i = 0; i < width || i < height; i += 30)
			{
				g.DrawLine(p, new Point(i, 0), new Point(i, height - height % 30));
				g.DrawLine(p, new Point(0, i), new Point(width - width % 30, i));
			}

			g.DrawLine( new Pen(Brushes.Red,7), start.X, start.Y, start.X + Width, start.Y);

			return bmp;
		}
	}
}
