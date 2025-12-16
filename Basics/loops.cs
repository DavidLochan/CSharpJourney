namespace Basics;
public class LoopsDemo
{
    public static void Run()
    {
        Console.WriteLine("For loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("While loop:");
        int count = 1;
        while (count <= 3)
        {
            Console.WriteLine(count);
            count++;
        }
    }
}
