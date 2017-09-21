using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestDialogs
{
	public partial class Form1 : Form
	{
		private Dict dictionary = new Dict();
		private string[] words;

		public Form1()
		{
			InitializeComponent();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				// если выбрали текст
				if (fd.FilterIndex == 1)
					richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.PlainText);
				else
					richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.RichText);
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog fd = new SaveFileDialog();
			fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				// если выбрали текст
				if (fd.FilterIndex == 1)
					richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.PlainText);
				else
					richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.RichText);
			}
		}

		private void открытьToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				// если выбрали текст
				if (fd.FilterIndex == 1)
					richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.PlainText);
				else
					richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.RichText);
			}
		}

		private void сохранитьToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog fd = new SaveFileDialog();
			fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				// если выбрали текст
				if (fd.FilterIndex == 1)
					richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.PlainText);
				else
					richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.RichText);
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			ColorDialog d = new ColorDialog();
			if (d.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.SelectionColor = d.Color;
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			FontDialog d = new FontDialog();
			if (d.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.SelectionFont = d.Font;
			}
		}

		private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void создатьToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void создатьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Создать новый документ";
		}

		private void выходToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Выход из программы";
		}

		private void создатьToolStripButton_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Создать новый документ";
		}

		private void toolStripButton1_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Изменить цвет текста";
		}

		private void toolStripButton2_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Работа с шрифтами";
		}

		private void toolStripButton3_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Выровнять по левому краю";
		}

		private void toolStripButton4_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Выровнять по центру";
		}

		private void toolStripButton5_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Выровнять по правому краю";
		}

		private void открытьToolStripButton_MouseEnter_1(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Открыть документ";
		}

		private void сохранитьToolStripButton_MouseEnter_1(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Сохранить документ";
		}

		private void открытьToolStripMenuItem_MouseEnter_1(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Открыть документ";
		}

		private void сохранитьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Сохранить документ";
		}

		private void перевестиСловоНаАнглийскийToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectedText = dictionary.dicti[richTextBox1.SelectedText];
		}

		private void перевестиСтрокуНаАнглийскийToolStripMenuItem_Click(object sender, EventArgs e)
		{
			words = richTextBox1.SelectedText.Split(' ');
			string final = "";
			int i = 0;
			foreach (string c in words)
			{
				Console.WriteLine(words[i]);
				try
				{
					words[i] = dictionary.dicti[words[i]];
				}
				catch (System.Collections.Generic.KeyNotFoundException)
				{
				}
				final = string.Join(" ", words);
				i++;
			}
			richTextBox1.SelectedText = final;
		}
	}

	public class Dict
	{
		private string key = "";
		private string value = "";
		public Dictionary<string, string> dicti = new Dictionary<string, string>();

		public Dict()
		{
			try
			{
				using (StreamReader fs = new StreamReader("dictionary.txt"))
				{
					while (true)
					{
						key = fs.ReadLine();
						Console.WriteLine(key);
						Console.WriteLine(value);
						value = fs.ReadLine();
						if (key == null || value == null)
							break;
						dicti.Add(key, value);
					}
				}
			}
			catch (System.IO.FileNotFoundException e)
			{
				MessageBox.Show("Dictionary not found");
			}
		}
	}
}