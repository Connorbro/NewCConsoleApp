using System;

namespace ConsoleDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Connor";
            var age = 21;
            string CodingLanguage = "C#";


            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"I love {CodingLanguage}");

            Console.ReadLine();
        }
    }
}
