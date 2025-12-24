using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("🏫 College canteen opened...\n");

        List<Task> orders = new List<Task>
        {
            ServeStudentAsync("Arnold", "Thali", 3000),
            ServeStudentAsync("Pintu", "Biryani", 2000),
            ServeStudentAsync("Trisha", "Samosa & Tea", 1000),
            ServeStudentAsync("David", "Coffee", 1500)
        };

        await Task.WhenAll(orders);

        Console.WriteLine("\nAll students served. Canteen closed.");
    }

    static async Task ServeStudentAsync(string name, string food, int time)
    {
        Console.WriteLine($"Order received from {name} for {food}");
        await Task.Delay(time);
        Console.WriteLine($"{food} served to {name}");
    }
}