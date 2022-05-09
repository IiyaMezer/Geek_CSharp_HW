using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Types
{
    internal class V_Types
    {
        static void Main (string[] args)
        {
            Console.Write("Введите максмальную погоду:");
            decimal maxtemp = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите минимальную погоду:");
            decimal mintemp = Convert.ToDecimal(Console.ReadLine());

            decimal midtemp = (maxtemp + mintemp) / 2;


            Console.WriteLine($"Средняя температура: {midtemp} ");

            Console.Write("Введите номер месяца:");
            int month = Convert.ToInt32(Console.ReadLine());
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

           Console.WriteLine("Press ENTER to finish programm");
           Console.ReadLine();
            
        }                  
    }
}
