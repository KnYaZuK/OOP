using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Laboratory_Work_5
{
	class Rocket : GObject, IDraw
	{
		public Rocket(int x, int y) : base(x, y) 
		{
			Height = 70;
			Width = 170;
		}

		public override void Draw(Graphics g)
		{
			DrawTopWing(g);
			DrawBottomWing(g);
			DrawBody(g);
			DrawTip(g);
			DrawWindows(g);
		}

		private void DrawTopWing(Graphics g)
		{
			Point p1 = new Point((int)(starting.X + 0.6 * Width), (int)(starting.Y + 0.1 * Height));
			Point p2 = new Point((int)(starting.X + 0.95 * Width), (int)(starting.Y + 0.3 * Height));
			Point p3 = new Point((int)(starting.X + 1.2 * Width), (int)(starting.Y - 0.4 * Height));

			Point[] triangle = new Point[] { p1, p2, p3 };

			g.FillPolygon(Brushes.Yellow, triangle);
			g.DrawPolygon(Pens.Black, triangle);
		}

		private void DrawBottomWing(Graphics g)
		{
			int x0 = starting.X;
			int y0 = (int)(starting.Y + Height * 0.95);

			Point p1 = new Point((int)(x0 + 0.6 * Width), (int)(y0 - 0.1 * Height));
			Point p2 = new Point((int)(x0 + 0.95 * Width), (int)(y0 - 0.2 * Height));
			Point p3 = new Point((int)(x0 + 1.2 * Width), (int)(y0 + 0.4 * Height));

			Point[] triangle = new Point[] { p1, p2, p3 };

			g.FillPolygon(Brushes.Yellow, triangle);
			g.DrawPolygon(Pens.Black, triangle);
		}

		private void DrawTip(Graphics g)
		{
			int x0 = this.starting.X - 53;
			int y0 = this.starting.Y;
			Pen p1 = new Pen(Color.Black, 2);
			g.DrawArc(p1, x0, y0, Width - 60, Height, -40, 80);
		}

		private void DrawBody(Graphics g) 
		{
			g.FillEllipse(Brushes.Red, starting.X, starting.Y, Width, Height);
			g.DrawEllipse(Pens.Black, starting.X, starting.Y, Width, Height);
		}

		private void DrawWindows(Graphics g)
		{
			int x1 = (int)(starting.X + Width * 0.4);
			int y1 = (int)(starting.Y + Height * 0.4);

			g.FillEllipse(Brushes.Blue, x1, y1, 17, 17);
			g.DrawEllipse(Pens.Black, x1, y1, 17, 17);

			x1 = (int)(starting.X + Width * 0.6);

			g.FillEllipse(Brushes.Blue, x1, y1, 17, 17);
			g.DrawEllipse(Pens.Black, x1, y1, 17, 17);

			x1 = (int)(starting.X + Width * 0.8);

			g.FillEllipse(Brushes.Blue, x1, y1, 17, 17);
			g.DrawEllipse(Pens.Black, x1, y1, 17, 17);
		}
	}
}
