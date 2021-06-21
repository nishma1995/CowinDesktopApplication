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
using Newtonsoft.Json.Linq;

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
            List<State> states = new List<State>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/admin/location/states").Result;
            var a = response.Content.ReadAsStringAsync().Result;
            Post post = JsonConvert.DeserializeObject<Post>(a);
            foreach (State state in post.states)
            {
                comboBoxState.Items.Add(state.state_id+"."+ state.state_name);
            }

            //var array = JArray.Parse(a);
            //states= JsonConvert.DeserializeObject<List<State>>(a);

            //richTextBoxResult.Text= response.Content.ReadAsStringAsync().Result;



        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Post post = new Post();
            HttpClient client = new HttpClient();
            string state = (string)comboBoxState.SelectedItem;
            string[] splittedString = state.Split('.');
           int id = Convert.ToInt32(splittedString[0]);



            HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/admin/location/districts/"+id+"").Result;
            var district = response.Content.ReadAsStringAsync().Result;
             DistrictRoot districtRoot = JsonConvert.DeserializeObject<DistrictRoot>(district);
            foreach (var item in districtRoot.districts)
            {
                comboBoxDistrict.Items.Add(item.district_id + "." + item.district_name);
            }
            //comboBoxDistrict.

        }
    }
}
