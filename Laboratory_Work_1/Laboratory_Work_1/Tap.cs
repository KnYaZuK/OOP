using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Tap
	{
		bool opened;
		public bool Opened
		{
			get { return opened; }
			set { opened = value; }
		}

		public Tap()
		{
			Opened = false;
		}

		public void open()
		{
			Opened = true;
		}

		public void close()
		{
			Opened = false;
		}

		public void wash(Apple a)
		{
			if (Opened)
				a.Clean = true;
		}
	}
}
