using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
   
    internal class Program
    {
        static void Task01(int X, int Y)
        {

            char[,] Matrix = new char[Y, X];
            int dx = Matrix.GetLength(1);
            int dy = Matrix.GetLength(0);
            int err = 0;
            int y = 0;
            int derr = dy;
            int Ystep = (0 < dy) ? 1 : -1; // напралвление диагонали 1 - вправо-вниз, -1 врпаво вверх.
                                           // Можно было просто присвоить значение 1, в нашем случае.

            for (int i = 0; i < dx; i++)
            {
                Matrix[y, i] = '*';
                Console.Write($"{Matrix[y, i]} ");
                err += derr; //накопление ошибки

                if (err >= dx) // условие перехода на следующую строку
                {
                    y += Ystep;
                    err -= dx; // сброс ошибки

                    Console.WriteLine();
                    for (int x = 0; x < (i + 1); x++) // переХод на следующую строку с добавлением нужного количества отступов
                    {
                        Console.Write("  "); //два пробела по двум причинам: 1) иначе, поледующая строка заезжает на предущую.
                                             //2) я не нашел способа сделать это более грамотно.
                    }

                }

            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива:");
            int x = int.Parse(Console.ReadLine());

           
            Console.Write("Введите высоту массива меньшую длине:");
            int y = int.Parse(Console.ReadLine());

            Task01(x, y);

        }
    }
}
