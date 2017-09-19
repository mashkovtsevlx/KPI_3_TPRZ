using System;
using System.Collections;
using System.Collections.Generic;

namespace TestStack
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string quit;
			do
			{
				Console.Clear();
				Stack<string> stack = new Stack<string>();
				string addmore;
				do
				{
					Console.WriteLine("Enter a value: ");
					stack.Push(Console.ReadLine());
					Console.WriteLine("Add more? (Any key/n)");
					addmore = Console.ReadLine();
				} while (addmore != "n");
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("Done.");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write("Your Stack:");
				while (true)
				{
					try
					{
						Console.Write(" {0}", stack.Pop());
					}
					catch (System.InvalidOperationException e)
					{
						break;
					}
				}
				Console.ResetColor();
				Console.WriteLine("\nNew Stack? (Any key/n)");
				quit = Console.ReadLine();
			} while (quit != "n");
			Console.WriteLine("Hello World!");
		}
	}
}