# Factory Pattern

## What is the Factory Pattern?
The Factory Pattern is a creational design pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created.

## Easy Way to Remember
Think of a Vehicle Manufacturing Plant:
- You don't build a car, motorcycle, or bicycle directly
- Instead, you go to a factory (VehicleFactory) and say "I want a car"
- The factory knows all the complexities of creating each vehicle type
- You just get back the vehicle you requested, ready to use!

## When to Use
1. When you don't know ahead of time what class object you need
2. When you want to centralize object creation logic
3. When you want to delegate object creation to a separate component

## Key Components
1. Product (IVehicle): The interface that defines what the factory creates
2. Concrete Products (Car, Motorcycle, Bicycle): The actual objects being created
3. Factory (VehicleFactory): Creates and returns the products

## Benefits
1. Encapsulation: Creation logic is isolated in one place
2. Loose coupling: Client code doesn't need to know how objects are created
3. Easy to extend: Add new products without changing existing code
4. Consistent object creation: All objects are created through one interface

## Example Usage
```csharp
var factory = new VehicleFactory();
IVehicle car = factory.CreateVehicle("car");
car.Start();  // Output: Car started. Engine purring smoothly!
```

## Real-World Analogy
Think of ordering at a restaurant:
- You (client) don't go to the kitchen to make your food
- You tell the waiter (factory) what you want
- The kitchen (factory implementation) creates your meal
- You get your food ready to eat (product)

Remember: "Don't create objects directly, let the factory do it for you!"
