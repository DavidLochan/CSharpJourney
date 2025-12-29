using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim toilet = new SemaphoreSlim(2); // only 2 allowed

    static async Task Main()
    {
        Console.WriteLine("Toilet opened\n");

        Task[] people =
        {
            UseToilet("David"),
            UseToilet("Arnold"),
            UseToilet("Pintu"),
            UseToilet("Naresh"),
            UseToilet("Borad")
        };

        await Task.WhenAll(people);

        Console.WriteLine("\nEveryone is done");
    }

    static async Task UseToilet(string name)
    {
        await toilet.WaitAsync(); // wait for permission

        Console.WriteLine($"{name} entered toilet");
        await Task.Delay(2000);   // using toilet
        Console.WriteLine($"{name} exited toilet");

        toilet.Release(); // allow next person
    }
}