using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChuginNM.Sprint1.Task0.V30.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
        }
    }
}
