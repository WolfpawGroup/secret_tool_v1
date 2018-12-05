using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace secret_tool_v1
{
	public partial class Form1 : Form
	{
		keygen k = new keygen();
		public Form1()
		{
			InitializeComponent();
		}

		private void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = gencode(112);
			richTextBox2.Text = gencode(113);
			richTextBox3.Text = gencode(112);

		}

		public string gencode(int initial)
		{
			int last = initial;
			string tmp = "";
			for (int i = 0; i < 1000; i++)
			{
				int[] l = k.gen5(last);  
				for (int x = 0; x < l.Length; x++)
				{
					tmp += (char)(20 + ((l[x] + i + x) % 235));
					last += l.Last();
				}
			}

			return tmp;
		}
	}
}
