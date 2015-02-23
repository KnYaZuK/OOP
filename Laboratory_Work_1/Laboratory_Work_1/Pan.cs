using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Pan
	{
		bool oiled;
		public bool Oiled
		{
			get { return oiled; }
			set { oiled = value; }
		}

		bool[] sliced_apples = new bool[7];

		bool filled_half;
		public bool Filled_half
		{
			get { return filled_half; }
			set { filled_half = value; }
		}

		bool filled_full;
		public bool Filled_full
		{
			get { return filled_full; }
			set { filled_full = value; }
		}

		public Pan()
		{
			Oiled = false;
			Filled_half = false;
			Filled_full = false;

			for (int i = 0; i < 7; i++)
			{
				sliced_apples[i] = false;
			}
		}

		public void add_sliced_apples(byte i)
		{
			sliced_apples[i] = true;
		}

		public void put(Furnace f)
		{
			f.Have_inside = true;
		}
	}
}
