using SimpleTCP;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private SimpleTcpServer server;
        private string clientMsg = "";
        private string validatedData = "";
        private static string directory = @"C:\Users\ASUS\Desktop\VIKO\2 Kursas\S2\Informacijos Saugumas\PD5CLIENT\Server\Server\bin\Debug\Tekstas.txt";

        public Server()
        {
            InitializeComponent();

            OnLoad();
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            if (ipAddrTxt.Text != string.Empty && portTxt.Text != string.Empty)
            {
                IPAddress ip = IPAddress.Parse(ipAddrTxt.Text);

                server.Start(ip, Convert.ToInt32(portTxt.Text));

                if (server.IsStarted)
                {
                    StartServerBtn.Enabled = false;
                    StopServerBtn.Enabled = true;

                    statusTxt.Text = "Server is Online.";
                }
            }
            else
                MessageBox.Show("Fill in Ip address and Port !");
        }

        private void StopServerBtn_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                statusTxt.Text = "Server is offline.";
                StartServerBtn.Enabled = true;
                StopServerBtn.Enabled = false;
            }
        }

        private void OnLoad()
        {
            ipAddrTxt.Text = "127.0.0.1";
            portTxt.Text = "4040";
            StopServerBtn.Enabled = false;

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += DataReceived;
        }

        private void DataReceived(object sender, SimpleTCP.Message msg)
        {
            messageTxt.Invoke((MethodInvoker)delegate
            {
                clientMsg = msg.MessageString;
                using (StreamReader sr = new StreamReader(directory))
                {
                    validatedData = sr.ReadLine();
                }

                if (validatedData != string.Empty)
                    messageTxt.Text = clientMsg;
                else
                    messageTxt.Text = "Bad Signature";
            });
        }

        public static void XCheck(string clientMsg, byte[] clientSignature)
        {
            string validatedData2 = HelperMethods.Verify(clientMsg, clientSignature);

            using (FileStream fs = File.Open(directory, FileMode.OpenOrCreate))
            {
                fs.SetLength(0);
            }
            File.WriteAllText(directory, validatedData2);
        }

        private void CheckMessageBtn_Click(object sender, EventArgs e)
        {
            messageTxt.Invoke((MethodInvoker)delegate
            {
            });
        }
    }
}