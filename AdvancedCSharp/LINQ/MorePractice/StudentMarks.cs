using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.MorePractice
{
    public class StudentMarks
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }

        public static void Run()
        {
            var students = new List<StudentMarks>
            {
                new StudentMarks { Name = "David", Subject = "Maths", Marks = 85 },
                new StudentMarks { Name = "Arnold", Subject = "Maths", Marks = 92 },
                new StudentMarks { Name = "Pintu", Subject = "Maths", Marks = 45 },
                new StudentMarks { Name = "David", Subject = "Physics", Marks = 78 },
                new StudentMarks { Name = "Arnold", Subject = "Physics", Marks = 88 },
                new StudentMarks { Name = "Pintu", Subject = "Physics", Marks = 35 }
            };

            // Passed students (>= 50)
            var passed = students.Where(s => s.Marks >= 50);
            Console.WriteLine("Passed Students:");
            foreach (var s in passed)
                Console.WriteLine($"{s.Name} - {s.Subject} - {s.Marks}");

            // Toppers (Marks > 80)
            var toppers = students.Where(s => s.Marks > 80);
            Console.WriteLine("\nToppers:");
            foreach (var s in toppers)
                Console.WriteLine($"{s.Name} - {s.Subject} - {s.Marks}");

            // Average marks per subject
            var avgBySubject = students
                .GroupBy(s => s.Subject)
                .Select(g => new
                {
                    Subject = g.Key,
                    Average = g.Average(x => x.Marks)
                });

            Console.WriteLine("\nAverage Marks:");
            foreach (var a in avgBySubject)
                Console.WriteLine($"{a.Subject} → {a.Average}");
        }
    }
}