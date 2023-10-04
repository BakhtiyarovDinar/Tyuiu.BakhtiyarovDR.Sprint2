using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
// и арифметических выражений, которая вернет логическую последовательность(массив):
// (True, False, True, False, True, False), при x = 8105, y = 275

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] array = new bool[6];

            array[0] = x == y + 7830;
            array[1] = x != y + 7830;
            array[2] = x < y + 8000;
            array[3] = x > y + 8000;
            array[4] = x <= y + 8000;
            array[5] = x >= y + 8000;

            return array;
        }
    }
}
