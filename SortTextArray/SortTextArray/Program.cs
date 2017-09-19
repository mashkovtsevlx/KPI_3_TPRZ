using System;

namespace SortTextArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i;
            string quit;
            do
            {
                i = 0;
                string[] array = new string[3];
                Console.WriteLine("Enter first string: ");
                array[0] = Console.ReadLine();
                Console.WriteLine("Enter second string: ");
                array[1] = Console.ReadLine();
                Console.WriteLine("Enter third string: ");
                array[2] = Console.ReadLine();
                Array.Sort(array);
                Console.WriteLine("\nSorted array: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                while (i < 3)
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
                Console.ResetColor();
                Console.WriteLine("Continue? (y/n)");
                quit = Console.ReadLine();
            } while (quit == "y");
        }
    }
}