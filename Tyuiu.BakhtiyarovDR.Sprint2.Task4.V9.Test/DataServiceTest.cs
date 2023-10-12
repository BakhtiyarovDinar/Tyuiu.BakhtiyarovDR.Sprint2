using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint2.Task4.V9.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            Assert.AreEqual(0.25, ds.Calculate(x, y));
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            Assert.AreEqual(-0.5, ds.Calculate(x, y));
        }
    }
}
