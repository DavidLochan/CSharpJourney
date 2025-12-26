
// Wrong Code Intentionally

// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static int totalMoney = 0;

//     static async Task Main()
//     {
//         Console.WriteLine("Canteen opened...\n");

//         Task t1 = TakePaymentAsync("Student A", 50);
//         Task t2 = TakePaymentAsync("Student B", 50);

//         await Task.WhenAll(t1, t2);

//         Console.WriteLine($"\nTotal money in counter: ₹{totalMoney}");
//     }

//     static async Task TakePaymentAsync(string student, int amount)
//     {
//         int current = totalMoney;     // Read
//         await Task.Delay(1000);       // Context switch
//         totalMoney = current + amount; // Write

//         Console.WriteLine($"{student} paid ₹{amount}");
//     }
// }

// Correct Version

using System;
using System.Threading.Tasks;

class Program
{
    static int totalMoney = 0;
    static readonly object locker = new object();

    static async Task Main()
    {
        Console.WriteLine("Canteen opened...\n");

        Task t1 = TakePaymentAsync("Student A", 50);
        Task t2 = TakePaymentAsync("Student B", 50);

        await Task.WhenAll(t1, t2);

        Console.WriteLine($"\nTotal money in counter: ₹{totalMoney}");
    }

    static async Task TakePaymentAsync(string student, int amount)
    {
        await Task.Delay(1000);

        lock (locker)
        {
            totalMoney += amount;
        }

        Console.WriteLine($"{student} paid ₹{amount}");
    }
}