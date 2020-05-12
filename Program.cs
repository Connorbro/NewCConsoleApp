using System;

namespace ConsoleDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine("Enter your name:");
            Console.ReadLine();

            Console.WriteLine($"Hello there {name} ");
        }
    }
}
