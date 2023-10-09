using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint2.Task3.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task3.V5
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
            Console.WriteLine("- Задание #3                                                                           -");
            Console.WriteLine("- Вариант #5                                                                           -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                                     -");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                             -");
            Console.WriteLine("- Написать программу, которая вычисляет требуемое значение функции Y с использованием  -");
            Console.WriteLine("- вложенных оператор if-else где пользователь вводит значение переменной X с клавиатуры-");
            Console.WriteLine("- Округлить полученное значение до трех знаков после запятой                           -");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                                     -");
            Console.WriteLine("----------------------------------------------------------------------------------------");


            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());






            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                                           -");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            double y = ds.Calculate(x);
            Console.WriteLine(y);


            Console.ReadLine();
        }
    }
}
