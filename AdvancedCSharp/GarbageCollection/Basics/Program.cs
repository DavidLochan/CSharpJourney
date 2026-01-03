using GarbageCollection.Basics;

class Program
{
    static void Main()
    {
        ObjectLifetime.Run();

        Console.WriteLine("\n-----------------\n");

        GCCollectDemo.Run();
    }
}