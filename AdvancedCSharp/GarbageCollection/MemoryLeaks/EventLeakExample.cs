using System;

namespace GarbageCollection.MemoryLeaks
{
    // Publisher
    class DoorBell
    {
        public event EventHandler BellRang;

        public void PressBell()
        {
            Console.WriteLine("Doorbell rang");
            BellRang?.Invoke(this, EventArgs.Empty);
        }
    }

    // Subscriber
    class Neighbor
    {
        private string name;

        public Neighbor(string name)
        {
            this.name = name;
        }

        public void HeardBell(object sender, EventArgs e)
        {
            Console.WriteLine($"{name}: I heard the bell!");
        }
    }
}