using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager
{
    internal class Program
    {
        /// <summary>
        /// Метод бля остановки процесса.
        /// Не нашел методов и классов для убийства отдельного процесса,
        /// Поэтому написал свой через перебор всех процессов из массива
        /// </summary>
        /// <param name="id"> id процесса для остановки </param>
        /// <param name="procarr"> массив процессов </param>
        static void Kill(int id, Process []procarr)
        {
            foreach(Process proc in procarr)
            {
                if (proc.Id == id)
                {

                    Console.WriteLine($"Процесс {proc.ProcessName} ID: {proc.Id} остановлен.");
                    proc.Kill();

                    break;
                }

            }

        }

         /// <summary>
         /// Программа завершения процесса по его ID, решил не делать меню .
         /// </summary>
         /// <param name="args"></param>
                
        static void Main(string[] args)
        {

            
            int prNum = 0; //переменная сугубо для счетчика процессов.

            Console.WriteLine("Список процессов: ");
            Process[] processList = Process.GetProcesses(); // список процессов, для компактности можно было обьявить список процессов по имени.  

            foreach (Process process in processList)
            {

             Console.WriteLine($"Proc №{++prNum}: {process.ProcessName}, ID: {process.Id}.");
            }

            Console.Write("Type ID of process to kill: ");
            int kilID = int.Parse(Console.ReadLine());
            Kill(kilID, processList);

           
                        

            Console.ReadKey(true);
        }
    }
}
