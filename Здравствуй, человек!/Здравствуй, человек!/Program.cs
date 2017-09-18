using System;

namespace Здравствуй__человек_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string test;
            do
            {
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();
                Console.WriteLine("Hello, {0}!", name);
                Console.WriteLine("Resume executing? (yes/no)");
                test = Console.ReadLine();
            } while (test == "yes");
        }
    }
}