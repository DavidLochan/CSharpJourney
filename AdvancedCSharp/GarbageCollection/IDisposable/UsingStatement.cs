using System;

namespace GarbageCollection.IDisposableDemo
{
    class UsingStatement
    {
        public static void Run()
        {
            Console.WriteLine("Using statement started");

            using (FileResource file = new FileResource())
            {
                file.UseFile();
            } // Dispose() called automatically here

            Console.WriteLine("Using statement ended\n");
        }
    }
}