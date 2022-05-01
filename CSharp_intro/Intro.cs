using System;

namespace CSharp_intro
{
    internal class Intro
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string Name = Console.ReadLine();
            DateTime currDate = DateTime.Now;
            
            Console.WriteLine($"Здравствуйте, {Name}, сегодня {currDate:d} ");

            Console.WriteLine("Press ENTER to finish programm");
            Console.ReadLine();
        }
    }
}
