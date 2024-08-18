using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		private static void test1()
		{

		
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Form frm2 = new Form();
			frm2.Text = "Phương thức Show()";
			frm2.Show();
			frm2.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form frm3 = new Form();
			frm3.Text = "Pt ShowDialog()";
			frm3.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
