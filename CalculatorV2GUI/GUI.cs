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
	
	public partial class GUI : Form
	{
		CalculatorSocket calc = new CalculatorSocket(12434);

		public GUI()
		{
			InitializeComponent();
			updateDegRadModeIndicator();

		}

		private void updateDegRadModeIndicator()
		{
			degRadModeLabel.Text = calc.calculate("/getDegRadMode");
		}

		private void button1_Click(object sender, EventArgs e) {
			Console.WriteLine("button 1 clicked");
			Console.WriteLine("Input: " + inputBox.Text);

			if (inputBox.Text.Equals("exit") || inputBox.Text.Equals("quit")) {
				calc.calculate("quit");
				Application.Exit();
				System.Environment.Exit(1);
				return;
			}

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

			updateDegRadModeIndicator(); //update incase we changed which mode we are in
		}

		private void inputBox_TextChanged(object sender, EventArgs e) {
			try {
				ActiveForm.AcceptButton = button1; // Button1 will be 'clicked' when user presses return
			}catch(NullReferenceException n) {
				Console.WriteLine(n.ToString());
			}
		}

	

		private void label1_Click(object sender, EventArgs e) {
			

		}

		private void label3_Click(object sender, EventArgs e) {

		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void label4_Click(object sender, EventArgs e) {

		}
	}
}
