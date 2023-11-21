namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();    // ввод текста
            int middle = (text.Length - 1) / 2;  // определение центра текста
            if (text.Length % 2 == 0)            // если четное кол-во символов
                Console.WriteLine($"{text[middle]}{text[middle + 1]}");  // вывод двух центральных символов 
            else   // иначе (нечетное)
            {
                Console.WriteLine(text[middle]);         // вывод единственного центрального символа
            }
        }
    }
}