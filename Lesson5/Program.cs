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
        /// Добавл код для отображения файлов внутри папки.
        /// 
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="indent"></param>
        /// <param name="lastDirectory"></param>
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            Console.Write(lastDirectory ? "└─" : "├─");
            indent += lastDirectory ? " " : "│ ";
            Console.WriteLine(dir.Name);

            
            FileInfo[] subFiles = dir.GetFiles();
           
            
            bool lastfile = false;

            // добавленный код для отобрадения файлов.
                       
            //for (int j = 0; j < subFiles.Length; j++)
            //{
            //    lastfile = (j == subFiles.Length - 1);

            //    Console.Write(indent);
            //    Console.Write(lastfile ? "└─" : "├─");
            //    Console.WriteLine(subFiles[j].Name);                

            //}

            DirectoryInfo[] subDirs = dir.GetDirectories();
            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1);

                
            }
            for(int j = 0; j < subFiles.Length; j++)
            {
                lastfile = (j == subFiles.Length - 1);

                Console.Write(indent);
                Console.Write(lastfile ? "└─" : "├─");
                indent += lastfile ? " " : "│ ";
                Console.WriteLine(subFiles[j].Name);

            }


        }

            /// <summary>
            /// Задание 1
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
        
        
        /// <summary>
        /// Задина 4 неполностью. Ввиду нехватки времени, я смог разобраться только с рекурсивным способом,который был показан на лекции, но 
        /// думаю, что код для отображения файлов можно считать за реализацию способа через циклы, так как с папками он будет аналогичен.
        /// Также я не успел реализовать вывод дерева в файл.
        /// </summary>
        static void Task04()
        {
                

                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\carna\Desktop\ЧПУ");

                Console.WriteLine("FullName: {0}", directoryInfo.FullName);
                Console.WriteLine("Name: {0}", directoryInfo.Name);
                Console.WriteLine("Parent: {0}", directoryInfo.Parent);
                Console.WriteLine("Creation: {0}", directoryInfo.CreationTime);
                Console.WriteLine("Attributes: {0}", directoryInfo.Attributes.ToString());
                Console.WriteLine("Root: {0}", directoryInfo.Root);

                Console.WriteLine();

                PrintDir(new DirectoryInfo(@"C:\Users\carna\Desktop\ЧПУ"), "", true);



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
                Console.WriteLine("4 - Задача 4. Дерево.");
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

                    case 4:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 4 Дерево");
                        Console.WriteLine("========================");
                        Task04();
                        Console.WriteLine("========================");
                        break;



                }
            }
        }
    }
}
