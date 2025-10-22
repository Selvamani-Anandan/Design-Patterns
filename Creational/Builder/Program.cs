namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Builder Pattern Demo: Pizza Restaurant\n");

        // Create director and builders
        Waiter waiter = new Waiter();
        HawaiianPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
        SpicyPizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();

        // Construct Hawaiian pizza
        waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
        waiter.ConstructPizza();
        Pizza hawaiianPizza = waiter.GetPizza();
        Console.WriteLine("Hawaiian Pizza:");
        hawaiianPizza.Show();

        Console.WriteLine();

        // Construct Spicy pizza
        waiter.SetPizzaBuilder(spicyPizzaBuilder);
        waiter.ConstructPizza();
        Pizza spicyPizza = waiter.GetPizza();
        Console.WriteLine("Spicy Pizza:");
        spicyPizza.Show();
    }
}