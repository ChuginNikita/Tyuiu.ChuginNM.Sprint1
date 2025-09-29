using Tyuiu.ChuginNM.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 150;
            Assert.AreEqual(2.5, ds.ConvertMinutesToHours(x));
        }
    }
}
