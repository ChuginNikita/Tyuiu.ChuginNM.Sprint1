using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChuginNM.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            int y = value.Count(x => x == value[0]);
            return y > 1;
        }
    }
}
