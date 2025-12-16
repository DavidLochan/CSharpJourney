using System;
using System.Collections.Generic;

namespace TodoConsole
{
    public class TodoDemo
    {
        public static void Run()
        {
            List<string> tasks = new List<string>();
            List<bool> completed = new List<bool>();

            tasks.Add("Dropped my brother at school");
            completed.Add(true);

            tasks.Add("Went to market for grocery shopping");
            completed.Add(true);

            tasks.Add("Visited grandma's home");
            completed.Add(true);

            tasks.Add("Picked my brother from school");
            completed.Add(true);

            tasks.Add("Went to the garden for sightseeing in the evening");
            completed.Add(false);

            Console.WriteLine("My Day Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = completed[i] ? "Done" : "Pending";
                Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
            }
        }
    }
}
