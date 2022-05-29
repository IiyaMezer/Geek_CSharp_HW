using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    internal class Program
    {
        /// <summary>
        /// Залание 1
        /// </summary>
        static void Task01()
        {
            Console.WriteLine("Введите произвольный текст: ");
            string str = Console.ReadLine();

            Console.WriteLine("Введите имя файла: ");
            string filename = Console.ReadLine();
            string format = ".txt";

            File.WriteAllText((filename+format), str);

            Console.ReadKey(true);
    
        }

        /// <summary>
        /// Дата и время в текстовый файл
        /// </summary>
        static void Task02()
        {
            string filename = "startup.txt"; //имя файла
            DateTime start = DateTime.Now; // переменная для даты

            string startuptime = "File creation time: " + start.ToString("T"); // строка для сохранения  в форматированием переменной времени по типц "hh:мм:ss"
           
            File.WriteAllText(filename, startuptime); //сохранение строки в файл

            Console.ReadKey(true);
        }
        /// <summary>
        /// Запись набора чисел в бинарный файл
        /// </summary>
        static void Task03()
        {
            Console.Write("Ввеедите числа (0...255) через пробел для вычисления их суммы :");
            string preSplit = Console.ReadLine(); // запрос на ввод набора чисел
            byte [] bytearr = preSplit.Split().Select(byte.Parse).ToArray(); // создание ,массива байтов
            File.WriteAllBytes(@"byte.bin", bytearr);

             
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("0 - Завершение работы.");
                Console.WriteLine("1 - Задача 1. Запись содержимого троки в файл");
                Console.WriteLine("2 - Задача 2. Запись времени в файл startup.txt.");
                Console.WriteLine("3 - Задача 3. Сохранение числа в бинарный файл");
                Console.WriteLine("4 - Задача 3.  Строка наоборот.");
                Console.WriteLine("==================================================");
                int TaskNum = Convert.ToInt32(Console.ReadLine());
                switch (TaskNum)
                {
                    case 1:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 1 Содержимое троки в файл");
                        Console.WriteLine("========================");
                        Task01();
                        Console.WriteLine("========================");
                        break;

                    case 2:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 2 Запись времени в файл startup.txt");
                        Console.WriteLine("========================");
                        Task02();
                        Console.WriteLine("========================");
                        break;

                    case 0:
                        f = false;
                        Console.WriteLine("========================");
                        Console.WriteLine("Звершение работы");
                        Console.WriteLine("========================");
                        Console.ReadKey();
                        break;



                    case 3:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 3 Байтовый файл");
                        Console.WriteLine("========================");
                        Task03();
                        Console.WriteLine("========================");
                        break;

                        //case 4:
                        //    Console.WriteLine("========================");
                        //    Console.WriteLine("Задача 3 Строка наоборот");
                        //    Console.WriteLine("========================");
                        //    Task03();
                        //    Console.WriteLine("========================");
                        //    break;

                }
            }
        }
    }
}
