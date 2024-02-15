using System;
using System.Text.RegularExpressions;

public enum TransportType
{
    Trolleybus,
    Bus,
    Train
}

public class PublicTransport
{
    private static int totalObjects = 0;

    public string LicensePlate { get; private set; }
    public string AssignedDriver { get; private set; }
    public TransportType Type { get; private set; }
    public TimeOnly DepartureTime { get; private set; }
    public TimeOnly EndOfWorkTime { get; private set; }

    public PublicTransport(string licensePlate, string assignedDriver, TransportType type, TimeOnly departureTime, TimeOnly endOfWorkTime)
    {
        if (!ValidateLicensePlate(licensePlate))
        {
            throw new ArgumentException("Неверный формат номера, введите в формате 'LL NNN LL'.");
        }

        LicensePlate = licensePlate;
        AssignedDriver = string.IsNullOrWhiteSpace(assignedDriver) ? "не назначен" : assignedDriver;
        Type = type;
        DepartureTime = departureTime;
        EndOfWorkTime = endOfWorkTime;

        totalObjects++;
    }

    public bool IsOnRoute()
    {
        TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
        return currentTime >= DepartureTime && currentTime <= EndOfWorkTime;
    }

    public void DisplayInfo()
    {
        string status = IsOnRoute() ? "в рейсе" : "в парке";
        Console.WriteLine($"Гос. номер: {LicensePlate}");
        Console.WriteLine($"Водитель: {AssignedDriver}");
        Console.WriteLine($"Тип транспорта: {Type}");
        Console.WriteLine($"Текущий статус: {status}");
    }

    public static void DisplayTotalObjects()
    {
        Console.WriteLine($"Всего транспорта: {totalObjects}");
    }

    public bool ValidateLicensePlate(string licensePlate)
    {
        if (licensePlate.Length != 9)
        {
            return false;
        }

        if (!char.IsLetter(licensePlate[0]) || !char.IsLetter(licensePlate[1]))
        {
            return false;
        }

        for (int i = 3; i < 6; i++)
        {
            if (!char.IsDigit(licensePlate[i]))
            {
                return false;
            }
        }

        for (int i = 7; i < 9; i++)
        {
            if (!char.IsLetter(licensePlate[i]))
            {
                return false;
            }
        }

        return true;
    }
}