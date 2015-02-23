using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Knife
	{
		public void cut(Apple a)
		{
			a.Sliced = true;
		}

		public void smash(Eggs e)
		{
			e.Smashed = true;
		}
	}
}
