using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace MultiDrawingServer
{
    class HandleClient
    {
        TcpClient clientSocket;
        string clientId;
        public void startClient(TcpClient inClientSocket, string cliendId)
        {
            this.clientSocket = inClientSocket;
            this.clientId = cliendId;
            Thread ctThread = new Thread(reciveCoordinates);
            ctThread.Start();
        }
        private void reciveCoordinates()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;


            KeyValuePair<int, int> coordinatesPair;
            List<KeyValuePair<int, int>> drawingCoordinates;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();

                    var binFormatter = new BinaryFormatter();

                    drawingCoordinates = (List<KeyValuePair<int, int>>)binFormatter.Deserialize(networkStream);
                    //networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    //dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    //dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    //Console.WriteLine(" >> " + "From client-" + clNo + dataFromClient);

                    //rCount = Convert.ToString(requestCount);
                    //serverResponse = "Server to clinet(" + clNo + ") " + rCount;
                    //sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    //networkStream.Write(sendBytes, 0, sendBytes.Length);
                    //networkStream.Flush();
                    //Console.WriteLine(" >> " + serverResponse);


                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    }
}
