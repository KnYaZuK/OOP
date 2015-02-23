﻿/*
 * Разработать приложение WindowsForms. 
 * 
 * Создать параметризованный класс, содержащий три закрытых поля-массива (одномерный, двумерный и вложенный). Параметр – тип данных ваших массивов. 
 * 
 * Для каждого массива описать по индексатору и осуществить вывод данных следующим образом: 
 * для первого массива – через индексатор в основной программе, 
 * для второго (двумерного) и третьего (вложенного) – через цикл foreach в отдельном методе, который через переданный ему параметр определяет, с каким массивом ему нужно работать. 
 * 
 * В зависимости от выбора пользователя (через RadioButton) создавать объект класса с параметром: int или string. 
 * 
 * Заполнить массивы случайным образом с учетом требований к заполнению по варианту (см.ниже таблица 2). 
 * 
 * В классе определить метод, выводящий на экран сумму элементов каждого из трех массивов, но не всех сразу: один вызов метода – одна сумма. 
 * 
 * В основной программе для каждого массива организовать вывод его самого и результат работы метода, считающего его сумму.
 * 
 * 
 * 
 * Требования к количеству элементов массива: Пользователь задает число. Сумма цифр их факториала этого числа. Предусмотреть ограничение, что размер массива не больше 20 элементов.
 * 
 * Требования к числовой информации: Границы диапазона задает пользователь.
 * 
 * Требования к строковой информации: Определить строку содержащую символы латиницы и цифры. Для каждого элемента массива случайным образом «дергать» оттуда символы.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laboratory_Work_3
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}