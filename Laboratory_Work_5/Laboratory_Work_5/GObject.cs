using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratory_Work_5
{
	class GObject : IDraw
	{
		public Point starting;
		public int Height { get; set; }
		public int Width { get; set; }
		

		public GObject ( int x, int y )
		{
			starting = new Point(x, y);
		}

		public virtual void Draw ( Graphics g )
		{

		}


	}
}
