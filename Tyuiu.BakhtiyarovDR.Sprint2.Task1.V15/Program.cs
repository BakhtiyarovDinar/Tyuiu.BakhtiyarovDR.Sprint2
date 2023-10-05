using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint2.Task1.V15.Lib;

// a=415
// b=616
// c=134
// d=127

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a, b, c, d;
            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d: ");
            d = Convert.ToInt32(Console.ReadLine());

            bool[] array = new bool[] { };
            array = ds.GetLogicOperations(a, b, c, d);

            foreach (bool i in array)
            {
                Console.Write(i + " ");
            }


            Console.ReadKey();
        }
    }
}
