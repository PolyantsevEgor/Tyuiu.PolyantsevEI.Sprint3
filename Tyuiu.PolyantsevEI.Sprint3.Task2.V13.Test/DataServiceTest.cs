using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint3.Task2.V13.Lib;

namespace Tyuiu.PolyantsevEI.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2.105, ds.GetSumSeries(0.7, 1, 10));
        }
    }
}
