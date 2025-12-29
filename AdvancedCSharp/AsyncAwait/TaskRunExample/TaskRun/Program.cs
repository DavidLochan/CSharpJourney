using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Canteen opened...\n");

        Task cookingTask = Task.Run(() => CookFood());

        Console.WriteLine("Serving students...");
        Console.WriteLine("Serving student 1");
        Console.WriteLine("Serving student 2");

        await cookingTask; // wait for cooking to finish

        Console.WriteLine("\nFood is ready, canteen closed.");
    }

    static void CookFood()
    {
        Console.WriteLine("Cooking food in background...");
        Thread.Sleep(3000);
        Console.WriteLine("Food cooked!");
    }
}