using System;
using Newtonsoft.Json;
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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        Route r;
        
        
        public Form3()
        {
            InitializeComponent();
            r = new Route();
            JSONObject obj = JsonConvert.DeserializeObject<JSONObject>(FormSpawner.urlResponse);
            r.Origin = obj.origin_addresses[0];
            r.Destination = obj.destination_addresses[0];
            r.Distance = obj.rows[0].elements[0].distance.text;
            r.Duration = obj.rows[0].elements[0].duration.text;
            r.Mode = FormSpawner.mode;
            Origin_Label.Text = r.Origin;
            Destination_Label.Text = r.Destination;
            Distance_Label.Text = r.Distance;
            Duration_Label.Text = r.Duration + " if " + FormSpawner.mode.ToLower();   
        }

    


        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Home_Tile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpawner.Home.Show();
            FormSpawner.Home.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void Save_Tile_Click(object sender, EventArgs e)
        {
            ObeoRestClient o = new ObeoRestClient("http://www.endy.co.uk/journeys.php");
            o.PostRequest(r);
            this.Hide();
            MessageBox.Show("Journey Saved");
            FormSpawner.Home.Show();
            FormSpawner.Home.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }
    }
}
