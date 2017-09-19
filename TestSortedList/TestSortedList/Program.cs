using System;
using System.Collections;
using System.Collections.Generic;

namespace TestSortedList
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string quit;
			do
			{
				SortedList<string, string> list = new SortedList<string, string>();
				string addmore;
				string value;
				string getmore;
				do
				{
					string key;
					Console.WriteLine("Enter a key: ");
					key = Console.ReadLine();
					Console.WriteLine("Enter a value: ");
					list.Add(key, Console.ReadLine());
					Console.WriteLine("Add more? (Any key/n)");
					addmore = Console.ReadLine();
				} while (addmore != "n");
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("Done.");
				Console.ResetColor();
				do
				{
					Console.WriteLine("Enter a key of the object: ");
					list.TryGetValue(Console.ReadLine(), out value);
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Object value: {0}", value);
					Console.ResetColor();
					Console.WriteLine("Get one more? (Any key/n)");
					getmore = Console.ReadLine();
				} while (getmore != "n");
				Console.WriteLine("New List? (Any key/n)");
				quit = Console.ReadLine();
			} while (quit != "n");
			Console.WriteLine("Hello World!");
		}
	}
}