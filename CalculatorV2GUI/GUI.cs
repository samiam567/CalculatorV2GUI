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
		Stack<string> inputHistory = new Stack<string>();

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

			string inputString = inputBox.Text;
			inputBox.Text = ""; //reset text box
			inputHistory.Push(inputString); // save input into history

			if (inputString.Equals("exit") || inputString.Equals("quit")) {
				calc.calculate("quit");
				Application.Exit();
				System.Environment.Exit(1);
				return;
			}

			inputHistory.Push(inputString);
			String output = calc.calculate(inputString);
			
			Console.WriteLine(output);


			//format answer to look pretty and output
			String ansStr = inputString + " =\n";
			for (int i = 0; i < output.Length; i++) ansStr += " ";

			int numSpaces = ansStr.Length - output.Length;

			for (int i = 0; i < numSpaces; i++) ansStr += " ";
			ansStr += output;

			label3.Text = ansStr;


			updateDegRadModeIndicator(); //update incase we changed which mode we are in
		}

		private void inputBox_TextChanged(object sender, EventArgs e) {
			try {
				ActiveForm.AcceptButton = button1; // Button1 will be 'clicked' when user presses return
			}catch(NullReferenceException n) {
				Console.WriteLine(n.ToString());
			}
		}


		private void inputBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// retreive input history
			if (e.KeyCode == Keys.Up)
			{
				// get the last input from the stack and enter it into the input box
				if (inputHistory.Count > 0)
				{
					inputBox.Text = inputHistory.Pop();
					System.Threading.Thread.Sleep(50);
				}
			}
		}

	

		private void label1_Click(object sender, EventArgs e) {
			

		}

		private void label3_Click(object sender, EventArgs e) {

		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void label4_Click(object sender, EventArgs e) {

		}
	}
}
