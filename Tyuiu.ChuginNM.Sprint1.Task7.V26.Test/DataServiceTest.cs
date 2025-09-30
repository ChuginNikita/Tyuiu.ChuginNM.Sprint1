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
            double x = 6, y = 7;
            Assert.AreEqual(1.313, ds.Calculate(x, y));

        }
    }
}
