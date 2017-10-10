using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlUDPSender
{
    class XmlUDPSender
    {
        private readonly int PORT;

        public XmlUDPSender(int port)
        {
            PORT = port;
        }

        public void start()
        {
            using (UdpClient client = new UdpClient())
            {
                IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);
                Car car1 = new Car("Tesla", "red", "EL23400");
                

                XmlSerializer xs = new XmlSerializer(typeof(Car));
                StringWriter sw = new StringWriter();
                xs.Serialize(sw, car1);

                byte[] buffer = Encoding.ASCII.GetBytes(car1.ToString());

                client.Send(buffer, buffer.Length, ModtagerEP);

            }
        }

    }
}
