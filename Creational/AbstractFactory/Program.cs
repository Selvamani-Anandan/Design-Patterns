using System;

class Program
{
    static void Main()
    {
        var factory = new ModernFurnitureFactory();
        var store = new FurnitureStore(factory);
        store.ShowRoom();

        var victorianFactory = new VictorianFurnitureFactory();
        var victorianStore = new FurnitureStore(victorianFactory);
        victorianStore.ShowRoom();

        var artDecoFactory = new ArtDecoFurnitureFactory();
        var artDecoStore = new FurnitureStore(artDecoFactory);
        artDecoStore.ShowRoom();
    }
}
