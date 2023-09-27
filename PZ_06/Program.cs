namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] massa;                                                //  Создание массива
            Console.WriteLine("Введите количество элементов массива:");
            string n = Console.ReadLine();                              // Введение переменной 
            if (int.TryParse(n, out int n2))                            // и ее проверка на принадлежность к обл. опр. int
            {
                n2 = int.Parse(n);                                      // преобразование из string в int

            if (n2 < 1)
            {
                Console.WriteLine("Массив должен содержать хотя бы 1 элемент"); /// вывод ошибки (консоль сворачивается и начинается отладка на 17 строке, но сообщение выводится)
            }
            massa = new int[n2];                                 //  Выделение памяти
            Random random = new Random();                        /// Введение random

            for (int i = 0; i < massa.Length; i++)               // 
            {                                                    // Заполнение массива случайными числами от -50 до 49
                massa[i] = random.Next(-50, 50);                 //
            }                                                    //
            Console.Write("Массив чисел: ");                     /// Вывод массива 
            for (int i = 0; i < massa.Length; i++)
                Console.Write($" {massa[i]} ");


            int sumNG = 0;                                      // Введение переменных для суммы отрицательных чисел
            int minPL = int.MaxValue;                           // и для определения минимального положительного числа

            foreach (int num in massa)                          // "Для каждого элемента массива:"
            {                                                   //
                if (num < 0)                                    ///
                {                                               /// Отрицательные числа складываются
                    sumNG += num;                               ///
                }                                               ///
                else if (num > 0 && num < minPL)                // 
                {                                               // Среди положительных находится меньшее
                    minPL = num;                                //
                }                                               //
            }

            if (sumNG < -100)                                                   // Проверка, является ли сумма отрицательных чисел меньше -100
            {                                                                   //
                sumNG += minPL;                                                 // Если меньше, к этой сумме добавляется значение минимального положительного числа
            }                                                                   //

            Console.WriteLine($"\nСумма отрицательных элементов: {sumNG}");     // Вывод
        }
            else
            {
                Console.WriteLine("Некорректные данные, введите число из области определения int"); // вывод 1 ошибки
            }
        }
    }       
}