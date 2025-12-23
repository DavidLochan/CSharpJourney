using System;

namespace Delegates
{
    // Step 1: Declare delegate
    public delegate void Notify(string message);

    public class BasicDelegate
    {
        // Step 2: Method matching delegate signature
        static void ShowMessage(string msg)
        {
            Console.WriteLine("Message: " + msg);
        }

        public static void Run()
        {
            // Step 3: Assign method to delegate
            Notify notify = ShowMessage;

            // Step 4: Invoke delegate
            notify("Hello from Basic Delegate");
        }
    }
}