using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Canteen opened...\n");

        Task<string> student1 = ServeStudentAsync("Pintu", 3000);
        Task<string> student2 = ServeStudentAsync("Arnold", 1000);
        Task<string> student3 = ServeStudentAsync("David", 2000);

        Task<string> firstServed = await Task.WhenAny(student1, student2, student3);

        Console.WriteLine($"\nFirst student served: {await firstServed}");
    }

    static async Task<string> ServeStudentAsync(string name, int time)
    {
        await Task.Delay(time);
        Console.WriteLine($"Served {name}");
        return name;
    }
}