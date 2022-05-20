﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyc_arr_str
{
    internal class Cyc_arr_str
    {

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

        static void Task01()
        {

            char[,] Matrix = new char[22, 6];

            int X0 = 0;
            int Y0 = 0;

            int X1 = Matrix.GetLength(0);
            int Y1 = Matrix.GetLength(1);

            decimal ERR = 0;    
            decimal dErr = (Y1+1)/(X1+1);
            int y = Y0;
            int diry = Y1;




            for (int i = 0; i < Matrix.GetLength(0); i++)//перебор элементов массива
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
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1 - Задача 1. Для квадранного массива");
            Console.WriteLine("2 - Задача 1 С применением алгоритма Брезенхема(гугл помог_) in process.");
            Console.WriteLine("3 - Задача 3.");
            Console.WriteLine("4 - Задача 4.");
            Console.WriteLine("===================");
            int TaskNum = Convert.ToInt32(Console.ReadLine());
            switch (TaskNum)
            {
                case 1:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 1");
                    Console.WriteLine("========================");
                    Task011();
                    Console.WriteLine("========================");
                    break;

                case 2:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 1");
                    Console.WriteLine("========================");
                    Task01();
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
                    Task03();
                    Console.WriteLine("========================");
                    break;

                case 4:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 4");
                    Console.WriteLine("========================");
                    Task04();
                    Console.WriteLine("========================");
                    break;





                    Console.ReadKey();
        }
    }
}
