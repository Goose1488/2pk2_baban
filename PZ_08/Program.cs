namespace PZ_08
{
    class Program
    {
        static void Main()
        {
            // 1. Создание ступенчатого символьного массива и заполнение его случайными символами
            Random random = new Random();
            int y = 9;                                         // Количество строк в массиве
            char[][] massa = new char[y][];

            for (int i = 0; i < y; i++)
            {
                int rowLength = random.Next(10, 36); // Рандомная длина строки от 5 до 10 символов
                massa[i] = new char[rowLength];

                for (int j = 0; j < rowLength; j++)
                {
                    massa[i][j] = (char)(random.Next(26) + 'A' ); // Рандомные символы от 'A' до 'Z'
                }
            }

            // 2. Вывод сгенерированного массива в консоль
            Console.WriteLine("Массив:");
            foreach (char[] row in massa)
            {
                string rowString = new string(row);
                string rowprb = string.Join(" ", rowString.ToCharArray());
                Console.WriteLine(rowprb);
            }
                Console.WriteLine("\n");

            // 3. Создание нового одномерного массива с последними элементами каждой строки и его вывод
            char[] massaL = new char[y];
            for (int i = 0; i < y; i++)
            {
                if (massa[i].Length > 0)
                {
                    massaL[i] = massa[i][massa[i].Length - 1];
                }
            }
            Console.WriteLine("Последние символы каждой строки:");
            Console.WriteLine(new string(massaL));
            Console.WriteLine("\n");

            // 4. Нахождение максимальных элементов в каждой строке и их вывод
            char[] Marsel = new char[y];
            for (int i = 0; i < y; i++)
            {
                char maxChar = char.MinValue;
                foreach (char c in massa[i])
                {
                    if (c > maxChar)
                    {
                        maxChar = c;
                    }
                }
                Marsel[i] = maxChar;
            }
            Console.WriteLine("Максимальный элемент в каждой строке");
            Console.WriteLine(new string(Marsel));
            Console.WriteLine("\n");

            // 5. Замена первого и максимального элемента в каждой строке друг на друга и вывод нового массива
            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < y; i++)
            {
                if (massa[i].Length > 0)
                {
                    char maxChar = Marsel[i];
                    char firstChar = massa[i][0];
                    massa[i][0] = maxChar;
                    Marsel[i] = firstChar;
                    string rowString = new string(massa[i]);
                    string rowWithSpaces = string.Join(" ", rowString.ToCharArray());
                    Console.WriteLine(rowWithSpaces);
                }
            }
                    Console.WriteLine("\n");

            // 6. Реверс каждой строки и вывод массива
            Console.WriteLine("Массив с реверсированными строками:");
            for (int i = 0; i < y; i++)
            {
                if (massa[i].Length > 0)
                {
                    Array.Reverse(massa[i]);
                    string reversed = new string(massa[i]);
                    string reversedprb = string.Join(" ", reversed.ToCharArray());
                    Console.WriteLine(reversedprb);
                }
            }
            
                Console.WriteLine("\n");

            // 7. Определение наиболее встречающихся символов в каждой строке и их вывод
            char[] Popstar = new char[y];
            for (int i = 0; i < y; i++)
            {
                int[] Kolvo = new int[26]; 

                foreach (char c in massa[i])
                {
                    if (char.IsLetter(c))
                    {
                        Kolvo[c - 'A']++;
                    }
                }

                char VelikoBukva = 'A'; 
                int vsego = 0;

                for (int j = 0; j < 26; j++)
                {
                    if (Kolvo[j] > vsego)
                    {
                        VelikoBukva = (char)(j + 'A');
                        vsego = Kolvo[j];
                    }
                }

                Popstar[i] = VelikoBukva;
            }
            Console.WriteLine("Наиболее часто встречающиеся символы:");
            Console.WriteLine(new string(Popstar));
        }
    }
}