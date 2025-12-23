using System;

public class Family
{
    public static void MomHeard(object? sender, EventArgs e)
    {
        Console.WriteLine("Mom: I heard the doorbell!");
    }

    public static void DadHeard(object? sender, EventArgs e)
    {
        Console.WriteLine("Dad: I heard the doorbell!");
    }
}