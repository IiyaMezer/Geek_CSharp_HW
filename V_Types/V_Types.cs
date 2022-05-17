using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace V_Types
{
    internal class V_Types
    {
        
        /// <summary>
        ///  Запрос крайних значений темпратуры и вывод среднего значения.
        /// </summary>
        static void Task01()
        {
           

             Console.Write("Введите максмальную погоду:");
            decimal maxtemp = decimal.Parse(Console.ReadLine());

            Console.Write("Введите минимальную погоду:");
            decimal mintemp = decimal.Parse(Console.ReadLine());

            decimal MidT = MidTempCalc(maxtemp, mintemp);
            Console.WriteLine($"Средняя темпаратура: {MidT}");
            Console.ReadKey("Press any key to continue");
          
        }  


        /// <summary>
        /// Звпрос номера месяца и вывод его названия.
        /// </summary>
        static void Task02()
        {
             Console.Write("Введите номер месяца:");
            int month = int.Parse(Console.ReadLine());
            string M_title = "";
            switch (month)
            {
                case 1: M_title = "Jan";
                    break;

                case 2: M_title = "Feb";
                    break;

                case 3: M_title = "Mar";
                    break;

                case 4: M_title = "Apr";
                    break;

                case 5: M_title = "May";
                    break;

                case 6: M_title = "Jun";
                    break;

                case 7: M_title = "Jul";
                    break;

                case 8: M_title = "Aug";
                    break;

                case 9: M_title = "Sep";
                    break;

                case 10: M_title = "Oct";
                    break;

                case 11: M_title = "Nov";
                    break;

                case 12: M_title = "Dec";
                    break;       
            }

           Console.WriteLine(M_title);
           Console.ReadKey("Press any key to continue");
        }


        /// <summary>
        /// Задача 3
        /// Запрос числа и проверка на четность
        /// </summary>
        static void Task03()
        {
            Console.WriteLine("Введите число: ");
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} четное.");
            }
            else
            {
                Console.WriteLine($"Число {number} нечетное.");
            }
            Console.ReadKey("Press any key to continue");
        }

       /// <summary>
       ///Вычисление среднего значения.
       /// </summary>
       /// <param name="maxtemp">Максимальная метпература</param>
       /// <param name="mintemp">Минимальная темпертура</param>
       /// <returns>Среднее значение</returns>
       static decimal MidTempCalc(decimal maxtemp, decimal mintemp)
        {
            return (maxtemp + mintemp) / 2;
        }

        static void Main (string[] args)
        {

            Console.WriteLine("Выдберите задачу:");
            Console.WriteLine("1 - Задача 1.");
            Console.WriteLine("2 - Задача 2.");
            Console.WriteLine("3 - Задача 3.");
            Console.WriteLine("4 - Задача 3.");
            Console.WriteLine("5 - Задача 5.");
            Console.WriteLine("6 - Задача 6.");
            Console.WriteLine("===================");
            int TaskNum = Convert.ToInt32(Console.ReadLine());
            switch (TaskNum)
            {
                case 1:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 1");
                    Console.WriteLine("========================");
                    Task01();
                    Console.WriteLine("========================");
                    break;

                 case 2:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 2");
                    Console.WriteLine("========================");
                    Task02();
                    Console.WriteLine("========================");
                    break;

                 case 0:
                    Console.WriteLine("========================");
                    Console.WriteLine("Звершение работы");
                    Console.WriteLine("========================");
                    Console.ReadKey();                    
                    return;

                case 3:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 3");
                    Console.WriteLine("========================");
                    Task02();
                    Console.WriteLine("========================");
                    break;

            }
                                            
        }                  
    }
}
