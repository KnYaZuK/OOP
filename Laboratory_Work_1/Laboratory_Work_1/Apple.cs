using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Apple
	{
		bool clean;
		public bool Clean
		{
			get { return clean; }
			set { clean = value; }
		}

		bool sliced;
		public bool Sliced
		{
			get { return sliced; }
			set { sliced = value; }
		}

		public Apple()
		{
			Clean = false;
			Sliced = false;
		}

	}
}
