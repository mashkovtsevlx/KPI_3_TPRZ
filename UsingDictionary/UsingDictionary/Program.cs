using System;
using System.Collections;
using System.Collections.Generic;

namespace UsingDictionary
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int num;
			string key;
			string quit;
			do
			{
				Console.Clear();
				Dictionary<string, int> numbers = new Dictionary<string, int>();
				numbers.Add("one", 1);
				numbers.Add("two", 2);
				numbers.Add("three", 3);
				numbers.Add("four", 4);
				numbers.Add("five", 5);
				numbers.Add("six", 6);
				numbers.Add("seven", 7);
				numbers.Add("eight", 8);
				numbers.Add("nine", 9);
				numbers.Add("zero", 0);
				Console.WriteLine("Enter a number (example: one): ");
				key = Console.ReadLine();
				numbers.TryGetValue(key, out num);
				if (numbers.ContainsKey(key))
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Your number: {0}", num);
					Console.ResetColor();
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Your number does not exist");
					Console.ResetColor();
				}
				Console.WriteLine("Continue? (Any key/n)");
				quit = Console.ReadLine();
			} while (quit != "n");
			Console.WriteLine("Hello World!");
		}
	}
}