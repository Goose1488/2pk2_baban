﻿namespace PZ_13
{
    internal class Program
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Метод для 1 задания
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static int Aprog(int a1, int d, int n1)
        {
            int count = 0;
            if (n1 == 1) // база
                Console.WriteLine(a1);
            else //рекурсия
            {
                count = Aprog(a1 + d, d, n1 - 1); // к а1 прибавляется d, n уменьшается 1
            }
            return count;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Метод для 2 задания
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static double Gprog(double b1, double q, int n2)
        {
            double count = 0;
            if (n2 == 1) // база
                Console.WriteLine(b1);
            else //рекурсия
            {
                count = Gprog(b1 * q, q, n2 - 1); // b1 умножается на q, n уменьшается 1
            }
            return count;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Метод для 3 задания
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static int Inter(int A, int B)
        {

            if (A == B) // База
                Console.WriteLine(A);
            else // Рекурсия 
            {
                Console.Write($"{A}, ");
                Inter(A + 1, B);
            }
            return B;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Метод для 4.4 задания 
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Invert(int number)
        {
            if (number < 10)
            {
                Console.Write(number);
                return;
            }

            Console.Write(number % 10);
            Invert(number / 10);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Main
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main()
        {
            // Первое задание
            int a1 = 100;
            int d = 10;
            Console.WriteLine("Первое задание:");
            Console.WriteLine("Введите номер члена прогрессии:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n1} член прогрессии:");
            int first = Aprog(a1, d, n1);

            // Второе задание
            int b1 = 4;
            double q = 0.1;
            Console.WriteLine("Второе задание:");
            Console.WriteLine("Введите номер члена прогрессии:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n2} член прогрессии:");
            double second = Gprog(b1, q, n2);

            // Третье задание
            Console.WriteLine("Третье задание:");
            Console.WriteLine("Все числа между А и В:");
            int A = 5;
            int B = 65;
            int third = Inter(A, B);

            // Четвертое задание
            Console.WriteLine("Четвертое задание (№4):");
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Invert(number);

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

}