namespace secret_tool_v1
{
	partial class Form1
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
			this.ms_Menu = new System.Windows.Forms.MenuStrip();
			this.btn_Menu_Files = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.ss_Status = new System.Windows.Forms.StatusStrip();
			this.sc_Splitter1 = new System.Windows.Forms.SplitContainer();
			this.sc_Splitter2 = new System.Windows.Forms.SplitContainer();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.lv_DirList = new System.Windows.Forms.ListView();
			this.lv_FilesList = new System.Windows.Forms.ListView();
			this.ts_Tools = new System.Windows.Forms.ToolStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.ms_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_Splitter1)).BeginInit();
			this.sc_Splitter1.Panel1.SuspendLayout();
			this.sc_Splitter1.Panel2.SuspendLayout();
			this.sc_Splitter1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_Splitter2)).BeginInit();
			this.sc_Splitter2.Panel1.SuspendLayout();
			this.sc_Splitter2.Panel2.SuspendLayout();
			this.sc_Splitter2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ms_Menu
			// 
			this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_Files,
            this.btn_Menu_Settings,
            this.btn_Menu_Tools,
            this.btn_Menu_Help});
			this.ms_Menu.Location = new System.Drawing.Point(0, 0);
			this.ms_Menu.Name = "ms_Menu";
			this.ms_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ms_Menu.Size = new System.Drawing.Size(947, 24);
			this.ms_Menu.TabIndex = 0;
			this.ms_Menu.Text = "menuStrip1";
			// 
			// btn_Menu_Files
			// 
			this.btn_Menu_Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
			this.btn_Menu_Files.Name = "btn_Menu_Files";
			this.btn_Menu_Files.Size = new System.Drawing.Size(37, 20);
			this.btn_Menu_Files.Text = "File";
			// 
			// btn_Menu_Settings
			// 
			this.btn_Menu_Settings.Name = "btn_Menu_Settings";
			this.btn_Menu_Settings.Size = new System.Drawing.Size(61, 20);
			this.btn_Menu_Settings.Text = "Settings";
			// 
			// btn_Menu_Tools
			// 
			this.btn_Menu_Tools.Name = "btn_Menu_Tools";
			this.btn_Menu_Tools.Size = new System.Drawing.Size(48, 20);
			this.btn_Menu_Tools.Text = "Tools";
			// 
			// btn_Menu_Help
			// 
			this.btn_Menu_Help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btn_Menu_Help.Name = "btn_Menu_Help";
			this.btn_Menu_Help.Size = new System.Drawing.Size(44, 20);
			this.btn_Menu_Help.Text = "Help";
			// 
			// ss_Status
			// 
			this.ss_Status.Location = new System.Drawing.Point(0, 513);
			this.ss_Status.Name = "ss_Status";
			this.ss_Status.Size = new System.Drawing.Size(947, 22);
			this.ss_Status.TabIndex = 1;
			this.ss_Status.Text = "statusStrip1";
			// 
			// sc_Splitter1
			// 
			this.sc_Splitter1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.sc_Splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_Splitter1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.sc_Splitter1.Location = new System.Drawing.Point(0, 24);
			this.sc_Splitter1.Name = "sc_Splitter1";
			// 
			// sc_Splitter1.Panel1
			// 
			this.sc_Splitter1.Panel1.Controls.Add(this.sc_Splitter2);
			this.sc_Splitter1.Panel1.Controls.Add(this.ts_Tools);
			// 
			// sc_Splitter1.Panel2
			// 
			this.sc_Splitter1.Panel2.Controls.Add(this.richTextBox3);
			this.sc_Splitter1.Panel2.Controls.Add(this.richTextBox2);
			this.sc_Splitter1.Panel2.Controls.Add(this.richTextBox1);
			this.sc_Splitter1.Size = new System.Drawing.Size(947, 489);
			this.sc_Splitter1.SplitterDistance = 272;
			this.sc_Splitter1.SplitterWidth = 11;
			this.sc_Splitter1.TabIndex = 2;
			// 
			// sc_Splitter2
			// 
			this.sc_Splitter2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_Splitter2.Location = new System.Drawing.Point(0, 25);
			this.sc_Splitter2.Name = "sc_Splitter2";
			this.sc_Splitter2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_Splitter2.Panel1
			// 
			this.sc_Splitter2.Panel1.Controls.Add(this.lv_DirList);
			// 
			// sc_Splitter2.Panel2
			// 
			this.sc_Splitter2.Panel2.Controls.Add(this.webBrowser1);
			this.sc_Splitter2.Panel2.Controls.Add(this.toolStrip1);
			this.sc_Splitter2.Panel2.Controls.Add(this.lv_FilesList);
			this.sc_Splitter2.Size = new System.Drawing.Size(272, 464);
			this.sc_Splitter2.SplitterDistance = 151;
			this.sc_Splitter2.TabIndex = 1;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(272, 284);
			this.webBrowser1.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Location = new System.Drawing.Point(0, 284);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(272, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// lv_DirList
			// 
			this.lv_DirList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_DirList.Location = new System.Drawing.Point(0, 0);
			this.lv_DirList.Name = "lv_DirList";
			this.lv_DirList.Size = new System.Drawing.Size(272, 151);
			this.lv_DirList.TabIndex = 0;
			this.lv_DirList.UseCompatibleStateImageBehavior = false;
			// 
			// lv_FilesList
			// 
			this.lv_FilesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_FilesList.Location = new System.Drawing.Point(0, 0);
			this.lv_FilesList.Name = "lv_FilesList";
			this.lv_FilesList.Size = new System.Drawing.Size(272, 309);
			this.lv_FilesList.TabIndex = 0;
			this.lv_FilesList.UseCompatibleStateImageBehavior = false;
			// 
			// ts_Tools
			// 
			this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_Tools.Location = new System.Drawing.Point(0, 0);
			this.ts_Tools.Name = "ts_Tools";
			this.ts_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ts_Tools.Size = new System.Drawing.Size(272, 25);
			this.ts_Tools.TabIndex = 0;
			this.ts_Tools.Text = "toolStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.testToolStripMenuItem.Text = "test";
			this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(3, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(661, 102);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(3, 108);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(661, 102);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(3, 216);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(661, 102);
			this.richTextBox3.TabIndex = 2;
			this.richTextBox3.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 535);
			this.Controls.Add(this.sc_Splitter1);
			this.Controls.Add(this.ss_Status);
			this.Controls.Add(this.ms_Menu);
			this.MainMenuStrip = this.ms_Menu;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ms_Menu.ResumeLayout(false);
			this.ms_Menu.PerformLayout();
			this.sc_Splitter1.Panel1.ResumeLayout(false);
			this.sc_Splitter1.Panel1.PerformLayout();
			this.sc_Splitter1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_Splitter1)).EndInit();
			this.sc_Splitter1.ResumeLayout(false);
			this.sc_Splitter2.Panel1.ResumeLayout(false);
			this.sc_Splitter2.Panel2.ResumeLayout(false);
			this.sc_Splitter2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_Splitter2)).EndInit();
			this.sc_Splitter2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip ms_Menu;
		private System.Windows.Forms.StatusStrip ss_Status;
		private System.Windows.Forms.SplitContainer sc_Splitter1;
		private System.Windows.Forms.SplitContainer sc_Splitter2;
		private System.Windows.Forms.ToolStrip ts_Tools;
		private System.Windows.Forms.ListView lv_DirList;
		private System.Windows.Forms.ListView lv_FilesList;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Files;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Settings;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Tools;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Help;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

