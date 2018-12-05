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
		}

		private void btn_LoginRegister_Click(object sender, EventArgs e)
		{
			dathandler d = new dathandler();
			d.writeDat("Hello World");
		}
	}
}
