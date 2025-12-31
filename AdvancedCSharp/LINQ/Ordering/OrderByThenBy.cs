using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Ordering
{
    public class OrderByThenByExample
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new Student { Name = "David", Year = 3 },
                new Student { Name = "Arnold", Year = 2 },
                new Student { Name = "Pintu", Year = 3 },
                new Student { Name = "Borad", Year = 1 },
                new Student { Name = "Naresh", Year = 2 }
            };

            // Order by Year, then by Name
            var orderedStudents = students
                .OrderBy(s => s.Year)
                .ThenBy(s => s.Name);

            Console.WriteLine("Students ordered by Year, then Name:\n");

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.Name} - Year {student.Year}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
}