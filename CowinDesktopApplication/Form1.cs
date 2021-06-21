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
            comboBoxDistrict.Text = "";
            foreach (var item in districtRoot.districts)
            {
               
                comboBoxDistrict.Items.Add(item.district_id + "." + item.district_name);
               
            }
           
            //comboBoxDistrict.

        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string district = (string)comboBoxDistrict.SelectedItem;
            string[] splittedString = district.Split('.');
            int id = Convert.ToInt32(splittedString[0]);



            HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByDistrict?district_id="+id+"&date=31-03-2021").Result;
            var responce = response.Content.ReadAsStringAsync().Result;
            SessionRoot sessionRoot = JsonConvert.DeserializeObject<SessionRoot>(responce);
            comboBoxDistrict.Text = "";
            foreach (var item in sessionRoot.sessions)
            {

                richTextBoxResult.Text = item.center_id + item.name + item.address + item.state_name + item.district_name + item.block_name + item.pincode + item.pincode + item.from + item.to + item.lat + item.@long + item.fee_type + item.session_id + item.date + item.available_capacity + item.available_capacity_dose1 + item.available_capacity_dose2 + item.fee + item.min_age_limit + item.vaccine + item.slots;

            }
        }
    }
}
