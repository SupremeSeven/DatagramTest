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
        static StreamReader datagramText;
        static string schemaText;

        static void Main(string[] args)
        {
            ReadInputs();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Datagram));
                object obj = serializer.Deserialize(datagramText);
                Datagram data = (Datagram)obj;
                Console.WriteLine("Woohoo!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error converting: " + e.Message);
            }
            finally
            {
                datagramText.Close();
            }
        }
  
        static void ReadInputs()
        {
            try
            {
                //               datagramText = new StreamReader(@"..\..\Datagramv1.1.xml");
                datagramText = new StreamReader(@"..\..\TestDatagram.xml");
                schemaText = File.ReadAllText(@"..\..\datagramv1.1corrected.xsd");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading files " + e.Message);
            }
        }
    }
}
