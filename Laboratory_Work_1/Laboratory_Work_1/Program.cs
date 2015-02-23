/*
 * Вариант № 17, Шарлотка с яблоками
 * 
 * Объекты:
 * + 1 - Духовка - Включить\Выключить\Мощность нагрева
 * + 2 - Противень - Смазать
 * + 3 - Нож - Резать\Разбить
 * + 4 - Яблоки - Чистые\Грязные
 * + 5 - Яйца - Разбить
 *    + - Белки и желтки - Разделить
 *      + - Белки - Взбитые
 *      + - Желтки
 * + 6 - Венчик - Взбивать Белки
 * + 7 - Сахар
 * + 8 - Сода
 * + 9 - Мука
 * + 10 - Масло
 * + 11 - Кран - Открыть\Закрыть\Помыть
 *  11 - Шарлотка, Готовка\Приготовлено - состояние ( если печ была включена )
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1

{
	class Program
	{
		static void Main()
		{
			Charlotte charlotte = new Charlotte();
			charlotte.cook();
		}
	}
}
