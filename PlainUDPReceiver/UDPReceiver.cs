using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver
{
    class UDPReceiver
    {
        private readonly int PORT;

        public UDPReceiver(int port)
        {
            this.PORT = port;
        }
        public void start()
        {
            using (UdpClient client = new UdpClient(PORT))
            {
                IPEndPoint AfsendersEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiver = client.Receive(ref AfsendersEP);

                string modtagetstr = Encoding.ASCII.GetString(receiver);

                Console.WriteLine(modtagetstr);

            }
        }
    }
}
