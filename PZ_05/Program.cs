namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную сумму вклада.");
            double x = Convert.ToDouble(Console.ReadLine()); // начальная сумма вклада 
            Console.WriteLine("Введите прицентную ставку.");
            double p = Convert.ToDouble(Console.ReadLine()); // годовая процентная ставка 
            Console.WriteLine("Введите необходимую сумму.");
            double y = Convert.ToDouble(Console.ReadLine()); // необходимая сумма 
            int z = 0;                                       // количество лет

            if (x < 0 && p < 0 && y < 0)                                                                                     //
                Console.WriteLine("Некорректные данные.");                                                                   //
            if (p == 0)                                                                                                      //
                Console.WriteLine("Советуем вам выбрать другой банк.");                                                      // нечто странное                        
            if (x > y)                                                                                                       //
               Console.WriteLine("Начальная сумма превышает необходимую. Пожертвуете лишние деньги в приют? «Да» или «Нет»");//

            string philanthropy = Console.ReadLine();                                                                        //
            switch (philanthropy)                                                                                            //
            {                                                                                                                //
                case "Да" :                                                                                                  //
                    Console.WriteLine("Спасибо! Вы хороший человек.");                                                       //  https://imgur.com/a/t6kbfQ0
                    break;                                                                                                   //
                case "Нет":                                                                                                  //
                    Console.WriteLine("Это будет на Вашей совести.");                                                        //
                    break;                                                                                                   //
                default:                                                                                                     //
                    Console.WriteLine("Сочту это за «Нет»");                                                                 //
                    break;                                                                                                   //
            }

            while (x < y)
            {
                x += x * (p / 100);                          // увеличиваем сумму на p процентов
                x = Math.Floor(x);                           // отбрасываем дробную часть копеек
                z++;                                         // увеличиваем счетчик лет
            }

            if (z == 0)                                                                 //
                Console.WriteLine("Пожелайте накопить больше денег");                   //
            else                                                                        //
            Console.WriteLine($"Через {z} лет вклад составит не менее {y} рублей.");    // вывод
            Console.ReadLine();                                                         // 
        }
    }
}