using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerSide
{
    public class Server
    {
        public List<ClientHandler> clients = new List<ClientHandler>();

        private Socket serverSocket;

        public bool isServerOn = false;

        private static Server instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        public void StartServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"])));
                serverSocket.Listen(10);

                isServerOn = true;

                Thread t = new Thread(() => ReceiveRequests());
                t.IsBackground = true;
                t.Start();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ReceiveRequests()
        {
            try
            {
                while(isServerOn)
                {
                    Socket clientSocket=serverSocket.Accept();
                    ClientHandler clientHandler = new ClientHandler(clientSocket);
                    clients.Add(clientHandler);
                    Thread t = new Thread(() => clientHandler.HandleRequests());
                    t.IsBackground = true;
                    t.Start();
                }
            }
            catch(Exception ex) 
            {

            }
        }

        public void StopServer()
        {
            try
            {
                serverSocket.Close();
                isServerOn = false;

                foreach (ClientHandler client in clients)
                {
                    client.StopSocket();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
