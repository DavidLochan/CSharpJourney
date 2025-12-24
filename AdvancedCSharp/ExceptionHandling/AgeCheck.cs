using System;

namespace ExceptionHandling
{
    public class AgeCheck
    {
        public static void Run()
        {
            try
            {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    throw new AgeNotValidException("You must be at least 18 years old.");
                }

                Console.WriteLine("✅ Access granted.");
            }
            catch (AgeNotValidException ex)
            {
                Console.WriteLine($"❌ {ex.Message}");
            }
        }
    }
}