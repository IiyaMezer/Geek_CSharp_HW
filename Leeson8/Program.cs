using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Enter login: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("===========================================");

            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.BirthDate))
            {
                Console.Write("Enter date of birth: ");
                Properties.Settings.Default.BirthDate = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("===========================================");
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.Job))
            {
                Console.Write("Enter your Job : ");
                Properties.Settings.Default.Job = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("===========================================");
            }
            string greeting = Properties.Settings.Default.Helloword + Properties.Settings.Default.UserName;
            string date = "Your birth date: " + Properties.Settings.Default.BirthDate ;
            string Job = "Yout job is " + Properties.Settings.Default.Job;

            Console.WriteLine(greeting);
            Console.WriteLine(date);
            Console.WriteLine(Job);
            

            Console.ReadKey();
        }
    }
}
