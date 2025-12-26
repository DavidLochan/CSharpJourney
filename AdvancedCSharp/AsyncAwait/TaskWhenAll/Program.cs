using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Canteen opened");

        Task tea = MakeTea();
        Task coffee = MakeCoffee();
        Task sandwich = MakeSandwich();

        await Task.WhenAll(tea, coffee, sandwich);

        Console.WriteLine("All orders served");
    }

    static async Task MakeTea()
    {
        await Task.Delay(2000);
        Console.WriteLine("Tea ready");
    }

    static async Task MakeCoffee()
    {
        await Task.Delay(3000);
        Console.WriteLine("Coffee ready");
    }

    static async Task MakeSandwich()
    {
        await Task.Delay(2500);
        Console.WriteLine("Sandwich ready");
    }
}