using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _18pz         // Работу выполнили Бабан и Печенкин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeOnly departureTime = new TimeOnly(8, 0);
            TimeOnly endOfWorkTime = new TimeOnly(17, 0);

            PublicTransport bus1 = new PublicTransport("AB 123 CD", "Олег Монгол", TransportType.Bus, departureTime, endOfWorkTime);
            bus1.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {bus1.IsOnRoute()}\n");

            PublicTransport train1 = new PublicTransport("CD 456 EF", "", TransportType.Train, departureTime, endOfWorkTime);
            train1.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {train1.IsOnRoute()}\n");

            PublicTransport train2 = new PublicTransport("БК 134 ВЫ", "Имя Фамилия", TransportType.Train, new TimeOnly(6, 20), endOfWorkTime);
            train2.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {train2.IsOnRoute()}\n");

            PublicTransport trolleybus1 = new PublicTransport("КУ 418 ОР", "Иван Иванов", TransportType.Trolleybus, departureTime, new TimeOnly(20, 0));
            trolleybus1.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {trolleybus1.IsOnRoute()}\n");

            PublicTransport trolleybus2 = new PublicTransport("ПР 041 СТ", "Петр Петров", TransportType.Trolleybus, departureTime, new TimeOnly(7, 59));
            trolleybus2.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {trolleybus2.IsOnRoute()}\n");

            PublicTransport train3 = new PublicTransport("ЙЦ 124 КА", "Виктор Прохоров", TransportType.Train, departureTime, endOfWorkTime);
            train3.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {train3.IsOnRoute()}\n");

            PublicTransport bus2 = new PublicTransport("ЦD 134 ЙL", "Евгений Пригожин", TransportType.Bus, new TimeOnly(16, 0), endOfWorkTime);
            bus2.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {bus2.IsOnRoute()}\n");

            PublicTransport train4 = new PublicTransport("US 911 TT", "Мухамед Абдулов", TransportType.Train, new TimeOnly(9, 11), endOfWorkTime);
            train4.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {train4.IsOnRoute()}\n");

            PublicTransport trolleybus3 = new PublicTransport("QE 134 UV", "Роберт Полсон", TransportType.Trolleybus, new TimeOnly(6, 20), new TimeOnly(7, 0));
            trolleybus3.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {trolleybus3.IsOnRoute()}\n");

            PublicTransport bus3 = new PublicTransport("КА 415 ПК", "", TransportType.Bus, departureTime, endOfWorkTime);
            bus3.DisplayInfo();
            Console.WriteLine($"Транспорт в рейсе: {bus3.IsOnRoute()}\n");

            PublicTransport.DisplayTotalObjects();

        }
    }
}