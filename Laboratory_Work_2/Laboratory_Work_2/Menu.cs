/*
 * Меню. 
 * Содержит:
 * + пункты меню
 * + методы перемещения по пунктам меню. Перемещение осуществляется стрелками с клавиатуры. Активный пункт меню выделяется особенным образом, для отличия его от неактивного пункта.
 * + методы выбора пункта меню и соответственно запуска определённого действия. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2
{
	class Menu
	{
		List<Menu_Point> menu_point;
		int active_point;

		public Menu ()
		{
			menu_point = new List<Menu_Point>();
			active_point = -1;
			this.New_Menu_Point("Выход из программы", this.Exit);
		}

		public void New_Menu_Point( string _name, Menu_Point.callback _handler )
		{
			Menu_Point point = new Menu_Point(_name, _handler);
			menu_point.Insert(0,point);
		}

		public void Move ()
		{
			switch(Console.ReadKey(true).Key)
			{
				case ConsoleKey.UpArrow: 
					active_point--;
					if (active_point < 0)
						active_point = menu_point.Count - 1;
					break;
				case ConsoleKey.DownArrow: 
					active_point++;
					if (active_point >= menu_point.Count)
						active_point = 0;
					break;
				case ConsoleKey.Enter: 
					if ( active_point != -1)
						menu_point[active_point].Call();
					break;
				case ConsoleKey.Escape:
					active_point = -1;
					break;
					
			}
		}

		public void Print ()
		{
			Console.Clear();

			if ( menu_point.Count == 0 )
			{
				return;
			}

			for (int i = 0; i < menu_point.Count; i++ )
			{
				if ( i == active_point )
				{
					for ( int j = 0; j < menu_point[i].Name.Length + 3; j++)
					{
						if (j == 0)
							Console.Write("  ╔");
						else
							if (j == (menu_point[i].Name.Length + 2))
								Console.Write("╗\n");
							else
								Console.Write("═");
					}

					Console.Write(i + 1 + ":║");
					Console.BackgroundColor = ConsoleColor.Magenta;
					Console.Write (menu_point[i].Name + ".");
					Console.ResetColor();
					Console.Write("║\n");
					
					for (int j = 0; j < menu_point[i].Name.Length + 3; j++)
					{
						if (j == 0)
							Console.Write("  ╚");
						else
							if (j == (menu_point[i].Name.Length + 2))
								Console.Write("╝");
							else
								Console.Write("═");
					}
				}
				else
				{
					Console.WriteLine();
					Console.WriteLine(i + 1 + ": " + menu_point[i].Name + ".");
				}
			}
		}

		public void Start_Menu ()
		{
			do
			{
				Console.Clear();
				this.Print();
				this.Move();
			} while (true);
		}

		public void Exit()
		{
			Environment.Exit(0);
		}
	}
}
