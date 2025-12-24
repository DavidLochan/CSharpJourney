using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class NotesDownloader
    {
        public async Task DownloadNotesAsync()
        {
            Console.WriteLine("Downloading notes...");
            await Task.Delay(2000);
            Console.WriteLine("Notes downloaded successfully!");
        }
    }
}