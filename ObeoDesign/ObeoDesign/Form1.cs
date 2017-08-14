using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;

namespace ObeoDesign
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Travel_Tile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpawner.Route.Show();
            FormSpawner.Route.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

        }

        private void Saved_Tile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 savedPage = new Form4();
            savedPage.Show();
            savedPage.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

        }

     



    }
}
