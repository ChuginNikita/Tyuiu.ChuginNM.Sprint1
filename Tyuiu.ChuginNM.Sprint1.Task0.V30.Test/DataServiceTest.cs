using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChuginNM.Sprint1.Task0.V30.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validationCheck()
        {
            Assert.AreEqual(20, DataService.calcAnswer(5, 5, 5));
        }
    }
}
