using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main()
        {
            // Dictionary<KEY, VALUE>
            Dictionary<string, int> canteenMenu = new Dictionary<string, int>();

            // Adding items
            canteenMenu.Add("Thali", 70);
            canteenMenu.Add("Chicken Biryani", 120);
            canteenMenu.Add("Samosa", 20);
            canteenMenu.Add("Chai", 20);
            canteenMenu.Add("Ice Cream", 20);

            Console.WriteLine("Canteen Menu:\n");

            // Reading dictionary
            foreach (var item in canteenMenu)
            {
                Console.WriteLine($"{item.Key} - ₹{item.Value}");
            }

            // Accessing a single value
            Console.WriteLine("\nPrice of Chicken Biryani:");
            Console.WriteLine($"₹{canteenMenu["Chicken Biryani"]}");
        }
    }
}