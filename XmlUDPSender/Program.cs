using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUDPSender
{
    class Program
    {
        private const int PORT = 11002;
        static void Main(string[] args)
        {
            XmlUDPSender m = new XmlUDPSender(PORT);
            m.start();

            Console.ReadKey();
        }
    }
}
