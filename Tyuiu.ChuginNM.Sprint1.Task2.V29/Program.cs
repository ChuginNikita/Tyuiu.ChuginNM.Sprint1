using System;

using Tyuiu.ChuginNM.Sprint1.Task2.V29.Lib;

namespace Tyuiu.ChuginNM.Sprint1.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (x+y)/6 и печатает его на экране.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите время в секундах: ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ConvertSecondsToHours(x));
            Console.ReadKey();
        }
    }

}
