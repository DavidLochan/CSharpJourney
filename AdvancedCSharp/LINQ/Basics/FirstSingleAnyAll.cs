using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Basics
{
    public class FirstSingleAnyAll
    {
        public static void Run()
        {
            List<int> marks = new List<int> { 45, 60, 75, 90 };

            // FIRST
            int firstPass = marks.First(m => m >= 50);
            Console.WriteLine($"First student who passed: {firstPass}");

            // FIRST OR DEFAULT
            int firstTopper = marks.FirstOrDefault(m => m > 95);
            Console.WriteLine($"First topper (or default): {firstTopper}");

            // ANY
            bool anyoneFailed = marks.Any(m => m < 50);
            Console.WriteLine($"Anyone failed? {anyoneFailed}");

            // ALL
            bool allPassed = marks.All(m => m >= 40);
            Console.WriteLine($"All students passed? {allPassed}");

            // SINGLE
            List<int> rollNumbers = new List<int> { 101 };
            int singleRoll = rollNumbers.Single();
            Console.WriteLine($"Single roll number: {singleRoll}");

            // SINGLE OR DEFAULT
            List<int> emptyList = new List<int>();
            int singleOrDefault = emptyList.SingleOrDefault();
            Console.WriteLine($"Single or default value: {singleOrDefault}");
        }
    }
}