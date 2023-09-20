namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; //первое задание
            Console.WriteLine("Первое задание");
            for (i = 0; i <= 70; i += 2)
            {
                Console.WriteLine(i);
            }
            //второе задание
            Console.WriteLine("Второе задание");
            char a;
            for (a = 'd'; a <= 'z'; a++)
            {
                Console.WriteLine(a);
            }
            //третье задание
            Console.WriteLine("Третье задание");
            string h = "#####";

            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine(h);
                }

                int e=0;//Четвёртное задание
                Console.WriteLine("Четвёртное задание");
                for (e = 0; e <= 200; e++)
                    if (e%7== 0)
                {
                    Console.Write(e + " ");
                     e++;
                }
                Console.WriteLine("\nКоличество чисел, кратных 7: "+e) ;

            }

        }
    }
}