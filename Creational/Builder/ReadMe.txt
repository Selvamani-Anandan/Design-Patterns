# Builder Pattern

## Overview
The Builder Pattern is a creational design pattern that lets you construct complex objects step by step. It's particularly useful when you need to create an object with numerous possible configurations.

## Real-World Analogy: Pizza Restaurant 🍕

Think of ordering a pizza at a restaurant:
- The `Pizza` is your final product
- The `PizzaBuilder` is like a pizza recipe
- Different `ConcreteBuilders` (HawaiianPizzaBuilder, SpicyPizzaBuilder) are like different recipe cards
- The `Waiter` (Director) knows the steps but doesn't know the specific ingredients
- The construction process is the same (dough → sauce → toppings), but ingredients vary

## How to Remember the Pattern 🧠

Remember it as the "LEGO Building Pattern":
1. You have the final product (like a LEGO model)
2. You have step-by-step instructions (Builder)
3. Different instruction sets create different models (Concrete Builders)
4. Someone following the instructions (Director) doesn't need to know about specific pieces

## Key Components in Our Example

1. **Product** (`Pizza`):
   - The complex object we're building

2. **Builder** (`PizzaBuilder`):
   - Abstract interface defining construction steps
   - BuildDough()
   - BuildSauce()
   - BuildTopping()

3. **Concrete Builders**:
   - `HawaiianPizzaBuilder`: Makes Hawaiian pizza
   - `SpicyPizzaBuilder`: Makes Spicy pizza

4. **Director** (`Waiter`):
   - Controls the building process
   - Works with any builder

## When to Use Builder Pattern

Use it when:
- You need to create complex objects step by step
- The same construction process can create different representations
- You want to hide the complex construction process from the client

## Easy to Remember Formula

Think "**PADS**":
- **P**roduct (what you're building)
- **A**bstract Builder (the recipe template)
- **D**irector (the chef following the recipe)
- **S**pecific Builders (different recipes)

## Benefits
- Separates construction from representation
- Fine control over the construction process
- Reuse of construction code
- Single Responsibility Principle: isolates complex construction code

## Running the Example
```bash
dotnet run
```

Watch how different pizzas are constructed using the same process but with different ingredients!