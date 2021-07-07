namespace CalculatorV2GUI
{
	using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;


    namespace CsCalculatorV2
    {
        internal class CommandRunner
        {
            protected int numOutputsLogged = 0;
            protected bool outputDirectly = true;
            protected string returns = "";
            protected string errors = "";
            protected bool waitForAsyncProcessesOnExit = false;

            private LinkedList<Process> runningProcesses = new LinkedList<Process>(); //if we have sent an async process, this variable will hold it's reference

            protected const int timeout = 100;

            public static string queryCalculator(string equation)
            {
                return queryCalculator(new string[] { equation });
            }

            public static string queryCalculator(string[] equations)
            {
                string equationsStr = "";

                for (int i = 0; i < equations.Length; i++)
                {
                    equationsStr += "\"" + equations[i] + "\" ";
                }
                string returnsStr = queryShellWithCommand(Directory.GetCurrentDirectory(), "java -jar CalculatorV2.jar " + equationsStr);

                // cut out everything except the output from the returnsStr
                string[] returns = returnsStr.Split('\n');
                returnsStr = "";

                for (int i = 0; i < returns.Length; i++)
                {
                    if (returns[i].Length != 0 && returns[i].Length != 0 && !(returns[i].Contains("C:\\") || returns[i].Contains("Microsoft")))
                    {
                        returnsStr += returns[i] + "\n";
                    }
                }

                return returnsStr;
            }

            public void launchCalculator(int port, bool verboseCalculator = false)
            {
                if (verboseCalculator)
                {
                    runCommand(Directory.GetCurrentDirectory(), "java -jar CalculatorV2.jar --user-calculator --verbose-output --socket-server " + port + " csharp", true);
                }
                else
                {
                    runCommand(Directory.GetCurrentDirectory(), "java -jar CalculatorV2.jar --user-calculator --socket-server " + port + " csharp", true);
                }
            }

            public static string queryShellWithCommand(string command, string workingDirectory)
            {
                CommandRunner oracle = new CommandRunner();
                oracle.runCommand(command, workingDirectory);

                if (oracle.errors.Length > 1)
                {
                    Console.WriteLine("Errors from CalculatorV2.java: " + oracle.errors);
                }

                return oracle.returns;
            }

            public void runCommand(string workingDirectory, string command, bool runAsync = false)
            {


                Process process = new Process();


                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "cmd.exe");

                // Redirects the standard input so that commands can be sent to the shell.
                process.StartInfo.RedirectStandardInput = true;
                // Runs the specified command and exits the shell immediately.
                //process.StartInfo.Arguments = @"/c ""dir""";

                process.OutputDataReceived += ProcessOutputDataHandler;
                process.ErrorDataReceived += ProcessErrorDataHandler;

                process.Start();


                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // Send a directory command and an exit command to the shell
                process.StandardInput.WriteLine(command);

                process.StandardInput.WriteLine("exit");


                if (runAsync)
                {
                    runningProcesses.AddLast(process);
                }
                else
                {
                    process.WaitForExit();
                }

            }

            public void ProcessOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
            {
                returns += outLine.Data + "\n";
                if (outputDirectly) Console.WriteLine(outLine.Data);
                numOutputsLogged++;
            }

            public void ProcessErrorDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
            {
                errors += outLine.Data + "\n";
                if (outputDirectly) Console.WriteLine(outLine.Data);
                numOutputsLogged++;
            }

            ~CommandRunner()
            {
                foreach (Process process in runningProcesses)
                {
                    if (waitForAsyncProcessesOnExit)
                    {
                        process.WaitForExit();
                    }
                    process.Dispose();
                }
            }

        }
    }



}