using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace CowinDesktopApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/admin/location/states").Result;
            var a= response.Content.ReadAsStringAsync().Result;
            var states = JsonConvert.DeserializeObject<State>(a);
            //richTextBoxResult.Text= response.Content.ReadAsStringAsync().Result;
            
            
        }
    }
}
