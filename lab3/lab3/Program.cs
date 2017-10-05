using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			Book book1 = new Book();
			book1.prnt_info("Book");
			Paper paper1 = new Paper();
			paper1.prnt_info("Paper");
			paper1.print_pp();
			Console.ReadKey();
		}
	}
}
