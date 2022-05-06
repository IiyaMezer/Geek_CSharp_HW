using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Types
{
    internal class V_Types
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максмальную погоду:");
            decimal maxtemp = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите минимальную погоду:");
            decimal mintemp = Convert.ToDecimal(Console.ReadLine());

            decimal midtemp = (maxtemp + mintemp) / 2;


            Console.WriteLine($"Средняя температура: {midtemp} ");

            Console.WriteLine("Press ENTER to finish programm");
            Console.ReadLine();
        }
    }
}
