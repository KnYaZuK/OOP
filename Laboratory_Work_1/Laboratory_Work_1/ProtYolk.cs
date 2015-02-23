using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class ProtYolk
	{
		bool splited;
		public bool Splited
		{
			get { return splited; }
			set { splited = value; }
		}

		Protein protein;
		public Protein Protein
		{
			get { return protein; }
			set { protein = value; }
		}

		Yolk yolk;
		public Yolk Yolk
		{
			get { return yolk; }
			set { yolk = value; }
		}

		public ProtYolk()
		{
			Splited = false;
		}
	}
}
