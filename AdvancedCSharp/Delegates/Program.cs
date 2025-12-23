using System;

namespace Delegates
{
    class Program
    {
        static void Main()
        {
            BasicDelegate.Run();
            ActionDelegate.Run();
            FuncDelegate.Run();
            PredicateDelegate.Run();
        }
    }
}