using System.Net.Sockets;
using System.Net;
using System;
using CalculatorV2GUI.CsCalculatorV2;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CalculatorV2GUI
{
	public class CalculatorSocket
    {

        Socket clientSocket;

        bool verboseOutput = true;

        CommandRunner commandRunner = null;

        public static void test()
        {

            CalculatorSocket calc = new CalculatorSocket(11311, true);
            calc.verboseOutput = true;
            Console.WriteLine("Sending calculation");
            Console.WriteLine(calc.calculate("1+1"));
            Console.WriteLine(calc.calculate("1+i"));

            Console.WriteLine(calc.calculate("1+1"));
            Console.WriteLine(calc.calculate("1+1"));
            Console.WriteLine(calc.calculate("1+1"));
            Console.WriteLine(calc.calculate("1+1"));
            Console.WriteLine(calc.calculate("1+1"));

            calc.close();
        }
        
        public CalculatorSocket(int port = 54353, bool verboseCalculator = true)
        {
            IPEndPoint serverAddress = new IPEndPoint(GetLocalIPAddress(), port);

            if (verboseOutput) Console.WriteLine("Attempting to connect to port " + port);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(serverAddress);
                if (verboseOutput) Console.WriteLine("Connected");
            }
            catch (Exception)
            {
                if (verboseOutput) Console.WriteLine("No existing server. Launching our own...");
                commandRunner = new CommandRunner();
                commandRunner.launchCalculator(port, verboseCalculator: verboseCalculator);

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        clientSocket.Connect(serverAddress);
                        if (verboseOutput) Console.WriteLine("Connected");
                        break;
                    }
                    catch (Exception w)
                    {
                        if (verboseOutput) Console.WriteLine(w.ToString());
                    }
                }

            }


        }



        public string queryCalculator(string[] equations)
        {
            string answers = "";
            string cAns = "";
            foreach (string s in equations)
            {
                cAns = calculate(s);
                if (!cAns.StartsWith("~~~~"))
                {
                    answers += cAns + (equations.Length > 1 ? "\n" : "");
                }
            }
            return answers;
        }


        public string calculate(string toSend)
        {
            if (verboseOutput) Console.WriteLine("Attempting to send...");

            toSend = toSend.Replace("\n", "");
            try
            {

                // Sending
                var messageBytes = Encoding.UTF8.GetBytes(toSend + "\n");
                clientSocket.Send(messageBytes);
                Console.WriteLine($"Socket client sent message: \"{toSend}\"");

                if (verboseOutput) Console.WriteLine("sent. Waiting for response from calculator");

                // Receiving
                String output = "";
                int received = 1;
                while (received != 0 && ! output.Contains("~~~~"))
                {
                    var buffer = new byte[16777216];
                    received = clientSocket.Receive(buffer);
                    var rcv = Encoding.UTF8.GetString(buffer, 0, received);
                    output += rcv;
                    if (verboseOutput) Console.WriteLine("Recieved: " + rcv);
                }
                output = output.Replace("~~~~","");

               if (output.EndsWith("\n")) output = output.Substring(0, output.Length - 2);

                

                return output;
            }
            catch (SocketException s)
            {
                Console.WriteLine(s.ToString());
                return "exception";
            }
        }

        public void close()
        {
            calculate("quit");
            clientSocket.Close();
        }

        ~CalculatorSocket()
        {
            calculate("quit");
            clientSocket.Close();
        }


        public static IPAddress GetLocalIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}