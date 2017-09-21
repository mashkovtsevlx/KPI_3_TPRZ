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
	}
}
