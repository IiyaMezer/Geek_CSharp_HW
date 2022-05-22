using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyc_arr_str
{
    internal class Cyc_arr_str
    {       
        /// <summary>
        /// Задание 1 диагональ массива
        /// Основная диагональ матрицы
        /// </summary>
        static void Task011()
        {

            char[,] Matrix = new char[6, 6];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Matrix[i, j] = '*';
                    }
                    else
                    {
                        Matrix[i, j] = '-';
                    }
                    Console.Write($"{Matrix[i, j]} ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Задание 1 с применением алгоритма Брезенхэма, для "пиксельной" диагонали прямоугольника.
        /// Под конец написания кода, я задумался о целесообразности использования вдумерного массива.
        /// </summary>
        static void Task01()
        {

            char[,] Matrix = new char[8,30];
            int dx = Matrix.GetLength(1);
            int dy = Matrix.GetLength(0);
            int err = 0;
            int y = 0;
            int derr = dy ;
            int Ystep = (0 < dy) ? 1 : -1; // напралвление диагонали 1 - вправо-вниз, -1 врпаво вверх.
                                           // Можно было просто присвоить значение 1, в нашем случае.

            for (int i = 0; i < dx; i++)
            {
                Matrix[y, i] = '*';
                Console.Write($"{Matrix[y, i]} ");
                err += derr; //накопление ошибки

                if(err >= dx) // условие перехода на следующую строку
                {
                    y+= Ystep;
                    err -= dx; // сброс ошибки

                    Console.WriteLine();
                    for (int x = 0; x< (i+1); x++) // переХод на следующую строку с добавлением нужного количества отступов
                    {
                        Console.Write("  "); //два пробела по двум причинам: 1) иначе, поледующая строка заезжает на предущую.
                                             //2) я не нашел способа сделать это более грамотно.
                    }
                    
                }
                                                
            }
            
                Console.ReadKey();
        }


        /// <summary>
        /// Задание 2 список контактов
        /// На что хватило фантазии и времени.
        /// </summary>
        static void Task02()
        {

            string[,] Matrix = new string[5, 2];

            for (int i = 0; i < Matrix.GetLength(0); i++)   // запись контактов
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Введите имя контакта: ");
                        string name = Console.ReadLine();
                        Matrix[i, j] = $"Name {i+1} : {name}";
                    }
                    else
                    {
                        Console.Write("Введите Email контакта: ");
                        string mail = Console.ReadLine();
                        Matrix[i, j] = $"Mail {i+1} : {mail}";
                    }
                    
                }
                Console.WriteLine();


            }
            for (int i = 0; i < Matrix.GetLength(0); i++) //вывод на экран списка контактов
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]} ");

                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Задание 3 
        /// Строка наоборот
        /// </summary>
        static void Task03()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            for(int i = text.Length; i > 0; i--)
            {
                Console.Write(text[i-1]);
            }
            Console.ReadKey();
                       
        }


        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("0 - Завершение работы.");
                Console.WriteLine("1 - Задача 1. Для квадранного массива");
                Console.WriteLine("2 - Задача 1 С применением алгоритма Брезенхэма.");
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
                        Task011();
                        Console.WriteLine("========================");
                        break;

                    case 2:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 1 Диагональ но сложнее");
                        Console.WriteLine("========================");
                        Task01();
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
                        Console.WriteLine("Задача 2 Справочник");
                        Console.WriteLine("========================");
                        Task02();
                        Console.WriteLine("========================");
                        break;

                    case 4:
                        Console.WriteLine("========================");
                        Console.WriteLine("Задача 3 Строка наоборот");
                        Console.WriteLine("========================");
                        Task03();
                        Console.WriteLine("========================");
                        break;

                }
            }
        }
    }
}
