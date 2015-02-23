using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2
{
	class Array_Initialization
	{
		
		
		
		bool is_Exit { get; set; }

		public Array_Initialization ()
		{
			is_Exit = false;
		}

		/* Свич, каждый раз делаем ридкей.
		 * Сохраняем значения ридкей в список символов
		 * Делаем булевые переменные для обозначения
		 * В самом конце нам необходимо выделить память под готовый массив!
		 */

		List<string> list_arr = new List<string>();

		void Read ( bool enter )
		{
			switch (Console.ReadKey(true).Key)
			{
				case ConsoleKey.Escape:
					list_arr.Add("\n");
					is_Exit = true;
					break;

				case ConsoleKey.Enter:
					if (enter)
						list_arr.Add("\n");
					break;

				case ConsoleKey.Spacebar:
					list_arr.Add(" ");
					break;

				case ConsoleKey.OemMinus:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("-");
					break;

				case ConsoleKey.D0:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("0");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "0";
					break;

				case ConsoleKey.D1:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("1");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "1";
					break;

				case ConsoleKey.D2:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("2");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "2";
					break;

				case ConsoleKey.D3:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("3");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "3";
					break;

				case ConsoleKey.D4:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("4");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "4";
					break;

				case ConsoleKey.D5:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("5");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "5";
					break;

				case ConsoleKey.D6:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("6");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "6";
					break;

				case ConsoleKey.D7:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("7");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "7";
					break;

				case ConsoleKey.D8:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("8");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "8";
					break;

				case ConsoleKey.D9:
					if (list_arr.Count == 0 || list_arr[list_arr.Count - 1] == " " || list_arr[list_arr.Count - 1] == "\n")
						list_arr.Add("9");
					else
						list_arr[list_arr.Count - 1] = list_arr[list_arr.Count - 1] + "9";
					break;
			}
		}

		void Print ( int k )
		{
			Console.Clear();

			Console.WriteLine("Введите элемент масива используя цифры 0-9.");
			if ( k == 1 || k == 2)
			{
				Console.WriteLine("\nНажмите клавишу Enter для перехода на новую строку.");
			}
			Console.WriteLine("Нажмите Клавишу Esc для окончания ввода.");
			if ( k == 2 )
			{
				Console.WriteLine("\nВажное условие: массив может быть только квадратным.\nт.е. количество строк равно количеству столбцов.");
			}
			Console.WriteLine("\n");

			for (int i = 0; i < list_arr.Count; i++)
			{
				if (list_arr[i] != " ")
					if (list_arr[i] != "\n")
						Console.Write("<" + list_arr[i] + ">\t");
					else
						Console.Write("\n");
			}
			Console.WriteLine("\n");
		}

		void Start_Read ( bool enter, int k )
		{
			list_arr.Clear();
			do
			{
				Print(k);
				Read(enter);
			} while (!is_Exit);
		}

		private int[] Convert_To_Array_Dimensional ()
		{
			int[] Mass_odnom;

			Start_Read(false,0);

			int count = 0;

			foreach (string s in list_arr)
			{
				if (s != " " && s != "\n" && s != "-")
					count++;
			}

			Mass_odnom = new int[count];
			count = 0;

			foreach (string s in list_arr)
			{

				if (s != " " && s != "-" && s != "\n" )
				{
					Mass_odnom[count] = Convert.ToInt32(s);
					count++;
				}
			}

			return Mass_odnom;
		}

		private int[,] Convert_To_Array_Two_Dimensional ()
		{
			int[,] arr_two_dimension;

			Start_Read(true,1);

			bool new_line = false;
			int lines = 1;
			int count = 0;
			int count_min = 0;

			for (int i = 1; i < list_arr.Count; i++ )
			{
				if ( list_arr[i] == "\n" && list_arr[i - 1] == "\n" || list_arr[i] == "-")
				{
					list_arr.RemoveAt(i);
				}
			}

			for (int i = 0; i < list_arr.Count; i++)
			{
				if (list_arr[i] != " ")
				{
					if (list_arr[i] != "\n")
					{
						if ( new_line )
						{
							new_line = false;
							lines++;
							count = 1;
						}
						else
						{
							count++;
						}
					}
					else
					{
						new_line = true;

						if (count_min == 0)
						{
							count_min = count;
							count = 0;
						}
						else
						{
							if (count < count_min)
							{
								count_min = count;
								count = 0;
							}
						}
					}
				}
			}

			arr_two_dimension = new int[lines, count_min];
			lines = 0;
			count = 0;
			int j = 0;
			for (int i = 0; i < arr_two_dimension.GetLength(0); i++ )
			{
				count = 0;
				
				while ( true )
				{
					if ( count < count_min )
					{
						if ( list_arr[j] != " ")
						{
							arr_two_dimension[i, count] = Convert.ToInt32(list_arr[j]);
							count++;
							j++;
						}
						else
						{
							j++;
						}
					}
					else
					{
						if ( i < arr_two_dimension.GetLength(0) - 1)
						{
							count = 0;
							while (list_arr[j] != "\n")
							{
								j++;
							}
							j++;
						}
						break;
					}
				}
			}

			return arr_two_dimension;
		}

		private int[][] Convert_To_Array_Inserted ()
		{
			int[][] arr_inserted;

			Start_Read(true,2);

			bool new_line = false;
			int lines = 0;
			

			for (int i = 1; i < list_arr.Count; i++)
			{
				if (list_arr[i] == "\n" && list_arr[i - 1] == "\n" || list_arr[i] == "-")
				{
					list_arr.RemoveAt(i);
				}
			}

			for (int i = 0; i < list_arr.Count; i++)
			{
				if (list_arr[i] == "\n")
				{
					lines++;
				}
			}

			arr_inserted = new int[lines][];
			int count = 0;
			lines = 0;

			foreach ( string s in list_arr)
			{
				if ( s != "\n" )
				{
					if ( s != " ")
					{
						count++;
					}
					
				}
				else
				{
					arr_inserted[lines] = new int[count];
					lines++;
					count = 0;
				}
			}

			lines = 0;
			count = 0;
			int j = 0;

			for (int i = 0; i < arr_inserted.GetLength(0); i++)
			{
				count = 0;

				while (true)
				{
					if (list_arr[j] != " " && list_arr[j] != "\n")
					{
						arr_inserted[i][count] = Convert.ToInt32(list_arr[j]);
						count++;
						j++;
					}
					else
					{
						j++;
					}
					
					if (count == arr_inserted[i].GetLength(0))
					{
						count = 0;
						while (list_arr[j] != "\n")
						{
							j++;
						}
						j++;
						break;
					}
				}
			}

			return arr_inserted;
		}

		static public void Array_Dimensional ()
		{

			Console.Clear();

			Console.WriteLine("\nНайти сумму положительных элементов на четных местах и сумму отрицательных элементов на нечетных местах. Определить, какая из них по модулю больше.\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();
			Array_Initialization _New_Array = new Array_Initialization();

			int[] arr_dimensional = _New_Array.Convert_To_Array_Dimensional();

			Console.WriteLine("\nВаш массив целых чисел:\n");
			foreach (int i in arr_dimensional)
			{
				Console.Write("<" + i + ">\t");
			}
			Console.WriteLine("\n\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();

			int positive_sum = 0, negative_sum = 0;

			Quest.Do_This(arr_dimensional, ref positive_sum, ref negative_sum);

			Console.WriteLine("\n\nСумма Положительных значений на чётных позициях:" + positive_sum + "\nСумма Отрицательных значений на нечётных позициях:" + negative_sum);
			if (positive_sum > Math.Abs(negative_sum))
			{
				Console.WriteLine("\n\nСумма положительных значений по модулю больше, чем сумма отрицательных.");
			}
			else
			{
				Console.WriteLine("\n\nСумма отрицательных значений по модулю больше, чем сумма положительных.");
			}
			Console.WriteLine("\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();
		}

		static public void Array_Two_Dimensional ()
		{
			Console.Clear();

			Console.WriteLine("\nОтсортировать элементы по периметру матрицы по возрастанию. Направление: слева направо, сверху вниз.\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();

			Array_Initialization _New_Array = new Array_Initialization();

			int[,] arr_two_dimensional = _New_Array.Convert_To_Array_Two_Dimensional();

			Console.WriteLine("\nВаш массив целых чисел:\n");
			for (int i = 0; i < arr_two_dimensional.GetLength(0); i++)
			{
				for (int j = 0; j < arr_two_dimensional.GetLength(1); j++)
				{
					Console.Write("<" + arr_two_dimensional[i, j] + ">\t");
				}
				Console.WriteLine("\n");
			}

			Console.WriteLine("\n\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();

			arr_two_dimensional = Quest.Do_This(arr_two_dimensional);

			Console.WriteLine("\nВаш массив целых чисел:\n");
			for (int i = 0; i < arr_two_dimensional.GetLength(0); i++)
			{
				for (int j = 0; j < arr_two_dimensional.GetLength(1); j++)
				{
					Console.Write("<" + arr_two_dimensional[i, j] + ">\t");
				}
				Console.WriteLine("\n");
			}

			Console.WriteLine("\n\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();
		}

		static public void Array_Inserted ()
		{
			Console.Clear();

			Console.WriteLine("\nНайти сумму положительных элементов на четных местах и сумму отрицательных элементов на нечетных местах.\nОпределить, какая из них по модулю больше в самой длинной строке.\n\nНажмите любую клавишу для продолжения");
			Console.ReadKey();

			Array_Initialization _New_Array = new Array_Initialization();

			int[][] arr_inserted = _New_Array.Convert_To_Array_Inserted();

			Console.WriteLine("\nВаш массив целых чисел:\n");
			for (int i = 0; i < arr_inserted.GetLength(0); i++)
			{
				for (int j = 0; j < arr_inserted[i].GetLength(0); j++)
				{
					Console.Write("<" + arr_inserted[i][j] + ">\t");
				}
				Console.WriteLine("\n");
			}

			Console.WriteLine("\n\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();

			int positive_sum = 0, negative_sum = 0;
			int max_s = 0;
			for (int i = 0; i < arr_inserted.GetLength(0); i++)
			{
				if (arr_inserted[i].GetLength(0) > arr_inserted[max_s].GetLength(0))
				{
					max_s = i;
				}
				
			}

			Quest.Do_This(arr_inserted[max_s], ref positive_sum, ref negative_sum);

			Console.WriteLine("\n\nСамая длинная строка:"+ max_s +"\n\nСумма Положительных значений на чётных позициях этой строки:" + positive_sum + "\nСумма Отрицательных значений на нечётных позициях этой строки:" + negative_sum);
			if (positive_sum > Math.Abs(negative_sum))
			{
				Console.WriteLine("\n\nСумма положительных значений по модулю больше, чем сумма отрицательных.");
			}
			else
			{
				Console.WriteLine("\n\nСумма отрицательных значений по модулю больше, чем сумма положительных.");
			}
			Console.WriteLine("\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();
		}
	}
}
