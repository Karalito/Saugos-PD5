using Server;
using SimpleTCP;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Client : Form
    {
        private SimpleTcpClient client;

        public Client()
        {
            InitializeComponent();
            InitNewClient();
        }

        private void InitNewClient()
        {
            ipAddrTxt.Text = "127.0.0.1";
            portTxt.Text = "4040";
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += DataReceived;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (ipAddrTxt.Text != string.Empty && portTxt.Text != string.Empty)
            {
                client.Connect(ipAddrTxt.Text, Convert.ToInt32(portTxt.Text));

                var th = new Thread(() => isConnected());
                th.Start();
            }
            else
                MessageBox.Show("Fill in Ip address and Port !");
        }

        private void isConnected()
        {
            try
            {
                while (true)
                {
                    if (client != null && client.TcpClient.Connected)
                    {
                        statusTxt.Invoke((MethodInvoker)delegate
                        {
                            statusTxt.Text = "Connected !";
                            ConnectBtn.Enabled = false;
                        });
                    }
                    else
                    {
                        statusTxt.Invoke((MethodInvoker)delegate
                        {
                            statusTxt.Text = "Disconnected !";
                            ConnectBtn.Enabled = true;
                        });

                        break;
                    }
                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Is connected ERROR ! " + ex);
            }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] signature = HelperMethods2.DigitalMessage(messageTxt.Text);

                string clientSignature = Encoding.UTF8.GetString(signature);
                string clientMsg = messageTxt.Text+ "BAD";

                //+ "BAD";

                HelperMethods.CallExtraMethod(clientMsg, signature);

                client.Write(clientMsg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with sending message ! " + ex);
            }
        }

        private void DataReceived(Object sender, SimpleTCP.Message msg)
        {
            statusTxt.Invoke((MethodInvoker)delegate
            {
                statusTxt.Text = msg.MessageString;
            });
        }
    }
}