using System;

namespace AnonymousMethods
{
    // Step 1: Define a delegate
    public delegate void MessagePrinter(string message);

    public class SimpleAnonymous
    {
        public static void Run()
        {
            // Step 2: Assign an anonymous method to the delegate
            MessagePrinter printer = delegate (string msg)
            {
                Console.WriteLine("Anonymous says: " + msg);
            };

            // Step 3: Call the delegate
            printer("Hello David");
        }
    }
}