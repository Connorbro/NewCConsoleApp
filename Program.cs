﻿using System;

namespace ConsoleDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello there {name} ");

            Console.Write($"Now enter your age: ");
            var age = Console.ReadLine();
            Console.WriteLine($"Okay so your {age}");

            Console.Write($"Please {name}, enter a number:  ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your number total is {num1 + num2}");

            Console.WriteLine("Well that was fun!");

            




        }
    }
}
