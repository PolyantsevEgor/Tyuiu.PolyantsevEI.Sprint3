using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint3.Task1.V24.Lib;

namespace Tyuiu.PolyantsevEI.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.186, ds.GetSumSeries(5, 1, 12));
        }
    }
}
