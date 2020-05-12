using System;

namespace ConsoleDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Im 21 years old";

            Console.WriteLine(phrase.Substring(8, 3));

            Console.ReadLine();
        }
    }
}
