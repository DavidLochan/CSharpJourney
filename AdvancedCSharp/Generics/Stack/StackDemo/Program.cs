using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main()
        {
            Stack<string> plates = new Stack<string>();

            plates.Push("Plate 1");
            plates.Push("Plate 2");
            plates.Push("Plate 3");

            Console.WriteLine("Removing plates:");

            while (plates.Count > 0)
            {
                string plate = plates.Pop();
                Console.WriteLine($"{plate} removed");
            }
        }
    }
}
