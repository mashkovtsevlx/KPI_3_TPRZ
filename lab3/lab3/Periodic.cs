using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class Periodic : Printable
	{
		private string publishing_period; //Example: "Every month"
		public Periodic() : base()
		{
			Console.WriteLine("Enter publishing period (Examp: 'Every month'): ");
			publishing_period = Console.ReadLine();
		}
		public void print_pp()
		{
			Console.WriteLine("Publishing {0}", publishing_period);
		}
	}
}
