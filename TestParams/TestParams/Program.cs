using System;

namespace TestParams
{
    internal class Program
    {
        private static int arr_sum(ref int[] array, int size)
        {
            int i;
            int sum;

            sum = 0;
            i = 0;
            while (i < size)
            {
                sum += array[i];
                i++;
            }
            return (sum);
        }

        private static void Main(string[] args)
        {
            int size;
            int[] array;
            int i;
            string quit;
            do
            {
                i = 0;
                Console.WriteLine("Hello World!");
                try
                {
                    Console.WriteLine("Enter array size: ");
                    size = Convert.ToInt32(Console.ReadLine());
                    array = new int[size];
                    while (i < size)
                    {
                        Console.WriteLine("Enter {0} element: ", i + 1);
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }
                    Console.WriteLine("Array sum = {0}", arr_sum(ref array, size));
                }
                catch (System.FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bad Input");
                }
                Console.WriteLine("Continue? (y/n)");
                Console.ResetColor();
                quit = Console.ReadLine();
            } while (quit == "y");
        }
    }
}