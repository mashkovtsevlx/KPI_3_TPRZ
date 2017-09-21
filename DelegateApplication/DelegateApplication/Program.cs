using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApplication
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4, 9 };
			Array.ForEach<int>(arr, WriteMe);
			Console.WriteLine();
			Array.ForEach<int>(Array.FindAll<int>(arr, condition), WriteMe);
			Console.ReadLine();
		}

		private static void WriteMe(int val)
		{
			Console.WriteLine(val);
		}

		private static bool condition(int i)
		{
			return i % 2 == 0;
		}
	}
}