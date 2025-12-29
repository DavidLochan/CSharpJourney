using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Canteen started...\n");

        Task task1 = Task.Run(() => ServeFood("Worker 1", "Thali"));
        Task task2 = Task.Run(() => ServeFood("Worker 2", "Biryani"));
        Task task3 = Task.Run(() => ServeFood("Worker 3", "Samosa"));

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("\nAll students served. Canteen closing.");
    }

    static void ServeFood(string worker, string food)
    {
        Console.WriteLine($"{worker} started serving {food}");
        Task.Delay(2000).Wait();   // simulate work
        Console.WriteLine($"{worker} finished serving {food}");
    }
}