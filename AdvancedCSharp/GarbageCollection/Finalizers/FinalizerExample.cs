using System;

namespace GarbageCollection.Finalizers
{
    class FileResource
    {
        public FileResource()
        {
            Console.WriteLine("File opened");
        }

        ~FileResource()
        {
            Console.WriteLine("File cleaned by finalizer");
        }
    }

    class FinalizerExample
    {
        public static void Run()
        {
            Console.WriteLine("Starting Finalizer Example");

            CreateFile();

            Console.WriteLine("Forcing GC...");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Finalizer Example finished\n");
        }

        static void CreateFile()
        {
            FileResource file = new FileResource();
        }
    }
}