using Tyuiu.ChuginNM.Sprint1.Task4.V14.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6, y = 7;
            Assert.AreEqual(0.003, Math.Round(ds.Calculate(x,y),3));
        }
    }
}
