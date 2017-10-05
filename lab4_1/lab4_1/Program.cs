using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Book book1 = new Book();
			book1.print_info();
			Paper paper1 = new Paper();
			paper1.print_info();
			Console.ReadKey();
		}

		private interface IReadPubPer
		{
			void read_pub_per();
		}

		private interface IReadAuthor
		{
			void read_author();
		}

		private interface IReadName
		{
			void read_name();
		}

		private interface IReadPubFirst
		{
			void read_pub_first();
		}

		private interface IReadPublisher
		{
			void read_publisher();
		}

		private interface IPrintInfo
		{
			void print_info();
		}

		public class Printable : IReadPubPer, IReadAuthor, IReadName, IReadPubFirst, IReadPublisher, IPrintInfo
		{
			public string publisher;
			public string first_published;//YYYY
			public string name;
			public string author;
			public string publishing_period;
			public string type;

			public Printable()
			{
				read_publisher();
				read_name();
				read_author();
				read_pub_first();
			}

			public virtual void read_publisher()
			{
				Console.WriteLine("Enter publisher: ");
				this.publisher = Console.ReadLine();
			}

			public virtual void read_pub_first()
			{
				Console.WriteLine("Enter first published year: ");
				this.first_published = Console.ReadLine();
			}

			public virtual void read_name()
			{
				Console.WriteLine("Enter name: ");
				this.name = Console.ReadLine();
			}

			public virtual void read_author()
			{
				Console.WriteLine("Enter author: ");
				this.author = Console.ReadLine();
			}

			public virtual void read_pub_per()
			{
				Console.WriteLine("Enter publishing period (Examp: 'Every month'): ");
				this.publishing_period = Console.ReadLine();
			}

			public virtual void print_info()
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("{0} {1} published by {2} in {3}. Author - {4}", this.type, this.name, this.publisher, this.first_published, this.author);
				Console.ResetColor();
			}
		}

		public class Book : Printable
		{
			public Book() : base()
			{
				this.type = "Book";
			}
		}

		private class Paper : Printable
		{
			public Paper() : base()
			{
				this.type = "Paper";
				read_pub_per();
			}

			public override void print_info()
			{
				base.print_info();
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("Publishing {0}", this.publishing_period);
				Console.ResetColor();
			}
		}
	}
}