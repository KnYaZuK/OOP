/*
 * Создать параметризованный класс, содержащий три закрытых поля-массива (одномерный, двумерный и вложенный). Параметр – тип данных ваших массивов.
 * 
 * Для каждого массива описать по индексатору и осуществить вывод данных следующим образом: 
 * для первого массива – через индексатор в основной программе, 
 * для второго (двумерного) и третьего (вложенного) – через цикл foreach в отдельном методе, который через переданный ему параметр определяет, с каким массивом ему нужно работать.
 * 
 * Требования к количеству элементов массива: Пользователь задает число. Сумма цифр их факториала этого числа. Предусмотреть ограничение, что размер массива не больше 20 элементов.
 * т.е. Факториал числа, где вместо умножения стоит сумма.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboratory_Work_3
{
	class Array_T<T>
	{
		T[] one_dimensional;
		T[,] two_dimensional;
		T[][] inserted;

		public Array_T(int _i, int _j)
		{
			one_dimensional = new T[_j];
			two_dimensional = new T[_i, _j];
			inserted = new T[_i][];

			for ( int i = 0; i < _i; i++)
			{
				inserted[i] = new T[_j];
			}

			if ( one_dimensional is int)
			{

			}
		}

		private void Fill_Int( int left, int right )
		{
			if (one_dimensional is int )
			{
				Random rnd = new Random();

				for (int i = 0; i < one_dimensional.GetLength(0); i++)
				{
					one_dimensional as int //  rnd.Next(left, right + 1);

					for (int j = 0; j < two_dimensional.GetLength(1); j++)
					{

					}
				}
			}
			
		}

		public T this[int i]
		{
			get { return one_dimensional[i]; }
			set { one_dimensional[i] = value; }
		}

		public void Print ( T[,] _two_dimensional )
		{

		}

		public void Print ( T[][] _inserted )
		{

		}

		

		
	}
}
