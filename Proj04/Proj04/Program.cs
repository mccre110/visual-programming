using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Timers;
using System.Net.NetworkInformation;
using System.IO;



namespace Proj04
{
    class Program
    {
        public static List<string> ipList = new List<string>();
        public static List<string> ipListOut = new List<string>();
        public static List<long> pingTimeList = new List<long>();
        public static List<string> repList = new List<string>();


        static void Main(string[] args)
        {
            try
            {
                ReadFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Not Read.");
            }


            Timer timer = new Timer(5000);
            timer.Elapsed += HandleTimer;

            Console.WriteLine("Enter a command (start, stop, exit):");

            while (true)
            {
                Console.Write("Command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Command entered: " + command);

                if (command.ToLower() == "exit")
                {
                    WriteFile();
                    break;
                }

                else if (command.ToLower() == "start")
                    timer.Start();
                else if (command.ToLower() == "stop")
                    timer.Stop();
                else
                    Console.WriteLine("Try Again");

            }
        }

        private static void ReadFile()
        {
            if (!File.Exists(@"Project04_URLs.csv"))
            {
                File.Create(@"Project04_URLs.csv");
                return;
            }

            using (TextFieldParser parser = new TextFieldParser("Project04_URLs.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] parts = parser.ReadFields();
                    if (string.IsNullOrWhiteSpace(parts[0]))
                    {
                        Console.WriteLine("Please use valid IP or web address!!");
                        continue;
                    }

                    ipList.Add(parts[0]);
                }
            }
        }

        private static void WriteFile()
        {
            StringBuilder csv = new StringBuilder();
            for (int i = 0; i < ipListOut.Count; i++)
                csv.AppendLine(ipListOut[i] + "," + pingTimeList[i] + "," + repList[i]);

            File.WriteAllText(@"Results.csv", csv.ToString());
        }
        private static string IpFix(string rawIP)
        {
            string ip = rawIP.Trim();
            ip = ip.Replace("https://", "");
            ip = ip.Replace("http://", "");
            ip = ip.Replace("/", "");
            return ip;
        }

        private static void HandleTimer(Object source, ElapsedEventArgs e)
        {
            //Ping List
            Ping pinger = new Ping();
            foreach (string ipAddress in ipList)
            {
                string ip = IpFix(ipAddress);

                try
                {
                    PingReply reply = pinger.Send(ip);
                    ipListOut.Add(ipAddress);
                    pingTimeList.Add(reply.RoundtripTime);
                    repList.Add("Good");
                }
                catch (PingException)
                {
                    ipListOut.Add(ipAddress);
                    pingTimeList.Add(-1);
                    repList.Add("Bad");
                }
            }
        }
    }
}

