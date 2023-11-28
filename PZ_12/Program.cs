namespace PZ_12
{
    class Program
    {
        static void fio(out string init, string full)      
        {
            string[] fullsp = full.Split(' ');
            string name = fullsp[1];
            string sname = fullsp[2];
            init = fullsp[0]+" "+name[0]+"."+sname[0]+".";
        }
        static void Main(string[] args)
        {
            string result;
            string full = Console.ReadLine();
            fio(out result, full);
            Console.WriteLine(result);
        }
    }
}