class Program
{
    static void Main()
    {
        DoorBell doorBell = new DoorBell();

        doorBell.BellRang += Family.MomHeard;
        doorBell.BellRang += Family.DadHeard;

        doorBell.PressBell();
    }
}