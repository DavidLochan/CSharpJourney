using System;

namespace Delegates
{
    public class ActionDelegate
    {
        public static void Run()
        {
            Action<string> print = name =>
            {
                Console.WriteLine("Hello " + name);
            };

            print("David");
        }
    }
}