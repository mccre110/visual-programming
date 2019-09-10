using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO;

namespace Proj07
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public static BindingList<string> ipList = new BindingList<string>();
        public Form1()
        { 
            InitializeComponent();
            this.Text = "Pinger";
            readFile();
            addressBox.DataSource = ipList;
            pingSecondsBox.Text = "5000";
            this.form2 = new Form2(this);
        }
        private void readFile()
        {
            if (!File.Exists("Project07_URLs.txt"))
                return;

            using (StreamReader reader = new StreamReader("Project07_URLs.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    ipList.Add(line);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeFile();
        }
        private void writeFile()
        {
            if (!File.Exists("Project07_URLs.txt"))
            {
                File.Create("Project07_URLs.txt");
            }

            using (StreamWriter writer = new StreamWriter("Project07_URLs.txt"))
            {
                foreach (string ipaddress in ipList)
                {
                    writer.WriteLine(ipaddress);
                }
            }
        }
        private string IpFix(string rawIP)
        {
            string ip = rawIP.Trim();
            ip = ip.Replace("https://", "");
            ip = ip.Replace("http://", "");
            ip = ip.Replace("/", "");
            return ip;
        }
        private void ping(string ip, int loopNum)
        {
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(ip);
                this.pingChart.Series[ip].Points.AddXY(loopNum, reply.RoundtripTime);
            }
            catch (PingException)
            {
                this.pingChart.Series[ip].Points.AddXY(loopNum, -1);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ipList.Add(addBox.Text);
            addBox.Clear();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (addressBox.SelectedIndex > -1)
                ipList.RemoveAt(addressBox.SelectedIndex);
        }
        private void pingAllOnce_Click(object sender, EventArgs e)
        {
            pingChart.Series.Clear();
            foreach (string ipAddress in ipList)
            {
                string ip = IpFix(ipAddress);
                pingChart.Series.Add(ip);
                ping(ip, 1);
            }
        }
        private void PingAllUser_Click(object sender, EventArgs e)
        {
            bool parseBool = int.TryParse(this.pingNumberBox.Text, out int pingNumber);
            if (parseBool)
            {
                pingChart.Series.Clear();
                foreach (string ipAddress in ipList)
                {
                    string ip = IpFix(ipAddress);
                    pingChart.Series.Add(ip);
                    for (int i = 1; i <= pingNumber; i++)
                    {
                        ping(ip, i);
                    }
                }
            }
        }
        private void pingSelOnceButton_Click(object sender, EventArgs e)
        {
            string ip = IpFix(ipList.ElementAt(addressBox.SelectedIndex));
            pingChart.Series.Clear();
            pingChart.Series.Add(ip);
            ping(ip, 1);
        }
        private void pingSelUserButton_Click(object sender, EventArgs e)
        {
            bool parseBool = int.TryParse(this.pingNumberBox.Text, out int pingNumber);
            if (parseBool)
            {
                pingChart.Series.Clear();
                string ip = IpFix(ipList.ElementAt(addressBox.SelectedIndex));
                pingChart.Series.Add(ip);
                for (int i = 1; i <= pingNumber; i++)
                {
                    ping(ip, i);
                }
            }
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
