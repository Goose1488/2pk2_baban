namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");                       // Ввод строки
            string input = Console.ReadLine();                          //

            int first_spc = input.IndexOf(' ');                         // Определение индексов 
            int last_spc = input.LastIndexOf(' ');                      // первого и последнего пробелов

            string first_word = input.Substring(0, first_spc);          // Выделение подстрок
            string last_word = input.Substring(last_spc + 1);           // первого и последнего слов

            string output = last_word + input.Substring(first_spc, last_spc - first_spc) + " " + first_word; // Создание новой строки из обрезков старой

            Console.WriteLine("Результат: " + output);                  // Вывод
        }
    }
}