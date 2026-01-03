using System;

namespace GarbageCollection.Basics
{
    class TemporaryObject
    {
        public TemporaryObject()
        {
            Console.WriteLine("Temporary object created");
        }

        ~TemporaryObject()
        {
            Console.WriteLine("Temporary object finalized (cleaned)");
        }
    }

    class GCCollectDemo
    {
        public static void Run()
        {
            Console.WriteLine("Creating object...");
            CreateObject();

            Console.WriteLine("\nForcing Garbage Collection...");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("GC finished\n");
        }

        static void CreateObject()
        {
            TemporaryObject obj = new TemporaryObject();
        }
    }
}