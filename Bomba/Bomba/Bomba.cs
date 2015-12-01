using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomba
{
    public partial class Bomba : Form
    {
        Socket client = null;

        public int port = 11000;

        private static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static ManualResetEvent sendDone = new ManualResetEvent(false);
        private static ManualResetEvent receiveDone = new ManualResetEvent(false);

        // The response from the remote device.
        private static String response = String.Empty;

        public Bomba()
        {
            InitializeComponent();
        }

        private void Bomba_Load(object sender, EventArgs e)
        {
            tipoVenda.SelectedIndex = 0;
            label4.Visible = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void tipoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex == 0)
            {
                label2.Visible = true;
                label4.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label4.Visible = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a TCP/IP socket.
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                client.Connect(remoteEP);
            }
            catch (Exception ge)
            {
                backgroundWorker1.CancelAsync();

                if (port++ == 11000)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    throw ge;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String data = String.Format("{0}|{1}", tipoVenda.Text, valor.Text);
            Send(client, data);

            Receive(client);
        }

        private void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            client.Send(byteData);
        }

        private void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;

                client.Receive(state.buffer);

                // All the data has arrived; put it in response.
                if (state.sb.Length > 1)
                {
                    response = state.sb.ToString();
                }

                if (response == "OK")
                {
                    MessageBox.Show("Venda concluída", "Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Venda cancelada", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
