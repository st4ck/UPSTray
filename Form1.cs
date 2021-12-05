using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPSTray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
            Opacity = 0;

            Login();

            if (bearer != null)
            {
                timer1.Interval = 5000;
                timer1.Start();
                timer1_Tick(sender, e);
            }
        }

        String bearer = null;

        void Login()
        {
            var client = new RestClient("http://localhost:3052/local/rest/v1/login/verify");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{""userName"":""admin"",""password"":""admin""}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var x = response.Content.Split(' ');
            
            if (x[0].Trim('"') == "Bearer")
            {
                bearer = x[1].Trim('"');
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:3052/local/rest/v1/ups/status");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer "+bearer);            
            IRestResponse response = client.Execute(request);

            var obj = JsonConvert.DeserializeObject<dynamic>(response.Content);

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = "";
            provider.NumberGroupSizes = new int[] { 3 };


            String battery_voltage = obj["battery"]["voltage"];
            double b_volt = Convert.ToDouble(battery_voltage.Split(' ')[0], provider);
            String load = obj["output"]["loads"][0];
            double power_perc = Convert.ToDouble(load.Split(' ')[0], provider);
            int battery_state = obj["battery"]["state"];
            int input_state = obj["input"]["state"];
            String input_voltage = obj["input"]["voltages"][0];
            double i_volt = Convert.ToDouble(input_voltage.Split(' ')[0], provider);

            if (input_state == 1) //blackout
            {
                
                b_volt -= 6.1;
                if (b_volt >= 12.3)
                {
                    notifyIcon1.Icon = Properties.Resources.battery_full;
                } else if (b_volt >= 12.2)
                {
                    notifyIcon1.Icon = Properties.Resources.battery_half;
                }
                else if (b_volt >= 11.9)
                {
                    notifyIcon1.Icon = Properties.Resources.battery_third;
                }
                else
                {
                    notifyIcon1.Icon = Properties.Resources.battery_empty;
                }

                contextMenuStrip1.Items[3].Text = "Status: Blackout";
            } else // normal
            {
                b_volt -= 6.6;
                notifyIcon1.Icon = Properties.Resources.battery_charge;
                contextMenuStrip1.Items[3].Text = "Status: Charging";
            }


            contextMenuStrip1.Items[2].Text = "Battery: " + b_volt + "V";
            contextMenuStrip1.Items[0].Text = "Load: " + (480 * power_perc / 100) + "W (480W)";
            contextMenuStrip1.Items[4].Text = "Charge: 100%";
        }

        private void timeRemainingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
