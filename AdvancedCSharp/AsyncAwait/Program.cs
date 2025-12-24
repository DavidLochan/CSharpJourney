using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main()
        {
            // Foodorder.cs
            // FoodOrder order = new FoodOrder();

            // Console.WriteLine("You are scrolling Instagram...");
            // await order.PrepareFoodAsync();
            // Console.WriteLine("Eating food now.");

// Notes Downloader
            NotesDownloader notes = new NotesDownloader();

            Console.WriteLine("Listening to music...");
            await notes.DownloadNotesAsync();
            Console.WriteLine("Start studying.");
        }
    }
}