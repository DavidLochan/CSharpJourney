using System;

namespace GenericsAdvanced
{
    class Program
    {
        static void Main()
        {
            var intBox = new GenericBox<int>();
            intBox.Value = 10;
            intBox.Show();

            var stringBox = new GenericBox<string>();
            stringBox.Value = "Apple";
            stringBox.Show();

            // GenericCalculator.cs
            GenericCalculator.PrintValue(100);
            GenericCalculator.PrintValue("David");
            GenericCalculator.PrintValue(true);

            // GenericRepository.cs
            var repo = new Repository<int, string>();
             repo.Save(1, "Student Record");


        }
    }
}