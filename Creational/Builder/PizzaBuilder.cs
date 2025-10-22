using Builder;

namespace Builder;

// Abstract Builder
public abstract class PizzaBuilder
{
    protected Pizza pizza = null!; // Using null-forgiving operator to handle non-null warning

    public void CreateNewPizza()
    {
        pizza = new Pizza();
    }

    public Pizza GetPizza()
    {
        return pizza;
    }

    public abstract void BuildDough();
    public abstract void BuildSauce();
    public abstract void BuildTopping();
}