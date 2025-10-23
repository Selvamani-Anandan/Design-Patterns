using Factory;

// Client code
Console.WriteLine("Welcome to the Vehicle Factory Demo!");
Console.WriteLine("====================================\n");

var factory = new VehicleFactory();

// Create different types of vehicles
var vehicles = new List<string> { "Car", "Motorcycle", "Bicycle" };

foreach (var vehicleType in vehicles)
{
    Console.WriteLine($"\nCreating a {vehicleType}:");
    Console.WriteLine("------------------------");
    
    var vehicle = factory.CreateVehicle(vehicleType);
    
    // Use the vehicle
    Console.WriteLine($"Vehicle type: {vehicle.GetVehicleType()}");
    vehicle.Start();
    vehicle.Stop();
}

Console.WriteLine("\nFactory Pattern Demonstration Complete!");