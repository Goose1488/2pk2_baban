namespace PZ_14
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            using (StreamWriter inputFile = new StreamWriter(inputPath)) // Создание файла input.txt
            {
                inputFile.WriteLine("5");
                inputFile.WriteLine("10");
                inputFile.WriteLine("3");       // Ввод чисел в input.txt (можно сделать через random или ввод с консоли)
                inputFile.WriteLine("8");
                inputFile.WriteLine("1");
            }

            int[] numbers = ReadNumbersFromFile(inputPath); // Чтение чисел из файла


            int maxNumber = FindMaxNumber(numbers);     // Поиск максимального и минимального чисел
            int minNumber = FindMinNumber(numbers);     // Через методы

            using (StreamWriter outputFile = new StreamWriter(outputPath))  // Запись результатов в файл output.txt
            {
                outputFile.WriteLine($"Максимальное число: {maxNumber}");
                outputFile.WriteLine($"Минимальное число: {minNumber}");
            }

            Console.WriteLine($"Максимальное ({maxNumber}) и минимальное ({minNumber}) числа записаны в файл output.txt");
        }

        static int[] ReadNumbersFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);       // Метод с созданием массива чисел из input.txt
            }

            return numbers;
        }

        static int FindMaxNumber(int[] numbers)
        {
            int max = int.MinValue;

            foreach (int number in numbers)     // Метод для поиска максимального числа
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        static int FindMinNumber(int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)     // и минимального числа
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}