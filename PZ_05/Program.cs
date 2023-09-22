namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную сумму вклада");
            double x = Convert.ToDouble(Console.ReadLine()); // начальная сумма вклада 
            Console.WriteLine("Введите прицентную ставку");
            double p = Convert.ToDouble(Console.ReadLine()); // годовая процентная ставка 
            Console.WriteLine("Введите необходимую сумму");
            double y = Convert.ToDouble(Console.ReadLine()); // необходимая сумма 
            int z = 0;                                       // количество лет

            while (x < y)
            {
                x += x * (p / 100);                          // увеличиваем сумму на p процентов
                x = Math.Floor(x);                           // отбрасываем дробную часть копеек
                z++;                                         // увеличиваем счетчик лет
            }

            Console.WriteLine($"Через {z} лет вклад составит не менее {y} рублей.");
        }
    }
}