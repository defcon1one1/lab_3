using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace lab_3.Logger
{
    public class SocketLogger : ILogger
    {

        private ClientSocket clientSocket;
        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }
        ~SocketLogger()
        {
            clientSocket.Dispose();
        }
        public void Log(params string[] messages)
        {

            foreach (var message in messages)
            {
                byte[] requestBytes = Encoding.UTF8.GetBytes(message);
                clientSocket.Send(requestBytes);
            }


        }
     

        public void Dispose()
        {
            clientSocket.Close();
        }


    }
}
