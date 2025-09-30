using Tyuiu.ChuginNM.Sprint1.Task6.V11.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task6.V11
{

    public class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что           *");
            Console.WriteLine("* первая буква строки входит в нее еще раз.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            Console.WriteLine(ds.CheckeFirstLetterRepetition(input));
            Console.ReadKey();

        }
    }
}