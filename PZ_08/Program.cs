namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] huge = new char[9][];
            Random random = new Random();
            string bkv = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int bd = bkv.Length;
            for (int i = 0; i < 9; i++)
            {
                int dln = random.Next(10, 36);
                string str = "";
                for (int j = 0; j < dln; j++)
                {
                  char  ranb = bkv[random.Next(bd)];
                    str += ranb;
                }
               
                Console.Write(huge + "\t");
            }
        
        }

    }
}