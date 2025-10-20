public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair.");
    }
}

public class ModernSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on a modern sofa.");
    }
}

public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}

public class VictorianSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on a Victorian sofa.");
    }
}

public class ArtDecoChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on an Art Deco chair.");
    }
}

public class ArtDecoSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on an Art Deco sofa.");
    }
}
