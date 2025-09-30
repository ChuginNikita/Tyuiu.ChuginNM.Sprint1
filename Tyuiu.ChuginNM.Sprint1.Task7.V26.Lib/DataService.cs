using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChuginNM.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double var1 = (Math.Pow(Math.Sin(x), 2) + y)/(y + 1);
            double var2 = (x * y - 12) / (34 + Math.Pow(x, 2));

            return Math.Round(var1 + var2, 3);
        }
    }
}
