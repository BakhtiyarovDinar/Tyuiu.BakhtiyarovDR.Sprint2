using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint2.Task4.V9.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #2                                                                            -");
            Console.WriteLine("- Тема: Операции сравнения                                                             -");
            Console.WriteLine("- Задание #4                                                                           -");
            Console.WriteLine("- Вариант #9                                                                           -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3                                   -");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                             -");
            Console.WriteLine("- Написать программу, которая вычисляет требуемое значение с помощью тернарного        -");
            Console.WriteLine("- оператра, где польхователь вводит x и y                                              -");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                                     -");
            Console.WriteLine("----------------------------------------------------------------------------------------");


            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());






            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                                           -");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            double z = ds.Calculate(x, y);
            Console.WriteLine(z);


            Console.ReadLine();
        }
    }
}
