using System;

public class DoorBell
{
    public event EventHandler? BellRang;

    public void PressBell()
    {
        Console.WriteLine("🔔 Doorbell pressed");
        BellRang?.Invoke(this, EventArgs.Empty);
    }
}