using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint2.Task0.V11.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 8105; int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Бахтияров Д. Р. | АСОиУб-23-3";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #2                                                               -");
            Console.WriteLine("- Тема: Операции сравнения                                                -");
            Console.WriteLine("- Задание #0                                                              -");
            Console.WriteLine("- Вариант #11                                                             -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Условие: Написать программу из операций сравнений                       -");
            Console.WriteLine("- (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)-");
            Console.WriteLine("- и арифметических выражений, которая вернет логическую                   -");
            Console.WriteLine("- последовательность(массив): (True, False, True, False, True, False)     -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Исходные данные:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- x = 8105, y = 275                                                       -");
            Console.WriteLine("---------------------------------------------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
