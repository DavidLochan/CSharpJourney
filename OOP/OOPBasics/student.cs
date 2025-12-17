using System;

namespace OOPBasics
{
    public class Student : Person
    {
        public int RollNumber { get; set; }

        public Student(string name, int age, int rollNumber)
            : base(name, age)
        {
            RollNumber = rollNumber;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying. Roll No: {RollNumber}");
        }
    }
}
