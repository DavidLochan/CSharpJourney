using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Basics
{
    public class WhereSelect
    {
        public static void Run()
        {
            List<int> marks = new List<int> { 45, 67, 89, 30, 92, 55 };

            Console.WriteLine("Original Marks:");
            marks.ForEach(m => Console.WriteLine(m));

            // WHERE → filter
            var passedStudents = marks.Where(m => m >= 60);

            // SELECT → transform
            var grades = passedStudents.Select(m => m + 5);

            Console.WriteLine("\nPassed students with grace marks:");
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}