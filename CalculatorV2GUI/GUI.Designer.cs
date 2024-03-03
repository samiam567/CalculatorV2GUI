
namespace CalculatorV2GUI
{
	partial class GUI
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
			this.label4 = new System.Windows.Forms.Label();
			this.degRadModeLabel = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fileName = new System.Windows.Forms.TextBox();
			this.programMode = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.inputBox = new System.Windows.Forms.RichTextBox();
			this.answerBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 27);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Mode:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// degRadModeLabel
			// 
			this.degRadModeLabel.AutoSize = true;
			this.degRadModeLabel.Location = new System.Drawing.Point(88, 27);
			this.degRadModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.degRadModeLabel.Name = "degRadModeLabel";
			this.degRadModeLabel.Size = new System.Drawing.Size(57, 25);
			this.degRadModeLabel.TabIndex = 6;
			this.degRadModeLabel.Text = "DEG";
			this.degRadModeLabel.Click += new System.EventHandler(this.degRadModeLabel_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);
			this.splitContainer1.Panel1MinSize = 50;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.answerBox);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(1603, 1032);
			this.splitContainer1.SplitterDistance = 112;
			this.splitContainer1.TabIndex = 7;
			this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(20, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.panel2);
			this.splitContainer2.Panel1MinSize = 55;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.inputBox);
			this.splitContainer2.Size = new System.Drawing.Size(1563, 102);
			this.splitContainer2.SplitterDistance = 55;
			this.splitContainer2.SplitterWidth = 8;
			this.splitContainer2.TabIndex = 15;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fileName);
			this.panel2.Controls.Add(this.programMode);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.degRadModeLabel);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1563, 55);
			this.panel2.TabIndex = 16;
			// 
			// fileName
			// 
			this.fileName.Hide();
			this.fileName.Location = new System.Drawing.Point(395, 21);
			this.fileName.MinimumSize = new System.Drawing.Size(200, 30);
			this.fileName.Name = "fileName";
			this.fileName.Size = new System.Drawing.Size(1000, 31);
			this.fileName.TabIndex = 13;
			this.fileName.Text = "./test.cobra";
			this.fileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileName_KeyDown);
			// 
			// programMode
			// 
			this.programMode.AutoSize = true;
			this.programMode.Location = new System.Drawing.Point(193, 23);
			this.programMode.Name = "programMode";
			this.programMode.Size = new System.Drawing.Size(184, 29);
			this.programMode.TabIndex = 12;
			this.programMode.Text = "Program mode";
			this.programMode.UseVisualStyleBackColor = true;
			this.programMode.CheckedChanged += new System.EventHandler(this.programMode_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 71);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 25);
			this.label2.TabIndex = 9;
			this.label2.Text = "Type what you want to calculate:";
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// inputBox
			// 
			this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputBox.Location = new System.Drawing.Point(0, 0);
			this.inputBox.Margin = new System.Windows.Forms.Padding(6);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(1563, 39);
			this.inputBox.TabIndex = 0;
			this.inputBox.Text = "";
			this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
			// 
			// answerBox
			// 
			this.answerBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.answerBox.Location = new System.Drawing.Point(20, 0);
			this.answerBox.Margin = new System.Windows.Forms.Padding(4);
			this.answerBox.Name = "answerBox";
			this.answerBox.Size = new System.Drawing.Size(1563, 916);
			this.answerBox.TabIndex = 0;
			this.answerBox.Text = "";
			this.answerBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1603, 1032);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "GUI";
			this.Text = "CalculatorV2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label degRadModeLabel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox answerBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox inputBox;
		private System.Windows.Forms.CheckBox programMode;
		private System.Windows.Forms.TextBox fileName;
	}
}

