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

namespace Caixa
{
    public partial class Caixa : Form
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        private IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
        private IPAddress ipAddress;
        private IPEndPoint bomba1EndPoint;
        private IPEndPoint bomba2EndPoint;

        public Caixa()
        {
            InitializeComponent();
            ipAddress = ipHostInfo.AddressList[0];
            bomba1EndPoint = new IPEndPoint(ipAddress, 11000);
            bomba2EndPoint = new IPEndPoint(ipAddress, 12000);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void definePreco_Click(object sender, EventArgs e)
        {
            if (precoGasolina.Text.Length > 0)
            {
                using (var context = new BombasContext())
                {
                    Preco novoPreco = new Preco();
                    DateTime data = DateTime.Now;
                    novoPreco.valor = Convert.ToDecimal(precoGasolina.Text);
                    novoPreco.data = data.ToString();

                    context.Precos.Add(novoPreco);

                    context.SaveChanges();
                }
                
            }
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            bomba1.RunWorkerAsync();
        }

        private void bomba1_DoWork(object sender, DoWorkEventArgs e)
        {
            Socket listener = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream, 
                ProtocolType.Tcp
            );

            listener.Bind(bomba1EndPoint);
            listener.Listen(1);
        }

        private void bomba2_DoWork(object sender, DoWorkEventArgs e)
        {
            Socket listener = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            listener.Bind(bomba2EndPoint);
            listener.Listen(1);
            Socket handler = listener.Accept();
            handler.BeginReceive(
                state.buffer, 0, StateObject.BufferSize, 0,
            new AsyncCallback(ReadCallback), state);
        }

        private void bomba1Paga_Click(object sender, EventArgs e)
        {

        }
    }
}
