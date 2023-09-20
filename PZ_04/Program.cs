namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Первое задание

            int n; 
            Console.WriteLine("Первое задание");
            for (n = 0; n <= 70; n += 2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();


         //Второе задание

            Console.WriteLine("Второе задание");
            char a;
            for (a = 'd'; a <= 'i'; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();


         //Третье задание

            Console.WriteLine("Третье задание");
            string h = "#####";
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();


         //Четвёртое задание

             int e = 0;
             int q = 0;
             Console.WriteLine("Четвёртное задание");
             for (e = 0; e <= 200; e++)
             if (e%7== 0)
             {
                 Console.Write(e + " ");
                 q++;
             }
             Console.WriteLine("\nКоличество чисел, кратных 7: " + q ) ;
             Console.WriteLine("Нажмите Enter для продолжения");
             Console.ReadLine();


         //Пятое задание
             int i = 2;
             int j = 40;

             while (Math.Abs(i - j) > 25)
             {
                Console.WriteLine($"i = {i}, j = {j}");
                i++;
                j--;
             }

             Console.WriteLine("Все задания выполнены") ;
        }
    }
}