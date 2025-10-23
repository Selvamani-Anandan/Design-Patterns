namespace Factory;

public class Motorcycle : IVehicle
{
    public void Start() => Console.WriteLine("Motorcycle engine started.");
    public void Stop() => Console.WriteLine("Motorcycle engine stopped.");
    public string GetVehicleType() => "Motorcycle";
}