
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
			this.button1 = new System.Windows.Forms.Button();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.degRadModeLabel = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(269, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(224, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(46, 63);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(642, 22);
			this.inputBox.TabIndex = 1;
			this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
			this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Type what you want to Calculate";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.inputBox);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 260);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(766, 167);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(58, 117);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(642, 120);
			this.panel2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(145, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(320, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "_______________________________________";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Answer:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(58, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Mode:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// degRadModeLabel
			// 
			this.degRadModeLabel.AutoSize = true;
			this.degRadModeLabel.Location = new System.Drawing.Point(111, 13);
			this.degRadModeLabel.Name = "degRadModeLabel";
			this.degRadModeLabel.Size = new System.Drawing.Size(38, 17);
			this.degRadModeLabel.TabIndex = 6;
			this.degRadModeLabel.Text = "DEG";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.degRadModeLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "CalculatorV2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label degRadModeLabel;
	}
}

