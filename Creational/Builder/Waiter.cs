namespace Builder;

// Director
public class Waiter
{
    private PizzaBuilder? pizzaBuilder;

    public void SetPizzaBuilder(PizzaBuilder pb)
    {
        pizzaBuilder = pb;
    }

    public Pizza GetPizza()
    {
        return pizzaBuilder?.GetPizza() ?? throw new InvalidOperationException("No pizza builder set");
    }

    public void ConstructPizza()
    {
        pizzaBuilder?.CreateNewPizza();
        pizzaBuilder?.BuildDough();
        pizzaBuilder?.BuildSauce();
        pizzaBuilder?.BuildTopping();
    }
}