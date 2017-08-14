using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObeoDesign
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        //Parameters
        String url = "https://maps.googleapis.com/maps/api/distancematrix/json?";
        String API_KEY = "&key=AIzaSyDOyS263waxSPC1syxc0SPu-vDQkCjufCw";
        String units = "&units=imperial";
        String origin = "&origins=";
        String destination = "&destinations=";
        String mode = "&mode=";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Home_Tile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpawner.Home.Show();
            FormSpawner.Home.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void MethodCar_Tile_Click(object sender, EventArgs e)
        {
            Method_Tile.Text = "Driving";
        }

        private void MethodBike_Tile_Click(object sender, EventArgs e)
        {
            Method_Tile.Text = "Bicycling";
        }

        private void MethodWalk_Tile_Click(object sender, EventArgs e)
        {
            Method_Tile.Text = "Walking";
        }

        private void Origin_TextBox_Click(object sender, EventArgs e)
        {
            Origin_TextBox.Text = "";
        }

        private void Destination_TextBox_Click(object sender, EventArgs e)
        {
            Destination_TextBox.Text = "";
        }

        private async void Execute_Tile_Click(object sender, EventArgs e)
        {
            reInitalise();
            origin = origin + Origin_TextBox.Text.ToLower();
            destination = destination + Destination_TextBox.Text.ToLower();
            mode = mode + Method_Tile.Text.ToLower();
            url = url + units + origin + destination + mode + API_KEY;

            //MessageBox.Show(url);

            ObeoRestClient o = new ObeoRestClient(url);
            String response = await o.GetRequest();
          //  MessageBox.Show(response);
            FormSpawner.urlResponse = response;
            FormSpawner.mode = Method_Tile.Text;
            Form3 resultsPage = new Form3();
            resultsPage.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
            resultsPage.Show(); 
        }

        private void Reset_Tile_Click(object sender, EventArgs e)
        {
            Origin_TextBox.Text = "";
            Destination_TextBox.Text = "";
            Method_Tile.Text = "";
        }

        private void Switch_Tile_Click(object sender, EventArgs e)
        {
            String temp;
            temp = Origin_TextBox.Text;
            Origin_TextBox.Text = Destination_TextBox.Text;
            Destination_TextBox.Text = temp;
        }

        private void reInitalise() {
           url = "https://maps.googleapis.com/maps/api/distancematrix/json?";
           API_KEY = "&key=AIzaSyDOyS263waxSPC1syxc0SPu-vDQkCjufCw";
           units = "&units=imperial";
           origin = "&origins=";
           destination = "&destinations=";
           mode = "&mode=";
        }
    }
}
