using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class LocalForm : Form
    {
        Network network;


        public LocalForm()
        {
            InitializeComponent();
            network = new Network();
            network.Mask = 0xffff0000;
            network.IPNet = 0xc0a80000;
            network.Gate = 0xc0a80001;
            ipnet.Text = network.IP4String(network.IPNet);
            mask.Text = network.IP4String(network.Mask);
            gate.Text = network.IP4String(network.Gate);
            max.Text = network.HostsCount.ToString();
            realhost.Text = listhost.Items.Count.ToString();


        }

        void UpdateDataSource()
        {
            listhost.DataSource = null;
            listhost.DataSource = network.Hosts;
            max.Text = network.HostsCount.ToString();
            realhost.Text = listhost.Items.Count.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (network.HostsCount < listhost.Items.Count)
            {
                MessageBox.Show("превышено количество хостов в подсети");
                return;
            }
            Host host = new Host();
            network.Hosts.Add(host);
            host.Network = network;
            new AddhostForm(host).Show();


        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            network.Hosts.RemoveAt(listhost.SelectedIndex);
            UpdateDataSource();

        }

        private void change_Click_1(object sender, EventArgs e)
        {
            network.Mask = 0;
            var ip = mask.Text.Split('.');
            for (int i = 0; i < ip.Length; i++)
            {
                network.Mask = (network.Mask << 8) + Convert.ToUInt32(ip[i]);
            }
            UpdateDataSource();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            XmlSerializer serializer = new XmlSerializer(typeof(Network));
            using (FileStream save = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                serializer.Serialize(save, network);
            }

        }

        private void load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            XmlSerializer serializer = new XmlSerializer(typeof(Network));
            using (FileStream open = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                network = (Network)serializer.Deserialize(open);
                for (int i = 0; i < network.Hosts.Count; i++)
                {
                    network.Hosts[i].Network = network;
                }
            }
            UpdateDataSource();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateDataSource();

        }

        private void About_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
