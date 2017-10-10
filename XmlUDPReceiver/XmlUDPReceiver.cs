using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlUDPReceiver
{
    class XmlUDPReceiver
    {
        private readonly int PORT;

        public XmlUDPReceiver(int port)
        {
            PORT = port;
        }

        public void start()
        {
            using (UdpClient client = new UdpClient(PORT))
            {
                IPEndPoint AfsenderEP = new IPEndPoint(IPAddress.Loopback, 0);
                byte[] receiver = client.Receive(ref AfsenderEP);

                string modtagetstr = Encoding.ASCII.GetString(receiver);

                Console.WriteLine(modtagetstr);

                XmlSerializer xs = new XmlSerializer(typeof(Car));
                StringReader sr = new StringReader(modtagetstr);
                Car obj = (Car)xs.Deserialize(sr);
                

                Console.WriteLine(obj);
            }
        }



    }
}
