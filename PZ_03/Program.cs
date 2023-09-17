Console.Write("Введите сумму покупки:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите текущий день недели:  ");

string d = Console.ReadLine();

switch (d)
{
    case "Понедельник":
        int b = Convert.ToInt32(a * 0.97);
        Console.WriteLine($"Скидка 3%, итого {b}");
        break;
    case "Вторник":
        int q = Convert.ToInt32(a * 0.97);
        Console.WriteLine($"Скидка 3%, итого {q}");
        break;
    case "Среда":
        int w = Convert.ToInt32(a * 0.97);
        Console.WriteLine($"Скидка 3%, итого {w}");
        break;
    case "Четверг":
        int e = Convert.ToInt32(a * 0.97);
        Console.WriteLine($"Скидка 3%, итого {e}");
        break;
    case "Пятница":
        int r = Convert.ToInt32(a * 0.97);
        Console.WriteLine($"Скидка 3%, итого {r}");
        break;
    case "Суббота":
        int t = Convert.ToInt32(a * 0.93);
        Console.WriteLine($"Скидка 7%, итого {t}");
        break;
    case "Воскресенье":
        int y = Convert.ToInt32(a * 0.93);
        Console.WriteLine($"Скидка 7%, итого {y}");
        break;
}