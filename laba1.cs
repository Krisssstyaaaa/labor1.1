using System;

// Базовый класс для всех видов техники
public abstract class Vehicle
{
    public string Manufacturer { get; set; }

    public Vehicle(string manufacturer)
    {
        Manufacturer = manufacturer ?? throw new ArgumentNullExseption(nameof(Manufacturer)) "Вы не ввели значение";
    }
}

// Класс для легковых автомобилей
public class Car : Vehicle
{
    public double EngineVolume { get; set; }
    public decimal MaxPayload { get; set; }
    public string FuelType { get; set; }
    public string BodyType { get; set; }

    public Car(string manufacturer, double engineVolume, decimal maxPayload, string fuelType, string bodyType) : base(manufacturer)
    {
        EngineVolume = engineVolume ;
        MaxPayload = maxPayload ;
        FuelType = fuelType ?? throw new ArgumentNullExseption(nameof(FuelType)) "Вы не ввели значение";
        BodyType = bodyType ?? throw new ArgumentNullExseption(nameof(BodyType)) "Вы не ввели значение";
    }
}

// Класс для грузовых автомобилей
public class Truck : Vehicle
{
    public double EngineVolume { get; set; }
    public decimal MaxPayload { get; set; }
    public string FuelType { get; set; }

    public Truck(string manufacturer, double engineVolume, decimal maxPayload, string fuelType) : base(manufacturer)
    {
        EngineVolume = engineVolume ;
        MaxPayload = maxPayload ;
        FuelType = fuelType ?? throw new ArgumentNullExseption(nameof(FuelType)) "Вы не ввели значение";
    }
}

// Класс для самолетов
public class Airplane : Vehicle
{
    public double MaxFlightAltitude { get; set; }
    public int RunwayLength { get; set; }

    public Airplane(string manufacturer, double maxFl ightAltitude, int runwayLength) : base(manufacturer)
    {
        MaxFlightAltitude = maxFlightAltitude ;
        RunwayLength = runwayLength ;
    }
}

// Класс для мотоциклов
public class Motorcycle : Vehicle
{
    public double EngineVolume { get; set; }
    public bool HasSidecar { get; set; }

    public Motorcycle(string manufacturer, double engineVolume, bool hasSidecar) : base(manufacturer)
    {
        EngineVolume = engineVolume ;
        HasSidecar = hasSidecar ;
    }
}

// Класс для катеров
public class Boat : Vehicle
{
    public double EngineVolume { get; set; }
    public bool HasCabin { get; set; }

    public Boat(string manufacturer, double engineVolume, bool hasCabin) : base(manufacturer)
    {
        EngineVolume = engineVolume ;
        HasCabin = hasCabin ;
    }
}

