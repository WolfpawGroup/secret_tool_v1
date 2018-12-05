namespace secret_tool_v1
{
	partial class f_Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Pass = new System.Windows.Forms.TextBox();
			this.tb_PassAgain = new System.Windows.Forms.TextBox();
			this.btn_LoginRegister = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(319, 94);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btn_LoginRegister);
			this.tabPage1.Controls.Add(this.tb_PassAgain);
			this.tabPage1.Controls.Add(this.tb_Pass);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(311, 68);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Log In";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(311, 76);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Clear all data";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Exit.Location = new System.Drawing.Point(0, 94);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(319, 23);
			this.btn_Exit.TabIndex = 1;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Repeat: ";
			// 
			// tb_Pass
			// 
			this.tb_Pass.Location = new System.Drawing.Point(70, 9);
			this.tb_Pass.Name = "tb_Pass";
			this.tb_Pass.Size = new System.Drawing.Size(227, 20);
			this.tb_Pass.TabIndex = 2;
			// 
			// tb_PassAgain
			// 
			this.tb_PassAgain.Location = new System.Drawing.Point(70, 44);
			this.tb_PassAgain.Name = "tb_PassAgain";
			this.tb_PassAgain.Size = new System.Drawing.Size(227, 20);
			this.tb_PassAgain.TabIndex = 3;
			// 
			// btn_LoginRegister
			// 
			this.btn_LoginRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_LoginRegister.Location = new System.Drawing.Point(-2, 36);
			this.btn_LoginRegister.Name = "btn_LoginRegister";
			this.btn_LoginRegister.Size = new System.Drawing.Size(316, 35);
			this.btn_LoginRegister.TabIndex = 4;
			this.btn_LoginRegister.Text = "Log In";
			this.btn_LoginRegister.UseVisualStyleBackColor = true;
			this.btn_LoginRegister.Click += new System.EventHandler(this.btn_LoginRegister_Click);
			// 
			// f_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 117);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btn_Exit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "f_Login";
			this.Text = "Login";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox tb_PassAgain;
		private System.Windows.Forms.TextBox tb_Pass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_LoginRegister;
	}
}