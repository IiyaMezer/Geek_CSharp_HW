using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
       /// <summary>
       /// Метод к Task01
       /// </summary>
       /// <param name="firstName"> Имя </param>
       /// <param name="lastName"> Фамилия </param>
       /// <param name="patronymic"> Отчество </param>
       /// <returns> ФИО </returns>
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }

        static void Task01()
        {
            string Name1 = "Иван",
                   Name2 = "Петр",
                   Name3 = "Сидр",

                   FName1 = "Иванов",
                   FName2 = "Петров",
                   FName3 = "Сидоров",

                   patr1 = "Иванович",
                   patr2 = "Сидорович",
                   patr3 = "Петрович";

            Console.WriteLine( GetFullName(Name1, FName1, patr1));
            Console.WriteLine( GetFullName(Name2, FName2, patr2));
            Console.WriteLine( GetFullName(Name3, FName3, patr3));
           
            
        }

        static void Task02()
        {
            Console.Write("Ввеедите числа для вычисления их суммы через пробел:");
            //Console.WriteLine(Console.ReadLine().Split( ).Select(int.Parse).Sum());
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("0 - Завершение работы.");
                Console.WriteLine("1 - Задача 1. GetFullName");
                Console.WriteLine("2 - Задача 2 Сумма строки.");
                Console.WriteLine("3 - Задача 2. Телефонный справочник");
                Console.WriteLine("4 - Задача 3  Строка наоборот.");
                Console.WriteLine("==================================================");
                int TaskNum = Convert.ToInt32(Console.ReadLine());
                switch (TaskNum)
                {
                    case 1:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 1 Диагональ");
                        Console.WriteLine("========================");
                        Task01();
                        Console.WriteLine("========================");
                        break;

                    case 2:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 2 Сумма строки");
                        Console.WriteLine("========================");
                        Task02();
                        Console.WriteLine("========================");
                        break;

                    //case 0:
                    //    f = false;
                    //    Console.WriteLine("========================");
                    //    Console.WriteLine("Звершение работы");
                    //    Console.WriteLine("========================");
                    //    Console.ReadKey();
                    //    break;



                    //case 3:
                    //    Console.WriteLine("========================");
                    //    Console.WriteLine("Задача 2 Справочник");
                    //    Console.WriteLine("========================");
                    //    Task02();
                    //    Console.WriteLine("========================");
                    //    break;

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
