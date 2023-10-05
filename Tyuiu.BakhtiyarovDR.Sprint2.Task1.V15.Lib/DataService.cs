using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.BakhtiyarovDR.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool res1, res2, res3, res4, res5, res6;

            res1 = (a + 202 > b) | (c - 8 < d);   
            res2 = (a + 2 > b) & (c < d);    
            res3 = (a > b) || (c < d);    
            res4 = (a + 2 > b) && (c < d);   
            res5 = !(res1);   
            res6 = (b > a) ^ (c < d);  

            bool[] array = new bool[] { res1, res2, res3, res4, res5, res6 };

            return array;
        }
    }
}
