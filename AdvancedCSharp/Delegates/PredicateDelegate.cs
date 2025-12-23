using System;

namespace Delegates
{
    public class PredicateDelegate
    {
        public static void Run()
        {
            Predicate<int> isEven = number => number % 2 == 0;

            Console.WriteLine(isEven(10)); // true
            Console.WriteLine(isEven(7));  // false
        }
    }
}