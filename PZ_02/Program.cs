namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            Console.Write("Введите значение a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());
            double n, m, k;
            if (b > 10.5)
            { n = 38 * a / (13 * (a - b)); }
            else
            { n = 12 * Math.Cos(0.1 * b); }
            if (n <= 2)
            { m = Math.Sin(a * Math.Pow(n, 2)); }
            else
            { m = 21 * a * n + 2.5 * Math.Pow(n, 2); }
            k = Math.Pow((a + n), 4) + Math.Pow((b + m), 2);
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"n: {n}");
            Console.WriteLine($"m: {m}");
            Console.WriteLine($"k: {k}");
            Console.ReadLine();
        }
    }
}