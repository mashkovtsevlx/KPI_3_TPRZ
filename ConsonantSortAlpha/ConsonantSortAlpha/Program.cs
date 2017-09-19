using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsonantSortAlpha
{
	internal class DescendCompare : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			int ascendingResult = Comparer<int>.Default.Compare(x, y);
			if (ascendingResult == 0)
				return -1;
			return 0 - ascendingResult;
		}
	}

	internal class Program
	{
		private static void Main(string[] args)
		{
			string quit;
			do
			{
				string input;
				string[] output;
				int length;
				int conson;
				char[] last;
				string result;

				SortedList<int, string> biggest = new SortedList<int, string>(new DescendCompare());

				Console.WriteLine("Enter your string: ");
				input = Console.ReadLine();
				output = input.Split(' ');
				length = output.Length;
				foreach (string s in output)
				{
					conson = 0;
					foreach (char c in s)
					{
						if ("aeiouAEIOU".IndexOf(c) < 0)
						{
							conson++;
						}
					}
					biggest.Add(conson, s);
				}
				last = biggest.Values[0].ToCharArray();
				Array.Sort(last);
				result = new string(last);
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("Your word: {0}", result);
				Console.ResetColor();
				Console.WriteLine("Continue? (Any key/n)");
				quit = Console.ReadLine();
			} while (quit != "n");
		}
	}
}