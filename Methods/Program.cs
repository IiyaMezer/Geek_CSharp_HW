﻿using System;
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

        /// <summary>
        /// Метод для вычисления суммы 
        /// </summary>
        /// <param name="sum"> изначальное значение суммы ряда </param>
        /// <param name="array"> входной массив  </param>
        /// <returns> сумма ряда </returns>
        static int ArraySum(int[] array )
        {
            int sum = 0;

             foreach (int i in array)
            {
                sum += array[i-1];                
            }
             return sum;
        }
        
        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
                      
        }

        static void SeasonPrint(int Month)
        {
            
            switch (Month)
            {
                case 1: case 2: case 12:
                    Console.WriteLine ("Этот месяц из сезона: {0}",Seasons.Winter);
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine ("Этот месяц из сезона: {0}",Seasons.Spring);
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine ("Этот месяц из сезона: {0}",Seasons.Summer);
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine ("Этот месяц из сезона: {0}",Seasons.Autumn);
                    break;
                            
            }
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
                            
                
        /// <summary>
        /// Сумма чисел, введенных через пробел.
        /// </summary>
        static void Task02()
        {
            //int sum = 0;
            Console.Write("Ввеедите числа через пробел для вычисления их суммы :");
            string preSplit = Console.ReadLine();
            int [] splitted = preSplit.Split().Select(int.Parse).ToArray();  //Select и ToArray вычитал из оф документации на сайте Microsoft.
            //foreach (int i in splitted)
            //{
            //     sum += splitted[i-1];                
            // }
            // закомментил после добавления метода с аналогичной задачей.

            Console.WriteLine("Сумма ряда: {0}", ArraySum(splitted));
            Console.ReadKey();
        }

        
        static void Task03()
        {
           bool f = true;

            while (f)
            {
                Console.Write("Введите номер месяца: ");
                int Month = int.Parse(Console.ReadLine());
                
                
                if((Month>=1) & (Month<=12)) //лучшее, что я смог придумать
                {
                    
                    SeasonPrint(Month);
                    f = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректый нормер месяца, повторите ввод.");
                }
            }
                        

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
                Console.WriteLine("3 - Задача 3 Время года по месяцу");
                Console.WriteLine("4 - Задача 3  Строка наоборот.");
                Console.WriteLine("==================================================");
                int TaskNum = Convert.ToInt32(Console.ReadLine());
                switch (TaskNum)
                {
                    case 1:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 1 GetFullName");
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

                    case 0:
                        f = false;
                        Console.WriteLine("========================");
                        Console.WriteLine("Звершение работы");
                        Console.WriteLine("========================");
                        Console.ReadKey();
                        break;



                    case 3:
                       Console.WriteLine("========================");
                       Console.WriteLine("Задача 3 Время года по месяцу");
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
