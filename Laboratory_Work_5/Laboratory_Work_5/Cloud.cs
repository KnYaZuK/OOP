using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Laboratory_Work_5
{
	class Cloud : GObject, IDraw
	{
		public Cloud ( int x, int y ) : base ( x,y )
		{
			Height = 100;
			Width = 100;
		}

		public override void Draw (Graphics g)
		{
			Point p1 = new Point( starting.X + Width, starting.Y + Height);
			Point p2 = new Point((int)(starting.X + Width * 1.5),(int)( starting.Y +  Height));
			Point p3 = new Point((int)(starting.X + Width * 2), (int)(starting.Y + Height));
			Point p4 = new Point((int)(starting.X + Width * 1.5), (int)(starting.Y + Height * 0.75));

			g.FillEllipse(Brushes.Black, p1.X, p1.Y, Width, Height);
			g.FillEllipse(Brushes.Black, p2.X, p2.Y, Width, Height);
			g.FillEllipse(Brushes.Black, p3.X, p3.Y, Width, Height);
			g.FillEllipse(Brushes.Black, p4.X, p4.Y, Width, Height);

			g.FillEllipse(Brushes.White, p1.X + 7, p1.Y + 8, Width- 15, Height - 15);
			g.FillEllipse(Brushes.White, p2.X + 7, p2.Y + 8, Width- 15, Height - 15);
			g.FillEllipse(Brushes.White, p3.X + 7, p3.Y + 8, Width- 15, Height - 15);
			g.FillEllipse(Brushes.White, p4.X + 7, p4.Y + 8, Width- 15, Height - 15);
		}
	}
}
