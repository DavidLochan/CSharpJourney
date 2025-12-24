using System;

namespace GenericsAdvanced
{
    public class GenericBox<T>
    {
        public T Value { get; set; }

        public void Show()
        {
            Console.WriteLine($"Box contains: {Value}");
        }
    }
}