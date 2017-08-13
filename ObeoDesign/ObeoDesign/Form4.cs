using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ObeoDesign
{
    public partial class Form4 : MetroFramework.Forms.MetroForm 
    {
        public Form4()
        {
            InitializeComponent();

            fillLabels();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            
        }


        private async void fillLabels() {
            ObeoRestClient o = new ObeoRestClient("http://www.endy.co.uk/journeys.php?num=4");
            FormSpawner.urlResponse = await o.GetRequest();
            RootObjectJourney obj = JsonConvert.DeserializeObject<RootObjectJourney>(FormSpawner.urlResponse);
            DataLabel1.Text = "Journey - " + "1 -" + "| Origin " + obj.Journeys[0].ORIGIN + "| Destination " + obj.Journeys[0].DESTINATION + "| Distance " + obj.Journeys[0].DISTANCE + "| Duration " + obj.Journeys[0].DURATION + "| Mode of Transport " + obj.Journeys[0].MODE;
            DataLabel2.Text = "Journey - " + "2 -" + "| Origin " + obj.Journeys[1].ORIGIN + "| Destination " + obj.Journeys[1].DESTINATION + "| Distance " + obj.Journeys[1].DISTANCE + "| Duration " + obj.Journeys[1].DURATION + "| Mode of Transport " + obj.Journeys[1].MODE;
            DataLabel3.Text = "Journey - " + "3 -" + "| Origin " + obj.Journeys[2].ORIGIN + "| Destination " + obj.Journeys[2].DESTINATION + "| Distance " + obj.Journeys[2].DISTANCE + "| Duration " + obj.Journeys[2].DURATION + "| Mode of Transport " + obj.Journeys[2].MODE;
            DataLabel4.Text = "Journey - " + "4 -" + "| Origin " + obj.Journeys[3].ORIGIN + "| Destination " + obj.Journeys[3].DESTINATION + "| Distance " + obj.Journeys[3].DISTANCE + "| Duration " + obj.Journeys[3].DURATION + "| Mode of Transport " + obj.Journeys[3].MODE;
        }

        private void Home_Tile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpawner.Home.Show();
            FormSpawner.Home.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }
    }
}
