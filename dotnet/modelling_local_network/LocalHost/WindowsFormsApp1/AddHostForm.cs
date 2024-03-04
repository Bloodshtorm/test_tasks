using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddhostForm : Form
    {
        public Host host;

        public AddhostForm(Host host)
        {
            InitializeComponent();

            this.host = host;


        }



        private void default_Click(object sender, EventArgs e)
        {
            host.IP = host.DefaultIP(host.Network);
            host.Mac = host.DefaultMAC(host);
            iphosttext.Text = host.IP4String(host.IP);
            maadress.Text = host.MACString();
            typeconnect.SelectedItem = host.TypeNet;
        }

        private void add_Click(object sender, EventArgs e)
        {
            host.IP = 0;
            var ip = iphosttext.Text.Split('.');
            for (int i = 0; i < ip.Length; i++)
            {
                host.IP = (host.IP << 8) + Convert.ToUInt32(ip[i]);
            }
            var mac = maadress.Text.Split(':');
            for (int i = 0; i < mac.Length; i++)
            {
                host.Mac[i] = Convert.ToByte(mac[i], 16);
            }
            host.TypeNet = typeconnect.SelectedItem.ToString();

            for (int i = 0; i < host.Network.Hosts.Count; i++)
            {
                if (host != host.Network.Hosts[i] &&
                    host.IP == host.Network.Hosts[i].IP)
                {
                    MessageBox.Show("идентичные хосты");
                    return;
                }
            }

            Close();
        }
    }
}
