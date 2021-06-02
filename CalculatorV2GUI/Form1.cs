using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2GUI
{
	
	public partial class Form1 : Form
	{
		CalculatorSocket calc = new CalculatorSocket(12434);

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("button 1 clicked");
			Console.WriteLine("Input: " + inputBox.Text);

			String output = calc.calculate(inputBox.Text);

			Console.WriteLine(output);


			//format answer to look pretty and output
			String ansStr = inputBox.Text + " =\n";
			for (int i = 0; i < output.Length; i++) ansStr += " ";

			int numSpaces = ansStr.Length - output.Length;

			for (int i = 0; i < numSpaces; i++) ansStr += " ";
			ansStr += output;

			label3.Text = ansStr;


			inputBox.Text = ""; //reset text box
		}

		private void inputBox_TextChanged(object sender, EventArgs e)
		{
			ActiveForm.AcceptButton = button1; // Button1 will be 'clicked' when user presses return
		}

	

		private void label1_Click(object sender, EventArgs e)
		{
			

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
