namespace Factory;

public class Bicycle : IVehicle
{
    public void Start() => Console.WriteLine("Bicycle pedaling started.");
    public void Stop() => Console.WriteLine("Bicycle pedaling stopped.");
    public string GetVehicleType() => "Bicycle";
}