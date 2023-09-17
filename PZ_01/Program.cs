using System;

namespace PZ_01                                             
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;                                                                   ///   переменные a & b
            double d1;                                                                  // 
            double d2;                                                                  //
            double d3;                                                                  //    переменная для каждого действия
            double d4;                                                                  //    
            double d5;                                                                  //
            double pre_d5;                                                              // 
            double d6;                                                                  //
            double d7;                                                                  //
            double pre_d8;                                                              //
            double d8;                                                                  //
            double d9;                                                                  //
            double d10;                                                                 //
                                                                                        //
            Console.WriteLine("Введите а:");                                        ///
            a = Convert.ToInt32(Console.ReadLine());                                    ///
            Console.WriteLine("Введите b:");                                        ///
            b = Convert.ToInt32(Console.ReadLine());                                    ///   ввод значений переменных
            Console.WriteLine("Введите величину угла с в градусах:");               ///
            string c = Console.ReadLine();                                              ///   
            double.TryParse(c, out double градусы);                                     ///   в контрольном примере C в виде радиан, у меня в виде градусов
            double радианы = градусы * (Math.PI / 180.0);                               //  
            pre_d5 = Math.Sin(радианы);                                                 //    вычисление синуса для 5 действия и косинуса для 6
            double кос_с = Math.Cos(радианы);                                           //  


            d1 = a - 1;                                                                 //         1 действие
            d2 = Math.Pow(d1, 1.0 / 3);                                                   //         2 действие
            d3 = b + d2;                                                                //         3 действие
            d4 = Math.Pow(d3, 1.0 / 4);                                                 //         4 действие
            d4 = Math.Round(d4, 0);                                                     //         округление 
            d5 = Math.Pow(pre_d5, 2.0);                                                 //         5 действие
            d5 = Math.Round(d5, 2);                                                     //    тоже округление
            d6 = pre_d5 / кос_с;                                                        //         6 действие
            d7 = d5 + d6;                                                               //         7 действие
            pre_d8 = a - b;                                                             //    пред_8 действие (модуль)
            d8 = Math.Abs(pre_d8);                                                      //         8 действие
            d9 = d7 * d8;                                                               //         9 действие
            d10 = d4 / d9;                                                              //        10 действие

            Console.WriteLine("Ответ:");                                                //           вывод
            Console.WriteLine(d10);                                                     //
        }
    }
}