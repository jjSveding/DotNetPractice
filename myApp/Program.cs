﻿using System;

namespace myApp
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Flemming!");
            Program program = new Program();

            Console.WriteLine("Enter the first number:");
            String input1 = Console.ReadLine();
            Console.WriteLine("Enter your second number:");
            String input2 = Console.ReadLine();

            int result = program.add(int.Parse(input1), int.Parse(input2));
            Console.WriteLine("The result is: " + result);
            // Console.WriteLine("The current time is " + DateTime.Now);
            // Console.ReadLine();
        }



        void print(int i)
        {
            Console.WriteLine(i);
        }

        public int add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
