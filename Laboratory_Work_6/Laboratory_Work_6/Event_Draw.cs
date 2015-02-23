using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratory_Work_6
{
	delegate void DDrawing(Graphics g);

	class Event_Drawing
	{
		private Bitmap bm;
		private Graphics g;

		public Event_Drawing(Bitmap _bm)
		{
			bm = _bm;
			g = Graphics.FromImage(bm);

			g.FillRectangle(Brushes.Cyan, 0, 0, _bm.Width, _bm.Height);
		}

		public event DDrawing ev;

		public void Sign ( DDrawing _ev )
		{
			if (ev == null)
			{
				ev = new DDrawing(_ev);
			}
			else
			{
				ev += _ev;
			}
		}

		public Bitmap Output()
		{
			if (ev != null)
			{
				ev(g);
			}
				
			return bm;
		}

		public void ClearEvents()
		{
			ev = null;
		}

		public void ClearImage()
		{
			Bitmap nbm = new Bitmap(bm.Width, bm.Height);
			bm = nbm;
		}
	}
}
