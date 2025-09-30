using Tyuiu.ChuginNM.Sprint1.Task7.V26.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2, y = 4;
            Assert.AreEqual(0.754, ds.Calculate(x, y));

        }
    }
}
