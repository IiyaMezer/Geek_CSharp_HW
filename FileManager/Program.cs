using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Utils;

namespace FileManager
{
    internal class Program
    {
        const int WINDOW_HEIGHT = 30;
        const int WINDOW_WIDTH = 120;
        private static string currDir = Directory.GetCurrentDirectory();



        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Title = "File_Manager";

            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            DrawWindow(0, 0, WINDOW_WIDTH, 18);
            DrawWindow(0, 18, WINDOW_WIDTH, 8);
            UpdateConsole();


            Console.ReadLine();
            
        }
        /// <summary>
        /// Get Current cursor position
        /// </summary>
        /// <returns></returns>
        static (int left, int top) GetCursorPos()
        {
            return (Console.CursorLeft, Console.CursorTop);
        }


        /// <summary>
        /// Обработка процесса ввода данных с консоли
        /// </summary>
        /// <param name="width"> Длина строки ввода </param>
        static void ProcEnterComm(int width)
        {
            (int left, int top) = GetCursorPos();
            StringBuilder command = new StringBuilder();
            ConsoleKeyInfo keyInfo;
            char key;

            do
            {
                keyInfo = Console.ReadKey();
                key = keyInfo.KeyChar;

                if (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Backspace &&
                    keyInfo.Key != ConsoleKey.UpArrow)
                    command.Append(key);

                (int currentLeft, int currentTop) = GetCursorPos();

                if(currentLeft == width - 2)
                {
                    Console.SetCursorPosition(currentLeft - 1, top);
                    Console.Write(" ");
                    Console.SetCursorPosition(currentLeft - 1, top);
                }

                if(keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (command.Length > 0)
                        command.Remove(command.Length - 1, 1);
                    if(currentLeft >= left)
                    {
                        Console.SetCursorPosition(currentLeft, top);
                        Console.Write(" ");
                        Console.SetCursorPosition(currentLeft, top);
                    }
                    else
                    {
                        command.Clear();
                        Console.SetCursorPosition(left, top);
                    }


                }


            }
            while (keyInfo.Key != ConsoleKey.Enter);
            ParseCommandString(command.ToString());
            
            
        }



        static void ParseCommandString(string command)
        {
            string[] commandParams = command.ToLower().Split(' ');
            if(commandParams.Length > 0)
            {
                switch (commandParams[0])
                {
                    case "cd":
                        if(commandParams.Length > 1)
                            if(Directory.Exists(commandParams[1]))
                            {
                                currDir = commandParams[1];
                            }
                        break;
                    case "ls":
                        if(commandParams.Length > 1 && Directory.Exists(commandParams[1]))
                            if (commandParams.Length > 3 && commandParams[2] == "-p" && int.TryParse(commandParams[3], out int n))
                            {
                                TreeDraw(new DirectoryInfo(commandParams[1]), n);
                            }
                            else
                            {
                                TreeDraw(new DirectoryInfo(commandParams[1]), 1);
                            }
                        break;
                }
            }

            UpdateConsole();

        }

        static string ShortPath(string path)
        {
            StringBuilder shortPath = new StringBuilder((int)API.MAX_PATH);

            API.GetShortPathName(path, shortPath, API.MAX_PATH);
            return shortPath.ToString();
        }

        


        /// <summary>
        /// Обновление ввода с консоли
        /// </summary>
        static void UpdateConsole()
        {
            DrawConsole(ShortPath(currDir), 0, 26, WINDOW_WIDTH, 3);
            ProcEnterComm(WINDOW_WIDTH);

        }

        /// <summary>
        /// Console drawing
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="heihgt"></param>
        static void DrawConsole(string dir, int x , int y, int width, int heihgt)
        {
            DrawWindow(x, y, width, heihgt);
            Console.SetCursorPosition(x + 1, y + heihgt / 2);
            Console.Write($"{dir}>");

        }


        /// <summary>
        /// window drawing
        /// </summary>
        /// <param name="x">initial x pos</param>
        /// <param name="y">initial y pos</param>
        /// <param name="height"> heigth </param>
        /// <param name="width"> width </param>
        static void DrawWindow(int x, int y, int width , int height)
        {
            // head

            Console.SetCursorPosition(x, y);
            Console.Write("╔");

            for(int i = 0; i < width-2; i++)           
                Console.Write("═");
            

            Console.Write("╗");

            // Window
            Console.SetCursorPosition(x, y + 1);
            for(int i = 0; i < height-2; i++)
            {
                Console.Write("║");

                for(int j = x + 1; j < x + width - 1; j++)
                    Console.Write(" ");   
                

                Console.Write("║");

            }

            //footer
           // Console.SetCursorPosition(x, y);
            Console.Write("╚");

            for (int i = 0; i < width - 2; i++)
                Console.Write("═");
            

            Console.Write("╝");
            Console.SetCursorPosition(x, y);

        }

        /// <summary>
        /// отрисовка дерева
        /// </summary>
        /// <param name="dir">directory</param>
        /// <param name="page">pagenum</param>
        
        static void TreeDraw(DirectoryInfo dir, int page )
        {
            StringBuilder tree = new StringBuilder();
            Tree(tree, dir, "", true);
            DrawWindow(0, 0, WINDOW_WIDTH, 18);
            (int currentLeft, int currentTop) = GetCursorPos();
            int pagelines = 16;

            string[] lines = tree.ToString().Split('\n');
            int pageTotal = (lines.Length + pagelines - 1 ) / pagelines;
            if (page > pageTotal)
                page = pageTotal;

            for(int i = (page -1)*pagelines, count = 0; i < page*pagelines; i++, count++)
            {
                if(lines.Length - 1 > i)
                {
                    Console.SetCursorPosition(currentLeft + 1, currentTop + 1 + count);
                    Console.WriteLine(lines[i]);
                }
            }

            // Page num
            string footer = $"╡{page} of {pageTotal}╞";
            Console.SetCursorPosition(WINDOW_WIDTH / 2 - footer.Length / 2, 17);
            Console.WriteLine(footer);


        }


        /// <summary>
        /// Создание дерева
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="dir"></param>
        /// <param name="indent"></param>
        /// <param name="lastdir"></param>
        static void Tree(StringBuilder tree, DirectoryInfo dir, string indent, bool lastdir)
        {
            tree.Append(indent);
            if (lastdir)
            {
                tree.Append("└─");
                indent += "  ";
            }
            else
            {
                tree.Append("├─");
                indent += "│ ";
            }

            tree.Append($"{dir.Name}\n");

            FileInfo[] subfiles = dir.GetFiles();
            for(int i = 0; i < subfiles.Length; i++)
            {
                if (i == subfiles.Length - 1)
                {
                    tree.Append($"{indent}└─{subfiles[i].Name}\n");
                }
                else
                {
                    tree.Append($"{indent}├─{subfiles[i].Name}\n");
                }
            }

            DirectoryInfo[] subDirects = dir.GetDirectories();
            for (int i = 0; i < subDirects.Length; i++)
                Tree(tree, subDirects[i], indent, i == subDirects.Length - 1);
        }
    }
}
