using Builder;

namespace Builder;

// Concrete Builder
public class HawaiianPizzaBuilder : PizzaBuilder
{
    public override void BuildDough()
    {
        pizza.Dough = "Regular";
    }

    public override void BuildSauce()
    {
        pizza.Sauce = "Sweet";
    }

    public override void BuildTopping()
    {
        pizza.Topping = "Ham+Pineapple";
    }
}

// Another Concrete Builder
public class SpicyPizzaBuilder : PizzaBuilder
{
    public override void BuildDough()
    {
        pizza.Dough = "Thin";
    }

    public override void BuildSauce()
    {
        pizza.Sauce = "Hot";
    }

    public override void BuildTopping()
    {
        pizza.Topping = "Pepperoni+Jalapenos";
    }
}