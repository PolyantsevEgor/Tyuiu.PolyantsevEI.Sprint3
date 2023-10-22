using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint3.Task3.V21.Lib;

namespace Tyuiu.PolyantsevEI.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("fegeht gej eekge", ds.ReplaceNumOnChar("f3g5ht g4j 34kg4", 'e'));
        }
    }
}
