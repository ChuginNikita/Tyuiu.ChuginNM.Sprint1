using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChuginNM.Sprint1.Task0.V30.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            int a = 1;
            int b = 2;
            int c = 1;
            Assert.AreEqual(1, DataService.calcAnswer(a, b, c));
        }
    }
}
