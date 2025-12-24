using System;

namespace GenericsAdvanced
{
    public class GenericCalculator
    {
        public static T PrintValue<T>(T value)
        {
            Console.WriteLine($"Value is: {value}");
            return value;
        }
    }
}