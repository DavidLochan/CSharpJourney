using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Washing plates using Parallel.For\n");

        Parallel.For(1, 6, plateNumber =>
        {
            Console.WriteLine($"Plate {plateNumber} washed by thread {Environment.CurrentManagedThreadId}");
        });

        Console.WriteLine("\nAll plates washed");
    }
}