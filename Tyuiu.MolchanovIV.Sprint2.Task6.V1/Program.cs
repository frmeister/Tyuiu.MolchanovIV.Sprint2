using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint2.Task6.V1.Lib;

namespace Tyuiu.MolchanovIV.Sprint2.Task6.V1
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: По данному номеру месяца, определите                           *");
            Console.WriteLine("* количество дней в этом месяце.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение K:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindMonthDaysCount(k));

            Console.ReadLine();

        }
    }
}