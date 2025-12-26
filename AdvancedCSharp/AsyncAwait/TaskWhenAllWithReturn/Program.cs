using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Calculating bills...");

        Task<int> tea = TeaPrice();
        Task<int> coffee = CoffeePrice();
        Task<int> sandwich = SandwichPrice();

        int[] prices = await Task.WhenAll(tea, coffee, sandwich);

        int total = 0;
        foreach (int price in prices)
            total += price;

        Console.WriteLine($"💰 Total bill: ₹{total}");
    }

    static async Task<int> TeaPrice()
    {
        await Task.Delay(1000);
        return 20;
    }

    static async Task<int> CoffeePrice()
    {
        await Task.Delay(1500);
        return 40;
    }

    static async Task<int> SandwichPrice()
    {
        await Task.Delay(2000);
        return 60;
    }
}