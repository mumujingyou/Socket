using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SocketProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,
                ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any,9999);
            socket.Bind(endPoint);
        }
    }
}
