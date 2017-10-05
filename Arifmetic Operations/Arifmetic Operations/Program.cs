using System;

namespace Arifmetic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            float i;
            float j;
            string z;
            string quit;

            i = 0;
            j = 0;
            do
            {
				try
				{
					Console.WriteLine("Type in operation from list: '+ - * / % ++ --'");
					z = Console.ReadLine();
					Console.WriteLine("Enter 1-st value (example: '3.5'): ");
					i = Convert.ToSingle(Console.ReadLine());
					if (z != "++" && z != "--")
					{
						Console.WriteLine("Enter 2-nd value (example: '4.8'): ");
						j = Convert.ToSingle(Console.ReadLine());
					}

					Console.Write("Result: ");
					switch (z)
					{
						case "+":
							Console.Write("{0}\n", i + j);
							break;
						case "-":
							Console.Write("{0}\n", i - j);
							break;
						case "*":
							Console.Write("{0}\n", i * j);
							break;
						case "/":
							Console.Write("{0}\n", i / j);
							break;
						case "%":
							Console.Write("{0}\n", i % j);
							break;
						case "++":
							Console.Write("{0}\n", ++i);
							break;
						case "--":
							Console.Write("{0}\n", --i);
							break;
					}
				}
				catch(System.FormatException)
				{
					Console.WriteLine("Bad number");
				}
                Console.WriteLine("Wish you like to continue? (yes/no)");
                quit = Console.ReadLine();
            } while (quit == "yes");
        }
    }
}