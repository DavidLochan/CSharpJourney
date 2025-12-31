using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Aggregation
{
    public class CountSumAverage
    {
        public static void Run()
        {
            List<int> expenses = new List<int>
            {
                60,   // samosa + chai
                120,  // thali
                80,   // ice cream
                150,  // biryani
                40    // coffee
            };

            int totalItems = expenses.Count();
            int totalSpent = expenses.Sum();
            double averageSpent = expenses.Average();
            int maxSpent = expenses.Max();
            int minSpent = expenses.Min();

            Console.WriteLine("Canteen Expense Summary");
            Console.WriteLine($"Total items bought: {totalItems}");
            Console.WriteLine($"Total money spent: ₹{totalSpent}");
            Console.WriteLine($"Average spending: ₹{averageSpent}");
            Console.WriteLine($"Highest bill: ₹{maxSpent}");
            Console.WriteLine($"Lowest bill: ₹{minSpent}");
        }
    }
}