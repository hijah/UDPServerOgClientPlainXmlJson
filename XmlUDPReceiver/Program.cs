﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUDPReceiver
{
    class Program
    {
        private const int PORT = 11002;
        static void Main(string[] args)
        {
            XmlUDPReceiver m = new XmlUDPReceiver(PORT);
            m.start();

            Console.ReadKey();
        }
    }
}
