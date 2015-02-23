using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Eggs
	{
		bool smashed;
		public bool Smashed
		{
			get { return smashed; }
			set { smashed = value; }
		}

		ProtYolk protyolk;
		public ProtYolk Protyolk
		{
			get { return protyolk; }
			set { protyolk = value; }
		}

		public Eggs()
		{
			protyolk = new ProtYolk();
			Smashed = false;

		}

		public void Split()
		{
			if (Smashed)
			{
				protyolk.Splited = true;
				protyolk.Protein = new Protein();
				protyolk.Yolk = new Yolk();
			}

		}
	}
}
