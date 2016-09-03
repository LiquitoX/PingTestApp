using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;

namespace PingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e){
            listBox1.Items.Clear();
            for (int i = 0; i < 4; i++){
                using (Ping p = new Ping()){
                    listBox1.Items.Add("Ping is: " + p.Send(hostName.Text).RoundtripTime.ToString() + "ms\n");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pingTest();
        }

        private void hostIP1_Enter(object sender, EventArgs e){
            hostIP1.SelectAll();
        }
        private void hostIP2_Enter(object sender, EventArgs e){
            hostIP2.SelectAll();
        }
        private void hostIP3_Enter(object sender, EventArgs e){
            hostIP3.SelectAll();
        }
        private void hostIP4_Enter(object sender, EventArgs e){
            hostIP4.SelectAll();
        }

        private void hostIP4_TextChanged(object sender, EventArgs e){
            int len = hostIP4.TextLength;
            if (len >= 3){
                pingTest();
                hostIP1.Focus();
            }
        }


        private void pingTest()
        {
            string ip =
                hostIP1.Text + "." +
                hostIP2.Text + "." +
                hostIP3.Text + "." +
                hostIP4.Text;
            Ping ping = new Ping();

            PingReply pingStatus = ping.Send(IPAddress.Parse(ip));

            if (pingStatus.Status == IPStatus.Success)
            {
                listBox1.Items.Add("Ping to " + ip + " was successful");
            }
            else
            {
                listBox1.Items.Add("Ping has Failed!");
            }
        }

        private void hostIP3_TextChanged(object sender, EventArgs e)
        {
            int len = hostIP3.TextLength;
            if (len >= 3)
            {
                hostIP4.Focus();
            }
        }

        private void hostIP2_TextChanged(object sender, EventArgs e)
        {
            int len = hostIP2.TextLength;
            if (len >= 3)
            {
                hostIP3.Focus();
            }
        }

        private void hostIP1_TextChanged(object sender, EventArgs e)
        {
            int len = hostIP1.TextLength;
            if (len >= 3)
            {
                hostIP2.Focus();
            }
        }
    }
}
