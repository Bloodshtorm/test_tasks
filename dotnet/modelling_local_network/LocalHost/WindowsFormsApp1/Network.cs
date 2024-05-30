using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Network
    {
        public uint IPNet;
        public byte[] IPNet_
        {
            set
            {
                IPNet = (uint)(value[0] << (3 * 8) + value[1] << (2 * 8) + value[2] << 8 + value[3]);
            }
        }
        public uint Mask;
        public byte[] Mask_
        {
            set
            {
                Mask = (uint)(value[0] << (3 * 8) + value[1] << (2 * 8) + value[2] << 8 + value[3]);
            }
        }
        public uint Gate;
        public byte[] Gate_
        {
            set
            {
                Gate = (uint)(value[0] << (3 * 8) + value[1] << (2 * 8) + value[2] << 8 + value[3]);
            }

        }

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

        public uint HostsCount
        {
            get
            {
                return ~Mask - 1;
            }
        }

        public Network()
        {
            Hosts = new List<Host>();
        }
        public List<Host> Hosts { get; set; }
        public void Addhost(Host host)
        {
            if (!Hosts.Contains(host)) { Hosts.Add(host); }
        }



        public void RemoveHost(Host host)
        {
            if (Hosts.Contains(host)) { Hosts.Remove(host); }
        }

        public Host Host
        {
            get => default;
            set
            {
            }
        }
    }
}
