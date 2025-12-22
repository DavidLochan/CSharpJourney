using System;
using System.Collections.Generic;

namespace HashSetDemo
{
    class Program
    {
        static void Main()
        {
            // HashSet stores UNIQUE items only
            HashSet<string> foodsEaten = new HashSet<string>();

            foodsEaten.Add("Thali");
            foodsEaten.Add("Biryani");
            foodsEaten.Add("Samosa");
            foodsEaten.Add("Tea");
            foodsEaten.Add("Biryani"); // duplicate
            foodsEaten.Add("Tea");     // duplicate

            Console.WriteLine("Food items eaten today:");

            foreach (string food in foodsEaten)
            {
                Console.WriteLine(food);
            }
        }
    }
}