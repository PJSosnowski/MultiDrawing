using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;

namespace MultiDrawingServer
{
    class Program
    {
        private static TcpListener listener;
        static void Main(string[] args)
        {
            startListening();

        }

        private static void startListening()
        {
            TcpListener serverSocket = new TcpListener(8888);
            TcpClient clientSocket = default(TcpClient);
            int cliendId = 0;

            Console.WriteLine("Statring server, waiting for connections");
            serverSocket.Start();

            while(true)
            {
                cliendId++;
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Client connected Id: " + cliendId.ToString());
                MultiDrawingServer.HandleClient client = new MultiDrawingServer.HandleClient();
                client.startClient(clientSocket, Convert.ToString(cliendId));
            }

        }


        Thread acceptConnections = new Thread(() => 
        {
            //byte[] bytes = new Byte[1024];
            //listener = new TcpListener(IPAddress.Any, 10250);

        });
    }
}
