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
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dathandler dh = new dathandler();
			string k = dh.genDatEncKey();
			int i = k.Length / 4;
			string[] keyparts = new string[] { k.Substring(0 * i, i), k.Substring(1 * i, i), k.Substring(2 * i, i), k.Substring(3 * i, i) };

			int k1 = 0;
			int k2 = 0;
			int k3 = 0;
			int k4 = 0;

			foreach(char c in keyparts[0])
			{

			}

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
