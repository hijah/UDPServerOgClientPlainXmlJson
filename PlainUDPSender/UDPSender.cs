using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainUDPSender
{
    class UDPSender
    {
        private readonly int PORT;
        public UDPSender(int port)
        {
            PORT = port;
        }
        
        
        public void start()
        {
            using (UdpClient client = new UdpClient())
            {
                IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);
                Car car1 = new Car("Tesla", "red", "EL23400");
                byte[] buffer = Encoding.ASCII.GetBytes(car1.ToString());

                client.Send(buffer, buffer.Length, ModtagerEP);

            }
        }
    }
}
