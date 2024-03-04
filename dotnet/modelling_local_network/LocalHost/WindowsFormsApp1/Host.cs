using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class Host
    {
        public uint IP = 0;
        public byte[] IP_
        {
            set
            {
                IP = (uint)(value[0] << (3 * 8) + value[1] << (2 * 8) + value[2] << 8 + value[3]);
            }
        }
        public byte[] Mac = new byte[6];

        public string MACString()
        {
            return Convert.ToString(Mac[0], 16) + ":" + Convert.ToString(Mac[1], 16) + ":" + Convert.ToString(Mac[2], 16) + ":" + Convert.ToString(Mac[3], 16) + ":" + Convert.ToString(Mac[4], 16) + ":" + Convert.ToString(Mac[5], 16);

        }

        public byte[] DefaultMAC(Host host)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                Mac[i] = Convert.ToByte(rnd.Next(0, 100));

            }
            return Mac;

        }

        [XmlIgnore]
        public Network Network { get; set; }

        public byte[] IP4(uint ip)
        {
            byte[] bytes = new byte[4];
            bytes[0] = (byte)((ip & 0xff000000) >> (3 * 8));
            bytes[1] = (byte)((ip & 0x00ff0000) >> (2 * 8));
            bytes[2] = (byte)((ip & 0x0000ff00) >> (1 * 8));
            bytes[3] = (byte)((ip & 0x000000ff));
            return bytes;
        }

        public string IP4String(uint ip)
        {
            byte[] bytes = IP4(ip);
            return bytes[0] + "." + bytes[1] + "." + bytes[2] + "." + bytes[3];

        }



        public string TypeNet;


        public uint DefaultIP(Network network)
        {
            Random rnd = new Random();
            uint value = Convert.ToUInt32(rnd.Next());
            value &= (~network.Mask);
            if (value == 0) { value = 1; }
            value += (network.IPNet & network.Mask);
            return value;

        }



        public override string ToString()
        {
            return "IP: " + this.IP4String(this.IP) + " Mac: " + this.MACString() + " Тип: " + this.TypeNet;
        }
    }
}
