using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class FoodOrder
    {
        public async Task PrepareFoodAsync()
        {
            Console.WriteLine("Order placed for Biryani...");
            
            // Simulate cooking time
            await Task.Delay(3000);

            Console.WriteLine("Biryani is ready!");
        }
    }
}