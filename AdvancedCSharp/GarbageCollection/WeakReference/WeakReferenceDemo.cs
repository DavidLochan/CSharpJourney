using System;

namespace GarbageCollection.WeakReferenceDemo
{
    class Student
    {
        public string Name { get; }

        public Student(string name)
        {
            Name = name;
            Console.WriteLine($"{Name} created");
        }

        ~Student()
        {
            Console.WriteLine($"{Name} finalized (GC cleaned)");
        }
    }
}