using System;
using System.Collections.Generic;

namespace CanteenTracker
{
    class Program
    {
        static void Main()
        {
            List<FoodItem> todaysFood = new List<FoodItem>();

            todaysFood.Add(new Thali());
            todaysFood.Add(new Snack("Samosa"));
            todaysFood.Add(new Snack("Chai"));
            todaysFood.Add(new Biryani());
            todaysFood.Add(new Snack("Ice Cream"));

            double total = 0;

            Console.WriteLine("Today's Canteen Expenses:\n");

            foreach (FoodItem item in todaysFood)
            {
                Console.WriteLine($"{item.Name} - ₹{item.GetPrice()}");
                total += item.GetPrice();
            }

            Console.WriteLine("\nTotal Spent: ₹" + total);
        }
    }
}