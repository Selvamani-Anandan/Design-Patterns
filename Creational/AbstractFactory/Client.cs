public class FurnitureStore
{
    private readonly IChair _chair;
    private readonly ISofa _sofa;

    public FurnitureStore(IFurnitureFactory factory)
    {
        _chair = factory.CreateChair();  // 👈 uses abstract factory interface
        _sofa = factory.CreateSofa();    // 👈 receives abstract product interface
    }

    public void ShowRoom()
    {
        _chair.SitOn();  // 👈 calls abstract interface method
        _sofa.LieOn();   // 👈 calls abstract interface method
    }
}
