
Abstract Factory — easy explanation
----------------------------------

The Abstract Factory pattern provides a way to create families of related objects without specifying their concrete classes.

Think of it like a furniture company that makes sets: Modern, Victorian, ArtDeco. Each set includes a chair and a sofa. The factory (e.g., ModernFurnitureFactory) knows how to create the correct chair and sofa for its style.

Abstract Products --> Concrete Products ----- Abstract Factories --> Concrete Factories


1. Create Abstract Products (Interfaces)
2. Implement Interface in Concrete Products (Implement Interfaces)
3. Create Abstract Factory which 'returns' Interface from step 1.
4. Create Concrete Factory which organizes same type classes into one concrete classes, thus grouping the related objects.ß


Memory hooks (quick and sticky):
- "Family first": factories produce a family of products that belong together (chair + sofa).
- "Abstract factory returns abstract products": methods return interfaces (IChair, ISofa) not concrete classes.
- "Swap factory, swap style": change the factory and the whole family changes — no code change where products are used.

Roles in this repository
------------------------
- `IFurnitureFactory` (in `AbstractFactory.cs`): the abstract factory interface. It declares CreateChair() and CreateSofa().
- `IChair`, `ISofa` (in `AbstractProducts.cs`): abstract product interfaces.
- `ModernFurnitureFactory`, `VictorianFurnitureFactory`, `ArtDecoFurnitureFactory` (in `ConcreteFactory.cs`): concrete factories. Each creates matching concrete products.
- `ModernChair`, `VictorianChair`, `ArtDecoChair`, `ModernSofa`, `VictorianSofa`, `ArtDecoSofa` (in `ConcreteProducts.cs`): concrete products that implement the product interfaces.
- `FurnitureStore` (in `Client.cs`): the client that uses `IFurnitureFactory` and only depends on the abstract interfaces. It calls `ShowRoom()` which uses `IChair` and `ISofa`.
- `Program.cs`: example runner that constructs a concrete factory and passes it into `FurnitureStore`.

Why this is useful
-------------------
- Decoupling: client code depends on interfaces, not concrete classes. That makes swapping families (styles) easy.
- Single responsibility for families: factories centralize the choice of concrete products.
- Extensible: add a new family (e.g., "Rustic") by adding a new factory and products; client code doesn't change.

Quick example (conceptual)
--------------------------
var factory = new ModernFurnitureFactory();
var store = new FurnitureStore(factory);
store.ShowRoom(); // will print "Sitting on a modern chair." and "Lying on a modern sofa."

How to run this example
------------------------
Open a terminal and run:

```bash
cd "/Users/selvamanianandan/Documents/repos/Design-Patterns/Creational/AbstractFactory"
dotnet build
dotnet run
```

Tips for remembering in an interview
----------------------------------
- Draw it: Factory -> Products (Chair, Sofa) and label interfaces vs concrete classes.
- Say aloud: "Abstract factory makes families of products; client code asks the factory for products and works with interfaces."
- Give an example: furniture styles (Modern/Victorian/ArtDeco) — that's easy to visualize.

Small variations you might see
-----------------------------
- Factory Method vs Abstract Factory: Factory Method returns one product (often via subclassing). Abstract Factory groups many factories that produce families of products.
- Some implementations use dependency injection: the concrete factory is provided to the client by the DI container.

Files to inspect next
---------------------
- `Client.cs` - see how `FurnitureStore` depends only on `IFurnitureFactory`, `IChair`, and `ISofa`.
- `ConcreteFactory.cs` and `ConcreteProducts.cs` - see how families are implemented.

That's it — short, visual, and easy to remember. If you want, I can add a small UML diagram (ASCII or image) to this README or add a unit test that asserts the console output for each factory style.

ASCII UML diagram
-----------------

The diagram below shows the relationships (interfaces and concrete classes) in this example. It's a simplified view:

	+-----------------+          +-----------------------+
	| IFurnitureFactory|<>------>| CreateChair(): IChair |
	+-----------------+          | CreateSofa(): ISofa   |
			  ^                  +-----------------------+
			  |
	+-------------------------+
	| ModernFurnitureFactory  |    +----------------+    +----------------+
	| VictorianFurnitureFactory|   | ModernChair    |    | ModernSofa     |
	| ArtDecoFurnitureFactory |   +----------------+    +----------------+
	+-------------------------+
				 |                        implements            implements
				 |                        IChair                 ISofa
				 v
	+-----------------+
	| FurnitureStore  | --depends on--> IFurnitureFactory
	+-----------------+
	| - _chair: IChair|
	| - _sofa: ISofa  |
	+-----------------+

Dependency Injection (DI) note
------------------------------

You can wire a concrete factory into a DI container so the application resolves the correct family automatically. Example using Microsoft.Extensions.DependencyInjection:

```csharp
// Register a concrete factory (pick one style)
services.AddSingleton<IFurnitureFactory, ModernFurnitureFactory>();

// If FurnitureStore is used via DI, register it too
services.AddTransient<FurnitureStore>();

// Later, resolve FurnitureStore from IServiceProvider
var store = serviceProvider.GetRequiredService<FurnitureStore>();
store.ShowRoom();
```

Notes:
- Registering `IFurnitureFactory` lets you swap styles by changing the registration (e.g., to `VictorianFurnitureFactory`) without changing client code.
- In ASP.NET Core, put registrations in `Program.cs` / `Startup.cs`.

---