using System;
using System.Threading;

namespace MultithreadingDemo
{
    public class WorkerExample
    {
        public static void DoWork()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($" Worker thread working: {i}");
                Thread.Sleep(500); // pause for half a second
            }
        }
    }
}