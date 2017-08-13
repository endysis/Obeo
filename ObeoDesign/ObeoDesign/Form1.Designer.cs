namespace ObeoDesign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Travel_Tile = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.Members_Tile = new MetroFramework.Controls.MetroTile();
            this.Saved_Tile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Travel_Tile
            // 
            this.Travel_Tile.Location = new System.Drawing.Point(23, 63);
            this.Travel_Tile.Name = "Travel_Tile";
            this.Travel_Tile.Size = new System.Drawing.Size(252, 244);
            this.Travel_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Travel_Tile.TabIndex = 0;
            this.Travel_Tile.Text = "Plan your Route";
            this.Travel_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Travel_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Travel_Tile.Click += new System.EventHandler(this.Travel_Tile_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(281, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(504, 244);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Plan your Accommodation";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // Members_Tile
            // 
            this.Members_Tile.Location = new System.Drawing.Point(23, 313);
            this.Members_Tile.Name = "Members_Tile";
            this.Members_Tile.Size = new System.Drawing.Size(629, 225);
            this.Members_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Members_Tile.TabIndex = 2;
            this.Members_Tile.Text = "View Holiday Members";
            this.Members_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Members_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // Saved_Tile
            // 
            this.Saved_Tile.Location = new System.Drawing.Point(658, 313);
            this.Saved_Tile.Name = "Saved_Tile";
            this.Saved_Tile.Size = new System.Drawing.Size(127, 225);
            this.Saved_Tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.Saved_Tile.TabIndex = 3;
            this.Saved_Tile.Text = "Saved Routes";
            this.Saved_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Saved_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Saved_Tile.Click += new System.EventHandler(this.Saved_Tile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 561);
            this.Controls.Add(this.Saved_Tile);
            this.Controls.Add(this.Members_Tile);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.Travel_Tile);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Obeo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Travel_Tile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile Members_Tile;
        private MetroFramework.Controls.MetroTile Saved_Tile;
    }
}

