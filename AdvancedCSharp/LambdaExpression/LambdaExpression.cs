using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    public class LambdaExpression
    {
        public static void Run()
        {
            List<int> marks = new List<int> { 35, 72, 90, 28, 65 };

            // Lambda to check pass condition
            Predicate<int> isPass = mark => mark >= 40;

            Console.WriteLine("Pass / Fail Result:");
            foreach (int mark in marks)
            {
                Console.WriteLine($"{mark} : {(isPass(mark) ? "Pass" : "Fail")}");
            }
        }
    }
}