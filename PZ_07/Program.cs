namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[5, 10];           // создание массива
            Console.WriteLine("Массив A:");            
            Random random = new Random();              // сделал заполнение через рандом т.к. массив объемный
            for (int i = 0; i < 5; i++)                // если нужно заполнить конкр. числами, то нужно будет сделать проверку на принадлежность к double в if else через TryParse
            {
                for (int j = 0; j < 10; j++)
                {
                    int randomInt = random.Next(-10000, 10000);     // через int создаются числа от -10000 до 9999
                    A[i, j] = (double)randomInt / 100;              //  затем они делятся на 100 для получения чиcел в double с 2 знаками после запятой
                                                                    //  т.е. при вводе чисел пользователем вводить их нужно будет без запятой (костыль получается)
                    Console.Write(A[i,j] + "\t");                   /// вывод массива

                }
                Console.Write("\n");                   // приведение массива в "табличный" вид
            }                                          
                double[] sum = new double[5];          /// переменные для суммы и произведения чисел в строках
                double[] pzv = new double[5];          ///

            for (int i = 0; i < 5; i++)                 // 
            {                                           //
                double nSum = 0;                        //
                double nProduct = 1;                    //
                for (int j = 0; j < 10; j++)            // вычисление суммы и произведения для каждой строки
                {                                       //
                    nSum += A[i, j];                    //
                    nProduct *= A[i, j];                //
                }                                       //
                sum[i] = nSum;                          //
                pzv[i] = nProduct;                      //
            }                                           //

            for (int i = 0; i < 5; i++)          
            {
                Console.WriteLine($"\nСумма элементов в строке {i + 1}: {sum[i]}");           // Вывод
                Console.WriteLine($"Произведение элементов в строке {i + 1}: {pzv[i]}");      //

            }
        }
    }
}
