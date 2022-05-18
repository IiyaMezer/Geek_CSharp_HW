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
            Console.ReadKey();
          
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
           Console.ReadKey();
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
            Console.ReadKey();
        }


        /// <summary>
        /// Задача 4 
        /// Схематичное изображение чека.
        /// </summary>
        static void Task04()
        {
            //Обьявление переменныйх
            string CompanyName = "ИП Иванов";
            string address = "г.Барнаул, Ленина 1";
            int postnum = 777;
            int Personel = 7458;
            string operatorname = "Иванов Иван Иванович";

            int checkNum = 7895;

            // Наименование продукка
            string prodName1 = "Продукт 1";
            string prodName2 = "Продукт 2";
            string prodName3 = "Продукт 3";
            string prodName4 = "Продукт 4";
            string prodName5 = "Продукт 5";

            //Цена
            double price1 = 55441.53;
            double price2 = 7875.66;
            double price3 = 1.53;
            double price4 = 4.50;
            double price5 = 554.50;
            double price6 = 980.90;

            //Скидка
            double discount1 = 0.15;
            double discount2 = 0.0;
            double discount3 = 0.50;
            double discount4 = 0.80;
            double discount5 = 0.10;

            //Цена со скидкой
            double discPrice1 = price1*(1-discount1);
            double discPrice2 = price2*(1-discount2);
            double discPrice3 = price3*(1-discount3);
            double discPrice4 = price4*(1-discount4);
            double discPrice5 = price5*(1-discount5);

            //Количество
            int quant1 = 100;
            int quant2 = 10;
            int quant3 = 9;
            int quant4 = 8;
            int quant5 = 15;

            //Стоитмость
            double total1= discPrice1 * quant1;
            double total2= discPrice2 * quant2;
            double total3= discPrice3 * quant3;
            double total4= discPrice4 * quant4;
            double total5= discPrice5 * quant5;

            //Итоговая смоимость
            double total = total1 + total2 + total3 + total4 + total5;
            


            // Вывод 
            Console.WriteLine(CompanyName);
            Console.WriteLine(address);
            Console.Write($"Касса N  {postnum}  ");
            Console.WriteLine($"Кассир N  {Personel},    {operatorname}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Кассовый чек {checkNum}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Наименование     Цена    Скидка      Цена со скидкой    Кол-во   Итого");
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"{prodName1}  {price1}   {discount1}   {discPrice1}     {quant1}    {total1}");
            Console.WriteLine($"{prodName2}  {price2}   {discount2}   {discPrice2}     {quant2}    {total2}");
            Console.WriteLine($"{prodName3}  {price3}   {discount3}   {discPrice3}     {quant3}    {total3}");
            Console.WriteLine($"{prodName4}  {price4}   {discount4}   {discPrice4}     {quant4}    {total4}");
            Console.WriteLine($"{prodName5}  {price5}   {discount5}   {discPrice5}     {quant5}    {total5}");
            Console.WriteLine($"Итоговая цена                                                      {total}");
            Console.WriteLine($"                          СПАСИБО ЗА ПОКУПКУ                      ");
            Console.ReadKey();
         
        }
        

        
        /// <summary>
        /// Задание 5
        /// Комбинация задания 1 и 2 с добалнением условного оператора
        /// 
        /// 
        /// </summary>
        static void Task05()
        {
            Console.Write("Введите максмальную погоду:");
            decimal maxtemp = decimal.Parse(Console.ReadLine());

            Console.Write("Введите минимальную погоду:");
            decimal mintemp = decimal.Parse(Console.ReadLine());

            decimal MidT = MidTempCalc(maxtemp, mintemp);
            Console.WriteLine($"Средняя темпаратура: {MidT}");

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
            if (month == 1 || month == 2 || month==3 || month==12 || month == 11 && MidT>= 0)
            {
                Console.WriteLine("Ожидайте слякоть и скользкие дороги"); //Добваил в это задание еще ноябрь и март, так-как в Томске в эти месяцы уверенный минус
            }
           Console.WriteLine("press any key to shutdouw");
           Console.ReadKey();
          
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
                
                case 5:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 4");
                    Console.WriteLine("========================");
                    Task05();
                    Console.WriteLine("========================");
                    break;


            }
                                            
        }                  
    }
}
