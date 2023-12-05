namespace PZ_15
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите полный путь к каталогу:");
            string directoryPath = Console.ReadLine();                  // Ввод пути
            if (Directory.Exists(directoryPath))                        // Проверка на существование папки 
            {
                try
                {
                    string tempPath = CreateTempDirectory(directoryPath); // Создание ТЕМР вызовом метода
                    MoveFilesToTemp(directoryPath, tempPath);   // перемещение файлов в ТЕМР
                    Console.WriteLine("Содержимое каталога успешно перемещено в подкаталог 'TEMP'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Указанный каталог не существует.");
            }
        }

        static string CreateTempDirectory(string directoryPath) 
        {
            string tempPath = Path.Combine(directoryPath, "TEMP"); // создание строки с путем до ТЕМР

            try
            {
                Directory.CreateDirectory(tempPath);    // создание папки
                return tempPath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании подкаталога 'TEMP': {ex.Message}");
                return null;
            }
        }

        static void MoveFilesToTemp(string sourceDirectory, string destinationDirectory)
        {
            string[] files = Directory.GetFiles(sourceDirectory); // создание массива с файлами в папке по пути directoryPath

            foreach (string file in files)
            {
                try
                {
                    string fileName = Path.GetFileName(file);                           //
                    string destFile = Path.Combine(destinationDirectory, fileName);     // перемещение файлов массива в ТЕМР
                    File.Move(file, destFile);                                          //
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перемещении файла: {ex.Message}");
                }
            }
        }
    }
}