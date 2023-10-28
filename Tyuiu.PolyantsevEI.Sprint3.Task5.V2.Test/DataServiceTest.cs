using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint3.Task5.V2.Lib;

namespace Tyuiu.PolyantsevEI.Sprint3.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            Assert.AreEqual(35.658, ds.GetSumSumSeries(5, 1, 1, 3, 12));
        }
    }
}
