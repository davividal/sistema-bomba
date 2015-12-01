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
        private StateObject sBomba1;
        private StateObject sBomba2;

        private IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
        private IPAddress ipAddress;
        private IPEndPoint bomba1EndPoint;
        private IPEndPoint bomba2EndPoint;

        public Caixa()
        {
            InitializeComponent();
            ipAddress = ipHostInfo.AddressList[0];
            bomba1EndPoint = new IPEndPoint(ipAddress, 11000);
            bomba2EndPoint = new IPEndPoint(ipAddress, 11001);
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
            valorAbastecidoBomba1.Text = "";
            valorAbastecidoBomba2.Text = "";
            fechamento.Text = "Sem informações suficientes";

            bomba1Status.Text = "Bomba 1 desconectada";
            bomba2Status.Text = "Bomba 2 desconectada";

            bomba1.RunWorkerAsync();
            bomba2.RunWorkerAsync();
        }

        private void bomba1_DoWork(object sender, DoWorkEventArgs e)
        {
            Socket listener = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream, 
                ProtocolType.Tcp
            );

            String data = null;

            listener.Bind(bomba1EndPoint);
            listener.Listen(1);

            // Create the state object.
            sBomba1 = new StateObject();
            sBomba1.bomba = bomba1;
            sBomba1.workSocket = listener;

            while (true)
            {
                listener.Accept();
                bomba1Status.Text = "Bomba 1 conectada";

                while (true)
                {
                    int bytesRec = listener.Receive(sBomba1.buffer);
                    data += Encoding.ASCII.GetString(sBomba1.buffer, 0, bytesRec);
                    bomba1.ReportProgress(1, sBomba1);
                }
            }
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

            while (true)
            {
                // Create the state object.
                sBomba2 = new StateObject();
                sBomba2.bomba = bomba1;
                sBomba2.workSocket = listener;

                listener.Accept();
                bomba1Status.Text = "Bomba 2 conectada";
            }
        }

        private void bomba1Paga_Click(object sender, EventArgs e)
        {
            if (valorAbastecidoBomba1.Text.Length > 0)
            {
                salvaVenda(valorAbastecidoBomba1.Text, 1);
                Send(sBomba1.workSocket, "OK");
            }
        }

        private void bomba2Paga_Click(object sender, EventArgs e)
        {
            if (valorAbastecidoBomba2.Text.Length > 0)
            {
                salvaVenda(valorAbastecidoBomba2.Text, 2);
                Send(sBomba2.workSocket, "OK");
            }
        }

        private void salvaVenda(string valor, int bombaId)
        {
            using (var context = new BombasContext())
            {
                Preco preco = fetchPreco();
                Bomba bomba = context.Bombas.Find(bombaId);

                Venda venda = new Venda();
                venda.bomba = bomba;
                venda.preco = preco;
                venda.litros = Convert.ToDecimal(valor) / preco.valor;

                context.Vendas.Add(venda);

                context.SaveChanges();
            }
        }

        private void Send(Socket handler, String data)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data);

            handler.Send(msg);
        }

        private void bomba1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StateObject so = (StateObject)e.UserState;
            valorAbastecidoBomba1.Text = Convert.ToString(valor(so.sb.ToString()));
        }

        private Decimal valor(String data)
        {
            Decimal total, valor;
            String tipo;
            tipo = data.Split('|')[0];
            valor = Convert.ToDecimal(data.Split('|')[1]);
            if (tipo == "Litros")
            {
                total = valor * fetchPreco().valor;
            }

            return valor;
        }

        private Preco fetchPreco()
        {
            Preco preco;

            using (var context = new BombasContext())
            {
                DateTime data = DateTime.Now;
                preco = context.Precos.Where(p => p.data == data.ToShortDateString()).FirstOrDefault();
            }

            return preco;
        }

        private void bomba1Cancelada_Click(object sender, EventArgs e)
        {
            valorAbastecidoBomba1.Text = "";
            Send(sBomba1.workSocket, "NOK");
        }

        private void bomba2Cancelada_Click(object sender, EventArgs e)
        {
            valorAbastecidoBomba2.Text = "";
            Send(sBomba1.workSocket, "NOK");
        }
    }
}
