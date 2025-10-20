public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
}

public class VictorianFurnitureFactory: IFurnitureFactory
{
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();  
}

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ArtDecoChair();
    public ISofa CreateSofa() => new ArtDecoSofa();
}