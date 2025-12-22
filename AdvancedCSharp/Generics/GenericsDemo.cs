using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    public class GenericsExample
    {
        public static void Run()
        {
            // Generic List of integers
            List<int> marks = new List<int>();
            marks.Add(85);
            marks.Add(90);
            marks.Add(78);

            Console.WriteLine("Student Marks:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            // Generic List of strings
            List<string> subjects = new List<string>();
            subjects.Add("Maths");
            subjects.Add("Physics");
            subjects.Add("Chemistry");

            Console.WriteLine("\nSubjects:");
            foreach (string subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}