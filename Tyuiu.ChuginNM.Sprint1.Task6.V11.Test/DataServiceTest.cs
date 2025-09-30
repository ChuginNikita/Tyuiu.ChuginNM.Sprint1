using Tyuiu.ChuginNM.Sprint1.Task6.V11.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "абоба";
            Assert.IsTrue(ds.CheckeFirstLetterRepetition(x));
        }
    }
}
