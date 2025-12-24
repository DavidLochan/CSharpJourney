using System;

namespace ExceptionHandling
{
    public class ATMExample
    {
        public static void Run()
        {
            int balance = 5000;

            try
            {
                Console.Write("Enter withdrawal amount: ");
                int amount = int.Parse(Console.ReadLine());

                if (amount > balance)
                {
                    throw new Exception("Insufficient balance.");
                }

                balance -= amount;
                Console.WriteLine($"✅ Withdrawal successful. Remaining balance: ₹{balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ATM Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("🏦 Thank you for using the ATM.");
            }
        }
    }
}