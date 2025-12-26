using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int bill = await CalculateBill();
        Console.WriteLine($"Total bill: ₹{bill}");
    }

    static async Task<int> CalculateBill()
    {
        await Task.Delay(2000);
        return 120;
    }
}