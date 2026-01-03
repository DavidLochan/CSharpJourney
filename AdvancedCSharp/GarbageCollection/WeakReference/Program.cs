using System;
using GarbageCollection.WeakReferenceDemo;

class Program
{
    static void Main()
    {
        WeakReference<Student> weakRef = CreateStudent();

        Console.WriteLine("Forcing GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        if (weakRef.TryGetTarget(out Student student))
        {
            Console.WriteLine($"Student still alive: {student.Name}");
        }
        else
        {
            Console.WriteLine("Student object already collected by GC");
        }
    }

    static WeakReference<Student> CreateStudent()
    {
        Student s = new Student("David");
        return new WeakReference<Student>(s);
    }
}