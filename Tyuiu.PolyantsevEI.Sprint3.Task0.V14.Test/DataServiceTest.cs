using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint3.Task0.V14.Lib;

namespace Tyuiu.PolyantsevEI.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            Assert.AreEqual(14400, ds.GetMultiplySeries(2, 1, 5));
            Assert.AreEqual(1728000, ds.GetMultiplySeries(3, 1, 5));
        }
    }
}
