using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  a queue of people in canteen
            Queue<string> canteenLine = new Queue<string>();

            // people joins the queue
            canteenLine.Enqueue("David");
            canteenLine.Enqueue("Arnold");
            canteenLine.Enqueue("Pintu");

            Console.WriteLine("Students in canteen line:");

            foreach (var student in canteenLine)
            {
                Console.WriteLine(student);
            }

            // First person gets food and leaves the line
            Console.WriteLine("\nServing: " + canteenLine.Dequeue());

            // Who is after him / next person
            Console.WriteLine("Next in line: " + canteenLine.Peek());

            Console.WriteLine("\nRemaining students in line:");
            foreach (var student in canteenLine)
            {
                Console.WriteLine(student);
            }
        }
    }
}