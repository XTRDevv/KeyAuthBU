using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuthBU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string response;
            string fullpath = metroTextBox2.Text;
            string sellerkey = metroTextBox1.Text;
            //chats
            if(metroToggle1.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallchats");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/chat.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //subscriptions
            if (metroToggle2.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallsubs");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath += "/subscriptions.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //users
            if (metroToggle3.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchalluservars");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/users.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //licenses
            if (metroToggle4.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallkeys");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/licenses.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //variables
            if (metroToggle5.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallvars");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/variables.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //files
            if (metroToggle6.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallfiles");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/files.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //blacklists
            if (metroToggle7.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallblacks");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/blacklists.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
            //sessions
            if (metroToggle8.Checked)
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create("https://keyauth.win/api/seller/?sellerkey=" + sellerkey + "&type=fetchallsessions");
                hwr.Method = "GET";
                HttpWebResponse hwbr = (HttpWebResponse)hwr.GetResponse();
                Stream dataStream = hwbr.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                response = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(fullpath + "/sessions.txt"))
                {
                    writer.WriteLine(response);
                    writer.Close();
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
