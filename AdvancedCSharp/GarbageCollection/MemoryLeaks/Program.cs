using System;
using GarbageCollection.MemoryLeaks;

class Program
{
    static void Main()
    {
        DoorBell bell = new DoorBell();

        CreateNeighbor(bell);

        Console.WriteLine("Forcing GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        bell.PressBell(); // ⚠️ Still responding → leak
    }

    static void CreateNeighbor(DoorBell bell)
    {
        Neighbor n = new Neighbor("Gwjwn");
        bell.BellRang += n.HeardBell;

        // n goes out of scope BUT event keeps it alive
    }
}