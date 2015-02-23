/*
 * Создать параметризованный класс, содержащий три закрытых поля-массива (одномерный, двумерный и вложенный). Параметр – тип данных ваших массивов.
 * 
 * Для каждого массива описать по индексатору и осуществить вывод данных следующим образом: 
 * для первого массива – через индексатор в основной программе, 
 * для второго (двумерного) и третьего (вложенного) – через цикл foreach в отдельном методе, который через переданный ему параметр определяет, с каким массивом ему нужно работать.
 * 
 * Требования к количеству элементов массива: Пользователь задает число. Сумма цифр их факториала этого числа. Предусмотреть ограничение, что размер массива не больше 20 элементов.
 * т.е. Факториал числа, где вместо умножения стоит сумма.
 * 
 * В классе храним сами массивы и индексатор. Заполнение массивов и вывод прямоугольного с вложенным осуществляем в основной программе WinForm
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
		public T[] one_dimensional { get; set; }
		public T[,] two_dimensional { get; set; }
		public T[][] inserted { get; set; }

		public Array_T(int _i, int _j) 
		{
			one_dimensional = new T[_i];
			two_dimensional = new T[_i, _j];
			inserted = new T[_i][];

			for ( int i = 0; i < _i; i++)
			{
				inserted[i] = new T[_j];
			}
		}

		public T this[int i]
		{
			get { return one_dimensional[i]; }
			set { one_dimensional[i] = value; }
		}
	}
}
