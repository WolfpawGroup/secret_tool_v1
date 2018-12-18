using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace secret_tool_v1
{
	public partial class f_Login : Form
	{
		public f_Login()
		{
			InitializeComponent();
			Load += F_Login_Load;
		}

		private void F_Login_Load(object sender, EventArgs e)
		{
			dathandler d = new dathandler();
			d.genDatEncKey();
		}

		private void btn_LoginRegister_Click(object sender, EventArgs e)
		{
			dathandler d = new dathandler();
			d.writeDat("Hello World");
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{

		}
	}
}
