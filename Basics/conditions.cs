namespace Basics;
public class ConditionsDemo
{
    public static void Run()
    {
        int marks = 75;

        if (marks >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else
        {
            Console.WriteLine("Grade: C");
        }
    }
}
