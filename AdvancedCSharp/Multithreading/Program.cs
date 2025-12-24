using System;
using System.Threading;

namespace MultithreadingDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Main thread started");

            Thread workerThread = new Thread(WorkerExample.DoWork);
            workerThread.Start(); // start new thread

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($" Main thread working: {i}");
                Thread.Sleep(500);
            }

            workerThread.Join(); // wait for worker to finish

            Console.WriteLine(" All work finished");
        }
    }
}