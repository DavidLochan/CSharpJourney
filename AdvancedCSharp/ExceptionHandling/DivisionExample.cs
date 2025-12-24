using System;

namespace ExceptionHandling
{
    public class DivisionExample
    {
        public static void Run()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("❌ You cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Please enter valid numbers.");
            }
            finally
            {
                Console.WriteLine("✔ Division attempt finished.");
            }
        }
    }
}