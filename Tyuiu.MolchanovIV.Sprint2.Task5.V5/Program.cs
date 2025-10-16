using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint2.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task5.V5
{
    class Program
    {
        static public void Main(string[] args)
        {
            DataService ds = new DataService();

            int k = 0;

            Console.Title = "Спринт #2 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Игральным картам условно присвоены следующие порядковые номера *");
            Console.WriteLine("* в зависимости от их достоинства: «валету» — 11, «даме» — 12,            *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14. Порядковые номера остальных карт            *");
            Console.WriteLine("* По заданному номеру карты k (6 <=k <= 14) определить                    *");
            Console.WriteLine("* достоинство соответствующей карты.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение K:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindCardValue(k));

            Console.ReadLine();

        }
    }
}