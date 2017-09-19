using System;

namespace Cramer
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int i;
			float[] fr;
			float[] a;
			float[] b;
			float[] c;
			string quit;
			float d;
			float d1;
			float d2;
			float d3;
			float x1;
			float x2;
			float x3;

			i = 1;
			fr = new float[4];
			a = new float[4];
			b = new float[4];
			c = new float[4];
			ref float[] equa = ref fr;

			do
			{
				try
				{
					i = 1;
					while (i < 4)
					{
						Console.WriteLine("Equation {0}:", i);
						switch (i)
						{
							case 1:
								equa = a;
								break;

							case 2:
								equa = b;
								break;

							case 3:
								equa = c;
								break;

							default:
								break;
						}
						Console.WriteLine("Enter 1-st parameter: ");
						equa[0] = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter 2-nd parameter: ");
						equa[1] = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter 3-rd parameter: ");
						equa[2] = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter result: ");
						equa[3] = Convert.ToInt32(Console.ReadLine());
						i++;
					}
					d = a[0] * b[1] * c[2] + a[1] * b[2] * c[0] + a[2] * b[0] * c[1] - a[2] * b[1] * c[0] - a[0] * b[2] * c[1] - a[1] * b[0] * c[2];
					d1 = a[3] * b[1] * c[2] + a[1] * b[2] * c[3] + a[2] * b[3] * c[1] - a[2] * b[1] * c[3] - a[3] * b[2] * c[1] - a[1] * b[3] * c[2];
					d2 = a[0] * b[3] * c[2] + a[3] * b[2] * c[0] + a[2] * b[0] * c[3] - a[2] * b[3] * c[0] - a[0] * b[2] * c[3] - a[3] * b[0] * c[2];
					d3 = a[0] * b[1] * c[3] + a[1] * b[3] * c[0] + a[3] * b[0] * c[1] - a[3] * b[1] * c[0] - a[0] * b[3] * c[1] - a[1] * b[0] * c[3];
					x1 = d1 / d;
					x2 = d2 / d;
					x3 = d3 / d;
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("x1 = {0}, x2 = {1}, x3 = {2}", x1, x2, x3);
					Console.ResetColor();
				}
				catch (System.FormatException e)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Bad input");
				}
				Console.WriteLine("Continue? (y/n)");
				Console.ResetColor();
				quit = Console.ReadLine();
			} while (quit == "y");
		}
	}
}