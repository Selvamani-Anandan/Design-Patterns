namespace Factory;

public class Car : IVehicle
{
    public void Start() => Console.WriteLine("Car engine started.");
    public void Stop() => Console.WriteLine("Car engine stopped.");
    public string GetVehicleType() => "Car";
}