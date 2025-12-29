using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Calculating bill...\n");

        Task<int> billTask = Task.Run(() => CalculateBill());

        Console.WriteLine("Customer waiting...");
        int total = await billTask;

        Console.WriteLine($"Total bill: ₹{total}");
    }

    static int CalculateBill()
    {
        Thread.Sleep(2000);
        return 150;
    }
}