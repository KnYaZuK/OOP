using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Charlotte
	{
		bool cooked;
		public bool Cooked
		{
			get { return cooked; }
			set { cooked = value; }
		}

		Bowl bowl;
		Furnace furnace;
		Knife knife;
		Corolla corolla;
		Eggs[] eggs = new Eggs[5];
		Sygar sygar;
		Meal meal;
		Soda soda;
		Pan pan;
		Oil oil;
		Tap tap;
		Apple[] apple = new Apple[7];

		public Charlotte()
		{
			Cooked = false;

			for (byte i = 0; i < 7; i++)
			{
				if (i < 5)
					eggs[i] = new Eggs();
				apple[i] = new Apple();
			}

			furnace = new Furnace();
			bowl = new Bowl();
			knife = new Knife();
			corolla = new Corolla();
			sygar = new Sygar();

			meal = new Meal();
			soda = new Soda();

			pan = new Pan();
			oil = new Oil();

			tap = new Tap();
		}

		public void cook()
		{
			furnace.Set_Power(3);

			for (byte i = 0; i < 5; i++)
			{
				knife.smash(eggs[i]);
				eggs[i].Split();
				bowl.add_prot(eggs[i].Protyolk.Protein, i);
			}
			bowl.add_sygar(sygar);
			corolla.Shake(bowl);

			for (byte i = 0; i < 5; i++)
			{
				bowl.add_yolk(eggs[i].Protyolk.Yolk, i);
			}
			bowl.add_meal(meal);
			bowl.add_soda(soda);
			corolla.Shake(bowl);

			oil.oil(pan);
			bowl.Pour_Half(pan);

			tap.open();
			for (byte i = 0; i < 7; i++)
			{
				tap.wash(apple[i]);
				knife.cut(apple[i]);
				pan.add_sliced_apples(i);
			}
			tap.close();

			bowl.Pour(pan);

			furnace.Open();
			pan.put(furnace);
			furnace.Close();

			if (furnace.Enabled)
			{
				Cooked = true;
			}
		}


	}
}
