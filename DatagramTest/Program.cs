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
        static Stream datagramText;
        static string schemaText;

        static void Main(string[] args)
        {
            ReadInputs();
            XmlSerializer serializer = new XmlSerializer(typeof(Datagram));
            Datagram data = (Datagram)serializer.Deserialize(datagramText);
        }
  
        static void ReadInputs()
        {
            try
            {
                datagramText = new FileStream(@".\datagram.txt", FileMode.Open);
                schemaText = File.ReadAllText(@".\datagram_Schema.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading files " + e.Message);
            }
        }
    }
}
