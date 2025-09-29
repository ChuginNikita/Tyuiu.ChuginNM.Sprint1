using Tyuiu.ChuginNM.Sprint1.Task2.V29.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3600;
            Assert.AreEqual(60, ds.ConvertSecondsToHours(x));
        }
    }
}
