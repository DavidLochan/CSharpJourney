using System;

namespace OOPBasics
{
    public class Student : Person, IStudy
    {
        public int RollNumber { get; set; }

        public Student(string name, int age, int rollNumber)
            : base(name, age)
        {
            RollNumber = rollNumber;
        }
        public override void Introduce()
{
    Console.WriteLine(
        $"Hi, my name is {Name}, I am {Age} years old, and my roll number is {RollNumber}."
    );
}


        public void Study()
        {
            Console.WriteLine($"{Name} is studying. Roll No: {RollNumber}");
        }
    }
}
