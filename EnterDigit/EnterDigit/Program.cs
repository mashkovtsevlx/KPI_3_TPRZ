using System;

namespace EnterDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int j;
			int m;
			int mo;

			m = 0;
			mo = 0;
            j = 1;
			try
			{
				int i = Int32.Parse(s);
				int i2 = Convert.ToInt32(s);
				if (i >= -10 && i <= 10)
					Console.WriteLine("Good number");
				else
					Console.WriteLine("Bad number");
				Console.Write("Fibonacci:");
				if (i >= 1)
				{
					Console.Write(" 0 1");

					while (m + j <= i)
					{
						Console.Write(" {0}", m + j);
						mo = m;
						m = j;
						j = mo + j;
					}
				}
				Console.WriteLine("\ni={0} i2={1}", i, i2);
				switch (i)
				{
					case 7:
						Console.WriteLine("Lucky number");
						break;
					case 13:
						Console.WriteLine("Devil's number");
						break;
					default:
						Console.WriteLine("Regular number");
						break;
				}
			}
			catch(System.FormatException)
			{
				Console.WriteLine("Error");
			}
            Console.ReadLine();
        }
    }
}