using System;

namespace CloneArray
{
    internal class Program
    {
        private static Random random = new Random();

        private static void Main(string[] args)
        {
            int num;
            string quit;
            int i;
            int j;
            int y;
            int x;
            char[,] array;
            char[,] array2;

            do
            {
                y = random.Next(1, 100); //rows
                x = random.Next(1, 100); //columns
                array = new char[y, x];
                i = 0;
                j = 0;
                while (i < y)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    j = 0;
                    while (j < x)
                    {
                        num = random.Next(0, 26);
                        array[i, j] = (char)('a' + num);
                        Console.Write(array[i, j]);
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                Console.ResetColor();
                Console.WriteLine("Array of chars: {0}*{1}", y, x);
                Console.WriteLine("{0} elements.", y * x);
                array2 = (char[,])array.Clone();
                y = array2.GetLength(0);
                x = array2.GetLength(1);
                i = 0;
                j = 0;
                Console.WriteLine("Copied array:");
                while (i < y)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    j = 0;
                    while (j < x)
                    {
                        Console.Write(array[i, j]);
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                Console.ResetColor();
                Console.WriteLine("Continue? (y/n)");

                quit = Console.ReadLine();
            } while (quit == "y");
        }
    }
}