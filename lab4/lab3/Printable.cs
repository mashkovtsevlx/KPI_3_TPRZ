using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class Printable
	{
		private string publisher;
		private string first_published;//YYYY
		private string name;
		private string author;
		public Printable()
		{
			Console.WriteLine("Enter publisher: ");
			publisher = Console.ReadLine();
			Console.WriteLine("Enter first published year: ");
			first_published = Console.ReadLine();
			Console.WriteLine("Enter name: ");
			name = Console.ReadLine();
			Console.WriteLine("Enter author: ");
			author = Console.ReadLine();
		}
		public void prnt_info(string type)
		{
			Console.WriteLine("{0} {1} published by {2} in {3}. Author - {4}", type, name, publisher, first_published, author);
		}
	}
}
