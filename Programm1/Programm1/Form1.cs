using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm1
{
	public partial class TestForm : Form
	{
		int x = 0;
		public TestForm()
		{
			InitializeComponent();
			Button myBtn = new Button();
			myBtn.Text = "Вызов второй формы";
			myBtn.Size = new Size(135, 23);
			myBtn.Location = new Point(12, 238);
			this.Controls.Add(myBtn);
			myBtn.Click += MyBtn_Click;
		}

		private void MyBtn_Click(object sender, EventArgs e)
		{
			x = 20;
			MessageBox.Show(Convert.ToString(x));
			Form2 f = new Form2();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.ShowDialog();
		}
		/*private void TestForm_Load(object sender, EventArgs e)
		{
			x = 10;
			MessageBox.Show(Convert.ToString(x));
		}

		private void TestForm_Deactivate(object sender, EventArgs e)
		{
			x = 15;
			MessageBox.Show(Convert.ToString(x));
		}

		private void TestForm_Activated(object sender, EventArgs e)
		{
			x = 25;
			MessageBox.Show(Convert.ToString(x));
		}*/
	}
}
