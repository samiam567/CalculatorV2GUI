using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2GUI
{
	
	public partial class GUI : Form
	{
		CalculatorSocket calc = new CalculatorSocket(12435);
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

		private void calculate()
		{
			string inputString = inputBox.Text;

			if (!programMode.Checked) // calculator mode
			{
				

				inputBox.Clear(); //reset text box

				inputHistory.Push(inputString); // save input into history

				if (inputString.Equals("exit") || inputString.Equals("quit"))
				{
					calc.calculate("quit");
					Application.Exit();
					System.Environment.Exit(1);
					return;
				}

				String output = calc.calculate(inputString);

				Console.WriteLine(output);

				String ansStr = "";
				for (int i = 0; i < output.Length; i++) ansStr += " ";

				int numSpaces = ansStr.Length - output.Length;

				for (int i = 0; i < numSpaces; i++) ansStr += " ";
				ansStr += output;

				answerBox.Text = ansStr;
			}
			else // programming mode
			{
				// save file
				Console.WriteLine("saving file");
				File.WriteAllText(fileName.Text, inputString);

				String output = "\n";

				int lineNumber = -1;
				bool multiline_comment = false;
				foreach (String next in inputString.Split('\n'))
				{
					Console.WriteLine("parsing " + next);
					string nextLine = next;
					lineNumber++;

					if (nextLine.Length > 0)
					{

						if (nextLine.Contains("<!--"))
						{
							multiline_comment = true;
						}

						bool isComment = nextLine.StartsWith("#") || multiline_comment;
						bool isSilenced = nextLine.EndsWith(";"); // commands with a semicolon are not outputted

						if (nextLine.Contains("-->"))
						{
							multiline_comment = false;
							isComment = true;
						}


						if (isSilenced)
						{
							nextLine = nextLine.Substring(0, nextLine.Length - 1); // remove ending semicolon
						}

						if (isComment && !isSilenced)
						{
							output += nextLine + "\n";
						}
						else
						{

							// check if the user put a comment at the end of the line
							int commentStartLocation = nextLine.IndexOf('#');
							String commentPortion = "";
							if (commentStartLocation != -1)
							{
								commentPortion = nextLine.Substring(commentStartLocation);
								nextLine = nextLine.Substring(0, commentStartLocation);
							}

							// calculate the line and add to output
							String lineOut;
						
							Console.WriteLine("sending: " + nextLine);
							lineOut = calc.calculate(nextLine);
							Console.WriteLine("received: " + lineOut);
						

							if (!isSilenced) output += lineOut + " " + commentPortion + "\n"; // output if there is no semicolon


						}

					}
					else
					{
						output += "\n";

					}
				}

				answerBox.Text = output;
			}
			


			//updateDegRadModeIndicator(); //update incase we changed which mode we are in

		}

		private void calculateButton_Click(object sender, EventArgs e) {
			Console.WriteLine("button 1 clicked");

			calculate();
			
		}


		private void inputBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// retreive input history
			if (e.KeyCode == Keys.Up && !programMode.Checked)
			{
				// get the last input from the stack and enter it into the input box
				if (inputHistory.Count > 0)
				{
					inputBox.Text = inputHistory.Pop();
					System.Threading.Thread.Sleep(50);
				}
			} else if ((e.KeyCode == Keys.Enter && !programMode.Checked) || (e.Control && e.KeyCode == Keys.S)) {
				calculate();
				
			}
		}

		private void fileName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					inputBox.Text = File.ReadAllText(fileName.Text);
				}catch(FileNotFoundException ex)
				{
					inputBox.Text = ex.ToString();
				}
			}
		}

		private void programMode_CheckedChanged(Object sender, EventArgs e)
		{
			if (programMode.Checked)
			{
				fileName.Show();
			}
			else
			{
				fileName.Hide();
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

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void answerBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void degRadModeLabel_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}

	}
}
