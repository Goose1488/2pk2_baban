﻿namespace ConsoleApp8
{
    internal class Program
    {
        static int mapSize = 25; // размер карты
        static char[,] map = new char[mapSize, mapSize]; // карта                       Работа не готова

        static int playerY = mapSize / 2;
        static int playerX = mapSize / 2;

        static byte maxEnemies = 10; // количество врагов
        static byte maxBeers = 1; // количество усилений
        static byte maxHealthAids = 6; // количество аптечек

        static byte Damage = 5;  // пока не используется
        static int playerHP = 20;
        static int BeerDuration = 10;
        static bool BeerActive = false;
        static int BeerRemainingSteps = 0;

        static int stepsCount = 0;  // для подсчета шагов
        static int totalEnemies = 0;
        static int stepPlayer = 0;

        static void Main(string[] args)
        {
            GenerationMap();
            Move();
        }

        static void GenerationMap()
        {
            Random random = new Random();

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = '_';
                }
            }

            map[playerY, playerX] = 'P';

            int x, y;

            while (totalEnemies < maxEnemies)
            {
                x = random.Next(0, mapSize);
                y = random.Next(0, mapSize);

                if (map[x, y] == '_')
                {
                    map[x, y] = 'E';
                    totalEnemies++;
                }
            }

            while (maxBeers > 0)
            {
                x = random.Next(0, mapSize);
                y = random.Next(0, mapSize);

                if (map[x, y] == '_')
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    map[x, y] = 'B';
                    maxBeers--;
                    Console.ResetColor();
                }
            }

            while (maxHealthAids > 0)
            {
                x = random.Next(0, mapSize);
                y = random.Next(0, mapSize);

                if (map[x, y] == '_')
                {
                    map[x, y] = 'H';
                    maxHealthAids--;
                }
            }

            UpdateMap();
        }
        static void UpdateMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(map[i, j]);
                }
            }
        }

        static void Move()
        {
            Console.CursorVisible = false;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                int playerOldX = playerX;
                int playerOldY = playerY;

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        playerX = Math.Max(0, playerX - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        playerX = Math.Min(mapSize - 1, playerX + 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        playerY = Math.Max(0, playerY - 1);
                        break;
                    case ConsoleKey.RightArrow:
                        playerY = Math.Min(mapSize - 1, playerY + 1);
                        break;
                    case ConsoleKey.Q:
                        GameSave();
                        break;
                }

                stepsCount++;

                if (map[playerX, playerY] == 'E')
                {
                    Fight();
                }
                else if (map[playerX, playerY] == 'H')
                {
                    Healing();
                }
                else if (map[playerX, playerY] == 'B')
                {
                    UseBeer();
                }
                else if (map[playerX, playerY] == 'S')
                {
                    Fight();
                }

                map[playerOldX, playerOldY] = '_';
                map[playerX, playerY] = 'P';

                DisplayStats();
                UpdateMap();
            }
        }
        static void GameSave()
        {
            Console.WriteLine("\nСохранить игру? (Y/N)");
            ConsoleKeyInfo saveKey = Console.ReadKey(true);

            if (saveKey.Key == ConsoleKey.Y)
            {
                string file1 = "save.txt";

                if (File.Exists(file1))
                {
                    Console.WriteLine("Файл сохранения уже существует. Перезаписать его? (Y/N)");
                    ConsoleKeyInfo overwriteKey = Console.ReadKey(true);

                    if (overwriteKey.Key != ConsoleKey.Y)
                    {
                        Console.WriteLine("Сохранение отменено.");
                        return;
                    }
                }

                using (StreamWriter writer = new StreamWriter(file1))
                {
                    // Сохранение параметров игры в файл
                    writer.WriteLine("Позиция игрока (X): " + playerX);
                    writer.WriteLine("Позиция игрока (Y): " + playerY);
                    writer.WriteLine("Здоровье игрока: " + playerHP);
                    writer.WriteLine("Всего сделано шагов: " + stepsCount);
                    writer.WriteLine("Оставшееся количество врагов: " + totalEnemies);

                    // Сохранение карты в файл
                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            writer.Write(map[i, j]);
                        }
                        writer.WriteLine();
                    }

                    Console.WriteLine("Игра успешно сохранена в файле save.txt.");
                }
            }
        }

        static void Fight()
        {
            if (BeerActive)
            {
                playerHP += 1;
                BeerRemainingSteps--;
            }
            playerHP -= Damage;


            if (playerHP <= 0)
            {
                Console.Clear();
                Console.WriteLine($"\n\n\n\n\n\n\n\n\n\t\tВы проиграли! Вы продержались {stepsCount} шагов. Осталось врагов: {totalEnemies}"); // SetCursorPosition для джунов 
                Console.ReadLine();
                Environment.Exit(0);
            }

            totalEnemies--;

            if (totalEnemies == 0)
            {
                map[mapSize / 2, mapSize / 2] = 'S';
                Damage = 10;
            }

            if (totalEnemies == -1)
            {
                Console.Clear();
                Console.WriteLine($"\n\n\n\n\n\n\n\n\n\t\tПоздравляю! Вы убили босса и прошли игру за {stepsCount} шагов.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        static void Healing()
        {
            playerHP = Math.Min(20, playerHP + 5); // Восстановление здоровья, не больше максимума
            Console.WriteLine($"\nВы использовали аптечку. Здоровье увеличено до {playerHP} единиц.                                   ");  // Пробелы чтобы часть сообщения о использовании пива не торчала справа
            Console.WriteLine("");                                                                                                       
        }

        static void UseBeer()
        {
            BeerActive = true;
            BeerRemainingSteps = BeerDuration;
            Console.WriteLine($"\nВы бахнули Балтику 9. Получаемый урон снижен на 1."); 
        }

        static void DisplayStats()
        {
            Console.SetCursorPosition(0, mapSize);
            Console.WriteLine($"\nЗдоровье: {playerHP} \nОсталось врагов: {totalEnemies}  \nШагов: {stepsCount}");
        }
    }
}

// Критерии оценки проекта:
//                      10 баллов
// + 2
// Реализована логика боя
// + 1
// Поднятие аптечки восстанавливает здоровье. Изменение
// отображается пользователю в консоли
// + 2 (другая механика) 
// Поднятие баффа усиливает атаку персонажа. Изменение
// отображается пользователю в консоли
// + 1
// Корректно работает сохранение прогресса в файл.
// - 2
// Корректно работает восстановление сессии из файла.
// + 1
// Персонаж не может выйти за пределы карты
// + 1
// Присутствуют информационные сообщения пользователю:
// Дополнительные баллы:
//                      6 баллов
// - 2
// Есть цветовая индикация объектов на карте
// - 2
// Присутствует псевдоанимация боя (сменяющиеся символы с
// небольшой задержкой в ячейке во время обмена ударами)
// + 2
// Появление босса(с повышенными характеристиками) после
// очистки карты