
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
			this.inputBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.answerBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 17);
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
			this.degRadModeLabel.Location = new System.Drawing.Point(112, 17);
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
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.inputBox);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.degRadModeLabel);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);
			this.splitContainer1.Panel1MinSize = 50;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.answerBox);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(1150, 756);
			this.splitContainer1.SplitterDistance = 150;
			this.splitContainer1.TabIndex = 7;
			this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
			// 
			// inputBox
			// 
			this.inputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.inputBox.Location = new System.Drawing.Point(20, -18);
			this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.inputBox.MinimumSize = new System.Drawing.Size(100, 20);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(1110, 31);
			this.inputBox.TabIndex = 14;
			this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
			this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.calculateButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(20, 13);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(200, 19, 200, 19);
			this.panel1.Size = new System.Drawing.Size(1110, 127);
			this.panel1.TabIndex = 12;
			// 
			// calculateButton
			// 
			this.calculateButton.AutoSize = true;
			this.calculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.calculateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.calculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calculateButton.Location = new System.Drawing.Point(200, 19);
			this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.calculateButton.MinimumSize = new System.Drawing.Size(200, 100);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(710, 100);
			this.calculateButton.TabIndex = 11;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = false;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// label2
			// 
			this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 75);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 25);
			this.label2.TabIndex = 9;
			this.label2.Text = "Type what you want to calculate:";
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// answerBox
			// 
			this.answerBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.answerBox.Location = new System.Drawing.Point(20, 0);
			this.answerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.answerBox.Name = "answerBox";
			this.answerBox.Size = new System.Drawing.Size(1110, 602);
			this.answerBox.TabIndex = 0;
			this.answerBox.Text = "";
			this.answerBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1150, 756);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "GUI";
			this.Text = "CalculatorV2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label degRadModeLabel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox answerBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.TextBox inputBox;
	}
}

