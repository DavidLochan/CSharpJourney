using System;

namespace OOPBasics
{
    class Program
    {
        static void Main()
        {
            Person p1 = new Person("David", 22);
            p1.Introduce();

            Student s1 = new Student("David", 22, 202201132);
            s1.Introduce();   // inherited method
            s1.Study();       // student-specific
        }
    }
}
