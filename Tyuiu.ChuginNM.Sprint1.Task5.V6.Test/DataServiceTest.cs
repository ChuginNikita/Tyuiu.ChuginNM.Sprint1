using Tyuiu.ChuginNM.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 10;

            Assert.AreEqual(3, ds.Calculate(x));

        }
    }
}
