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

            //List<State> states = new List<State>();
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/admin/location/states").Result;
                var responce = response.Content.ReadAsStringAsync().Result;
                Post post = JsonConvert.DeserializeObject<Post>(responce);
                foreach (State state in post.states)
                {
                    comboBoxState.Items.Add(state.state_id + "." + state.state_name);
                }
            }
            catch(AggregateException)
            {
                MessageBox.Show("exce");

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

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            SessionRoot sessionRoot = new SessionRoot();
            HttpClient client = new HttpClient();
            string district = (string)comboBoxDistrict.SelectedItem;
            string[] splittedString = district.Split('.');
            int id = Convert.ToInt32(splittedString[0]);



            HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByDistrict?district_id="+id+"&date=21-06-2021").Result;
            var responce = response.Content.ReadAsStringAsync().Result;
             sessionRoot = JsonConvert.DeserializeObject<SessionRoot>(responce);
            comboBoxDistrict.Text = "";
            int counter = 1;
            foreach (var item in sessionRoot.sessions)
            {

                listBox.Items.Add($"{counter}.{item.name} - {item.block_name}");
                
                counter++;
            }
            //foreach (var item in sessionRoot.sessions)
            //{

            // richTextBox.Text ="Centre ID:"+item.center_id +Environment.NewLine+ "Name:"+item.name + Environment.NewLine + "Address"+item.address + Environment.NewLine +"State:"+ item.state_name + Environment.NewLine +"District:"+ item.district_name + Environment.NewLine + item.block_name + Environment.NewLine + item.pincode + Environment.NewLine +"Pincode"+ item.pincode + Environment.NewLine + "From:"+item.from + Environment.NewLine + "To"+item.to + Environment.NewLine + "Latitude"+item.lat + Environment.NewLine +"Longitude"+ item.@long + Environment.NewLine +"Fee_Type" +item.fee_type + Environment.NewLine +"Session-ID"+ item.session_id + Environment.NewLine + "Date:"+item.date + Environment.NewLine +"Available-Capacity:"+ item.available_capacity + Environment.NewLine +"Capacity-Dose1:"+ item.available_capacity_dose1 + Environment.NewLine +"Capacity dose2:"+ item.available_capacity_dose2 + Environment.NewLine +"Fee:"+ item.fee + Environment.NewLine + "Age-Limit"+item.min_age_limit + Environment.NewLine +"Vaccine:"+ item.vaccine + Environment.NewLine + "Slots:"+item.slots;

            //}
        }

        private void btnClearDistrict_Click(object sender, EventArgs e)
        {
            comboBoxDistrict.SelectedIndex.Equals(String.Empty);
            comboBoxDistrict.DataSource = null;
            comboBoxDistrict.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox.Text = "";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Click(object sender, EventArgs e)
        {
            SessionRoot sessionRoot = new SessionRoot();
            HttpClient client = new HttpClient();
            string district = (string)comboBoxDistrict.SelectedItem;
            string[] splittedString = district.Split('.');
            int id = Convert.ToInt32(splittedString[0]);



            HttpResponseMessage response = client.GetAsync("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByDistrict?district_id=" + id + "&date=21-06-2021").Result;
            var responce = response.Content.ReadAsStringAsync().Result;
            sessionRoot = JsonConvert.DeserializeObject<SessionRoot>(responce);
            foreach (var item in sessionRoot.sessions)
            {
                richTextBox.Text = "Centre ID:" + item.center_id + Environment.NewLine + "Name:" + item.name + Environment.NewLine + "Address" + item.address + Environment.NewLine + "State:" + item.state_name + Environment.NewLine + "District:" + item.district_name + Environment.NewLine + item.block_name + Environment.NewLine + item.pincode + Environment.NewLine + "Pincode" + item.pincode + Environment.NewLine + "From:" + item.from + Environment.NewLine + "To" + item.to + Environment.NewLine + "Latitude" + item.lat + Environment.NewLine + "Longitude" + item.@long + Environment.NewLine + "Fee_Type" + item.fee_type + Environment.NewLine + "Session-ID" + item.session_id + Environment.NewLine + "Date:" + item.date + Environment.NewLine + "Available-Capacity:" + item.available_capacity + Environment.NewLine + "Capacity-Dose1:" + item.available_capacity_dose1 + Environment.NewLine + "Capacity dose2:" + item.available_capacity_dose2 + Environment.NewLine + "Fee:" + item.fee + Environment.NewLine + "Age-Limit" + item.min_age_limit + Environment.NewLine + "Vaccine:" + item.vaccine + Environment.NewLine + "Slots:" + item.slots;
            }
        }
    }
}
