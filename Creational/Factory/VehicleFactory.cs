namespace Factory;

public class VehicleFactory
{
    public IVehicle CreateVehicle(string type)
    {
        if (string.IsNullOrWhiteSpace(type))
            throw new ArgumentException("type must be provided", nameof(type));

        return type.Trim().ToLowerInvariant() switch
        {
            "car" => new Car(),
            "motorcycle" => new Motorcycle(),
            "bicycle" => new Bicycle(),
            _ => throw new ArgumentException($"Unknown vehicle type: {type}", nameof(type)),
        };
    }
}