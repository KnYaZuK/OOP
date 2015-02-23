using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Bowl
	{
		bool shaked;
		public bool Shaked
		{
			get { return shaked; }
			set { shaked = value; }
		}

		bool[] prot = new bool[5];

		bool sygar;
		public bool Sygar
		{
			get { return sygar; }
			set { sygar = value; }
		}

		bool[] yolk = new bool[5];

		bool soda;
		public bool Soda
		{
			get { return soda; }
			set { soda = value; }
		}

		bool meal;
		public bool Meal
		{
			get { return meal; }
			set { meal = value; }
		}

		public Bowl()
		{
			Shaked = true;
			for (int i = 5; i < 5; i++)
			{
				prot[i] = false;
				yolk[i] = false;
			}
			Sygar = false;
			Soda = false;
			Meal = false;
		}

		public void add_prot(Protein p, byte i)
		{
			prot[i] = true;
			Shaked = false;
		}

		public void add_sygar(Sygar s)
		{
			sygar = true;
			Shaked = false;
		}

		public void add_yolk(Yolk p, byte i)
		{
			yolk[i] = true;
			Shaked = false;
		}

		public void add_meal(Meal m)
		{
			meal = true;
			Shaked = false;
		}

		public void add_soda(Soda s)
		{
			soda = true;
			Shaked = false;
		}

		public void Pour_Half(Pan p)
		{
			p.Filled_half = true;
		}

		public void Pour(Pan p)
		{
			p.Filled_full = true;
		}

	}
}
