using System.Net.Sockets;
using System.Net;
using System;
using CalculatorV2GUI.CsCalculatorV2;

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
        
        public CalculatorSocket(int port = 54353, bool verboseCalculator = false)
        {
            IPEndPoint serverAddress = new IPEndPoint(GetLocalIPAddress(), port);

            if (verboseOutput) Console.WriteLine("Attempting to connect to port " + port);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(serverAddress);
                if (verboseOutput) Console.WriteLine("Connected");
            }
            catch (Exception e)
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

            try
            {

                // Sending
                int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
                byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
                byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
                clientSocket.Send(toSendLenBytes);
                clientSocket.Send(toSendBytes);

                if (verboseOutput) Console.WriteLine("sent. Waiting for response from calculator");

                // Receiving
                byte[] rcvLenBytes = new byte[4];
                clientSocket.Receive(rcvLenBytes);
                int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
                byte[] rcvBytes = new byte[rcvLen];
                clientSocket.Receive(rcvBytes);
                String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);

                if (verboseOutput) Console.WriteLine("Recieved: " + rcv);

                return rcv;
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