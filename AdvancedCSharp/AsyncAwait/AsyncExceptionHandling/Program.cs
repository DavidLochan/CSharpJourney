using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            await Task.WhenAll(
                ServeStudent("David"),
                ServeStudent("Arnold"),
                ServeStudent(null)
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static async Task ServeStudent(string? name)
    {
        await Task.Delay(1000);

        if (string.IsNullOrWhiteSpace(name))
            throw new Exception("Student name missing");

        Console.WriteLine($"Served {name}");
    }
}