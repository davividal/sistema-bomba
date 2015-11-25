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

            listener.Bind(bomba1EndPoint);
            listener.Listen(1);

            while (true)
            {
                // Set the event to nonsignaled state.
                allDone.Reset();

                // Create the state object.
                StateObject state = new StateObject();
                state.bomba = bomba1;
                state.workSocket = listener;

                // Start an asynchronous socket to listen for connections.
                listener.BeginAccept(
                    new AsyncCallback(AcceptCallback),
                    state
                );

                // Wait until a connection is made before continuing.
                allDone.WaitOne();
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
                // Set the event to nonsignaled state.
                allDone.Reset();

                // Create the state object.
                StateObject state = new StateObject();
                state.bomba = bomba1;
                state.workSocket = listener;

                // Start an asynchronous socket to listen for connections.
                listener.BeginAccept(
                    new AsyncCallback(AcceptCallback),
                    state
                );

                // Wait until a connection is made before continuing.
                allDone.WaitOne();
            }
        }

        private void bomba1Paga_Click(object sender, EventArgs e)
        {
            if (valorAbastecidoBomba1.Text.Length > 0)
            {
                using (var context = new BombasContext())
                {
                    Preco preco = new Preco();
                    Venda qtdeLitros = new Venda();
                    DateTime data = DateTime.Now;
                    string format = "d/m/yyyy";
                    qtdeLitros.litros = Convert.ToDecimal(valorAbastecidoBomba1.Text);
                    preco.data = data.ToString(format);

                    context.Precos.Find(precoGasolina);
                        //.Add(qtdeLitros);
                    
                    Bomba bomba = context.Bombas
                        .Find(preco.data);

                    Venda venda = new Venda();
                    venda.bomba = bomba;
                    venda.preco = preco;

                    context.Precos.Add(preco);
                    context.Vendas.Add(venda);

                    context.SaveChanges();
                }
            }
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();

            StateObject state = (StateObject)ar.AsyncState;

            // Get the socket that handles the client request.
            Socket listener = state.handler;
            Socket handler = listener.EndAccept(ar);
            state.workSocket = handler;

            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket. 
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read 
                // more data.
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the 
                    // client. Display it on the console.
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    // Echo the data back to the client.
                    state.bomba.ReportProgress(0, state);
                }
                else
                {
                    // Not all data received. Get more.
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void bomba1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StateObject so = (StateObject)e.UserState;
            valorAbastecidoBomba1.Text = so.sb.ToString();
        }
    }
}
