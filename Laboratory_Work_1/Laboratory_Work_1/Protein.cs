using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Protein
	{
		bool shaked;
		public bool Shaked
		{
			get { return shaked; }
			set { shaked = value; }
		}

		public Protein()
		{
			Shaked = false;
		}
	}
}
