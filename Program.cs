using System;

namespace ConsoleDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Connor";
            int age = 21;
            string CodingLanguage = "C#";
            char grade = 'A';


            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"I love {CodingLanguage}");
            Console.WriteLine($"My maths grade in school was an {grade}");
            Console.WriteLine($"Different types of decimal variables are...");
            Console.WriteLine($"float, double, decimal");
            Console.ReadLine();
        }
    }
}
