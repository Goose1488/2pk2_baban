namespace PZ_11
{
 using System;

    class Program
    {
        static void GetMax(out int maxValue, params int[] numbers)      // Ввод метода. Определение maxValue как выходного значения,
                                                                        //                          numbers  как входного массива с интовыми значениями.
        {
            maxValue = int.MinValue;  // maxValue присваивается минимальное значение int

            foreach (int num in numbers)    // 
            {                               // Перебором значений массива
                if (num > maxValue)         // находится наибольшее.                       
                    maxValue = num;         // 
                
            }
        }
                // Конец метода, начало основного кода
        static void Main()
        {
            int[] array = { 0, -10, 5, 21, 8, 15 };  // Ввод массива (через консоль не реализован).
            int result;                              // Объявление переменной результата

            GetMax(out result, array);               // Вывод maxValue (result), ввод numbers (array) из/в метод

            Console.WriteLine("Максимальное число: " + result); // Вывод результата на консоль
        }
    }
}