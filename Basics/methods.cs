namespace Basics;
public class MethodsDemo
{
    public static void Run()
    {
        Greet("David");
        int result = Add(5, 7);
        Console.WriteLine("Sum: " + result);
    }

    static void Greet(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
