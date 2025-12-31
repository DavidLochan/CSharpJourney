using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.MorePractice
{
    public class CanteenOrders
    {
        public string Item { get; set; }
        public int Price { get; set; }

        public static void Run()
        {
            var orders = new List<CanteenOrders>
            {
                new CanteenOrders { Item = "Thali", Price = 60 },
                new CanteenOrders { Item = "Biryani", Price = 120 },
                new CanteenOrders { Item = "Samosa", Price = 20 },
                new CanteenOrders { Item = "Thali", Price = 60 },
                new CanteenOrders { Item = "Coffee", Price = 30 },
                new CanteenOrders { Item = "Samosa", Price = 20 }
            };

            // Total amount spent
            int total = orders.Sum(o => o.Price);
            Console.WriteLine($"Total Bill: ₹{total}");

            //  Most ordered item
            var mostOrdered = orders
                .GroupBy(o => o.Item)
                .OrderByDescending(g => g.Count())
                .First();

            Console.WriteLine($"Most Ordered Item: {mostOrdered.Key}");

            // Count per item
            Console.WriteLine("\nOrders Count:");
            foreach (var g in orders.GroupBy(o => o.Item))
                Console.WriteLine($"{g.Key} → {g.Count()} times");
        }
    }
}