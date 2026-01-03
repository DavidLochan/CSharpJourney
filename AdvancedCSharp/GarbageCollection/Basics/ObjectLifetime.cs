using System;

namespace GarbageCollection.Basics
{
    class Student
    {
        public string Name { get; }

        public Student(string name)
        {
            Name = name;
            Console.WriteLine($"Student object created: {Name}");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying");
        }
    }

    class ObjectLifetime
    {
        public static void Run()
        {
            Console.WriteLine("Class started\n");

            Student s1 = new Student("David");
            s1.Study();

            Console.WriteLine("\nStudent goes out of scope...");
        }
    }
}