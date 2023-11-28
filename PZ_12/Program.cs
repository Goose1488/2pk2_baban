namespace PZ_12
{
    class Program
    {
        static void fio(out string init, string full)      
        {
            string[] fullsp = full.Split(' ');  // Строка делится на массив слов
            string name = fullsp[1]; // Переменная с 1 буквой имени
            string sname = fullsp[2]; // Переменная с 1 буквой отчества
            init = fullsp[0]+" "+name[0]+"."+sname[0]+"."; // Вывод в необходимом формате
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО:");
            string result;
            string full = Console.ReadLine();
            fio(out result, full);     // Обращение к функции
            Console.WriteLine(result); // Вывод в консоль
        }
    }
}