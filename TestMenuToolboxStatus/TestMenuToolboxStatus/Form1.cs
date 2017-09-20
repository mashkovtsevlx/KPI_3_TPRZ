using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMenuToolboxStatus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void моеДействиеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Пункт меню");
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Paste();
		}

		private void selectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.SelectAll();
		}

		private void моеДействиеToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Будет выведено сообщение";
		}

		private void моеДействиеToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void выходToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Выход из программы";
		}

		private void выходToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void cutToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Вырезать";
		}

		private void cutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void copyToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Скопировать";
		}

		private void copyToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void pasteToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Вставить";
		}

		private void pasteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void selectToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Выделить";
		}

		private void selectToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}
	}
}
