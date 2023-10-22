using CoffeeMachine.Enteties;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cup cup = new Cup();

            cup.AddCoffee();
            cup.Stir();

            cup.AddWater();
            cup.Stir();

            cup.AddMilk();
            cup.Stir();

            cup.AddSugar();
            cup.Stir();

            Console.WriteLine("Coffee is ready!");
        }
    }
}