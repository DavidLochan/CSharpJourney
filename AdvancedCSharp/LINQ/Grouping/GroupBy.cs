using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Grouping
{
    public class GroupByExample
    {
        public static void Run()
        {
            var orders = new List<Order>
            {
                new Order("David", "Thali"),
                new Order("Arnold", "Biryani"),
                new Order("Pintu", "Thali"),
                new Order("Naresh", "Snacks"),
                new Order("Borad", "Biryani")
            };

            var groupedOrders = orders.GroupBy(o => o.FoodItem);

            foreach (var group in groupedOrders)
            {
                Console.WriteLine($"\nFood Item: {group.Key}");

                foreach (var order in group)
                {
                    Console.WriteLine($" - {order.StudentName}");
                }
            }
        }
    }

    public class Order
    {
        public string StudentName { get; set; }
        public string FoodItem { get; set; }

        public Order(string studentName, string foodItem)
        {
            StudentName = studentName;
            FoodItem = foodItem;
        }
    }
}