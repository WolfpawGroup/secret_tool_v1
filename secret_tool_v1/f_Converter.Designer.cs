namespace secret_tool_v1
{
	partial class f_Converter
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
			this.lbl_ConvertCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.ch_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "File List:";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Index,
            this.ch_Name,
            this.ch_Path,
            this.ch_FileType,
            this.ch_Size});
			this.listView1.Location = new System.Drawing.Point(15, 53);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(773, 230);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 289);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add Files";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(137, 289);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Add Folder";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(259, 289);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_ConvertCount,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 17);
			this.toolStripStatusLabel1.Text = "Files to convert/Files Converted: ";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(120, 16);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
			this.toolStripStatusLabel2.Text = "/";
			// 
			// toolStripProgressBar2
			// 
			this.toolStripProgressBar2.AutoSize = false;
			this.toolStripProgressBar2.Name = "toolStripProgressBar2";
			this.toolStripProgressBar2.Size = new System.Drawing.Size(50, 16);
			// 
			// lbl_ConvertCount
			// 
			this.lbl_ConvertCount.Name = "lbl_ConvertCount";
			this.lbl_ConvertCount.Size = new System.Drawing.Size(420, 17);
			this.lbl_ConvertCount.Spring = true;
			this.lbl_ConvertCount.Text = "0/0";
			this.lbl_ConvertCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ch_Index
			// 
			this.ch_Index.Text = "#";
			this.ch_Index.Width = 28;
			// 
			// ch_Name
			// 
			this.ch_Name.Text = "Name";
			this.ch_Name.Width = 83;
			// 
			// ch_Path
			// 
			this.ch_Path.Text = "Path";
			this.ch_Path.Width = 140;
			// 
			// ch_FileType
			// 
			this.ch_FileType.Text = "Type";
			this.ch_FileType.Width = 38;
			// 
			// ch_Size
			// 
			this.ch_Size.Text = "Size (kb)";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(672, 289);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Delete File(s)";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 344);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Output Folder: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 360);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(744, 20);
			this.textBox1.TabIndex = 9;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(756, 359);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(32, 22);
			this.button5.TabIndex = 10;
			this.button5.Text = "O";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(15, 386);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(197, 17);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.Text = "Keep folder structure where possible";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// f_Converter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "f_Converter";
			this.Text = "f_Converter";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_ConvertCount;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
		private System.Windows.Forms.ColumnHeader ch_Index;
		private System.Windows.Forms.ColumnHeader ch_Name;
		private System.Windows.Forms.ColumnHeader ch_Path;
		private System.Windows.Forms.ColumnHeader ch_FileType;
		private System.Windows.Forms.ColumnHeader ch_Size;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}