using System;

namespace TestArray
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int num;
            string quit;
            int i;
            int j;
            int y;
            int x;
            char[,] array;

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
                Console.WriteLine("Continue? (y/n)");
                quit = Console.ReadLine();
            } while (quit == "y");
        }
    }
}