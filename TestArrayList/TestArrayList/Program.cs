using System;
using System.Collections;
using System.Collections.Generic;

namespace TestArrayList
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string addmore;
			string quit;
			do
			{
				Console.Clear();
				try
				{
					List<int> list = new List<int>(); //ArrayList больше не поддерживается
					do
					{
						Console.WriteLine("Enter a number");
						list.Add(Convert.ToInt32(Console.ReadLine()));
						Console.WriteLine("Add more? (Any Key/n)");
						addmore = Console.ReadLine();
					} while (addmore != "n");
					IEnumerator enumerator = list.GetEnumerator();
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.Write("Your List: ");
					Console.ResetColor();
					while (enumerator.MoveNext())
					{
						Console.Write(" {0}", enumerator.Current);
					}
				}
				catch (System.FormatException e)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Bad Input");
				}
				Console.WriteLine("\nContinue? (Any Key/n)");
				Console.ResetColor();
				quit = Console.ReadLine();
			} while (quit != "n");
			Console.WriteLine("Hello World!");
		}
	}
}