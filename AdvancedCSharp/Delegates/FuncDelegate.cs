using System;

namespace Delegates
{
    public class FuncDelegate
    {
        public static void Run()
        {
            Func<int, int, int> add = (a, b) => a + b;

            int result = add(10, 20);
            Console.WriteLine("Sum: " + result);
        }
    }
}