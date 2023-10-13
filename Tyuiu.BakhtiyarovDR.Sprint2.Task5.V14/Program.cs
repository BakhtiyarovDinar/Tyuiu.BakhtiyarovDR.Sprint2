﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint2.Task5.V14.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value;

            Console.Title = "Спринт #2 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #2" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Получение результатов из Switch                                   *");
            Console.WriteLine("* Задание #5" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 14" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя данные, вычисляет *");
            Console.WriteLine("* их и печатает их на экран.                                              *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите количевство дней");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Результат:" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine(ds.FindDayName(value));
            Console.ReadKey();
        }
    }
}
