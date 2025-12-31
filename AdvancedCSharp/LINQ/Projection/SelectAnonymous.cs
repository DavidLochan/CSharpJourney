using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Projection
{
    public class SelectAnonymous
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new Student { Name = "David", Marks = 85, Course = "CSE" },
                new Student { Name = "Arnold", Marks = 92, Course = "IT" },
                new Student { Name = "Pintu", Marks = 70, Course = "ECE" }
            };

            //  Projection using Select
            var studentSummaries = students.Select(s => new
            {
                StudentName = s.Name,
                Result = s.Marks >= 80 ? "Pass" : "Fail"
            });

            Console.WriteLine("Student Result Summary:\n");

            foreach (var item in studentSummaries)
            {
                Console.WriteLine($"{item.StudentName} → {item.Result}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Course { get; set; }
    }
}