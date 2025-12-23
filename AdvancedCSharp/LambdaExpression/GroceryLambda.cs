using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    public class GroceryLambda
    {
        public static void Run()
        {
            List<int> prices = new List<int> { 40, 120, 75, 200, 90 };

            // Lambda to check if item is expensive
            Func<int, bool> isExpensive = price => price > 100;

            Console.WriteLine("Grocery Price Check:");

            foreach (int price in prices)
            {
                string result = isExpensive(price) ? "Expensive" : "Affordable";
                Console.WriteLine($"₹{price} → {result}");
            }
        }
    }
}