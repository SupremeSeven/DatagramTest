using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace DatagramTest
{
    class Program
    {
        static Datagram data;

        static void Main()
        {
            using (StreamReader datagramReader = new StreamReader(@"..\..\TestDatagram.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Datagram));
                data = (Datagram)serializer.Deserialize(datagramReader);
            }

            Console.WriteLine("Woohoo!");
        }
  
    }
}
