/* Вариант - 17
 * Одномерный массив - Найти сумму положительных элементов на четных местах и сумму отрицательных элементов на нечетных местах. Определить, какая из них по модулю больше.
 * Двумерный массив - Отсортировать элементы по периметру матрицы по возрастанию. Направление: слева направо, сверху вниз. 
 * Вложенный массив - Найти сумму положительных элементов на четных местах и сумму отрицательных элементов на нечетных местах. Определить, какая из них по модулю больше в самой длинной строке.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2
{
	class Program
	{
		static void Main( )
		{
			Console.CursorVisible = false;

			Menu menu = new Menu();
			Array_Initialization array = new Array_Initialization();

			Console.WriteLine("\nЛабораторная работа № 2 Кобякина Дениса Михайловича.\n\nВариант - 17\n\nЗадание - Сделать консольное приложение с указанными требованиями.\n\nНажмите любую клавишу для продолжения...");
			Console.ReadKey();

			menu.New_Menu_Point("Вложенный массив", Array_Initialization.Array_Inserted);
			menu.New_Menu_Point("Двумерный Массив", Array_Initialization.Array_Two_Dimensional);
			menu.New_Menu_Point("Одномерный Массив", Array_Initialization.Array_Dimensional);

			menu.Start_Menu();
		}

		
	}
}
