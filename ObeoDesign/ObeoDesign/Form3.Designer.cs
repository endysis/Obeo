namespace ObeoDesign
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.Duration_Label = new MetroFramework.Controls.MetroLabel();
            this.Distance_Label = new MetroFramework.Controls.MetroLabel();
            this.Destination_Label = new MetroFramework.Controls.MetroLabel();
            this.Origin_Label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Destination = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Home_Tile = new MetroFramework.Controls.MetroTile();
            this.Save_Tile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ObeoDesign.Properties.Resources.world_map_png_35418;
            this.pictureBox1.Location = new System.Drawing.Point(257, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 475);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.Duration_Label);
            this.metroPanel2.Controls.Add(this.Distance_Label);
            this.metroPanel2.Controls.Add(this.Destination_Label);
            this.metroPanel2.Controls.Add(this.Origin_Label);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.Destination);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(330, 314);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Duration_Label
            // 
            this.Duration_Label.AutoSize = true;
            this.Duration_Label.Location = new System.Drawing.Point(32, 283);
            this.Duration_Label.Name = "Duration_Label";
            this.Duration_Label.Size = new System.Drawing.Size(33, 19);
            this.Duration_Label.TabIndex = 10;
            this.Duration_Label.Text = "N/A";
            this.Duration_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Distance_Label
            // 
            this.Distance_Label.AutoSize = true;
            this.Distance_Label.Location = new System.Drawing.Point(32, 212);
            this.Distance_Label.Name = "Distance_Label";
            this.Distance_Label.Size = new System.Drawing.Size(33, 19);
            this.Distance_Label.TabIndex = 9;
            this.Distance_Label.Text = "N/A";
            this.Distance_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Destination_Label
            // 
            this.Destination_Label.AutoSize = true;
            this.Destination_Label.Location = new System.Drawing.Point(32, 133);
            this.Destination_Label.Name = "Destination_Label";
            this.Destination_Label.Size = new System.Drawing.Size(33, 19);
            this.Destination_Label.TabIndex = 8;
            this.Destination_Label.Text = "N/A";
            this.Destination_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Origin_Label
            // 
            this.Origin_Label.AutoSize = true;
            this.Origin_Label.Location = new System.Drawing.Point(32, 45);
            this.Origin_Label.Name = "Origin_Label";
            this.Origin_Label.Size = new System.Drawing.Size(33, 19);
            this.Origin_Label.TabIndex = 7;
            this.Origin_Label.Text = "N/A";
            this.Origin_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(3, 249);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Duration";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(5, 174);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Distance";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Destination.Location = new System.Drawing.Point(3, 91);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(97, 25);
            this.Destination.TabIndex = 4;
            this.Destination.Text = "Destination";
            this.Destination.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Origin";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Home_Tile
            // 
            this.Home_Tile.Location = new System.Drawing.Point(23, 383);
            this.Home_Tile.Name = "Home_Tile";
            this.Home_Tile.Size = new System.Drawing.Size(160, 155);
            this.Home_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Home_Tile.TabIndex = 3;
            this.Home_Tile.Text = "Go To Home";
            this.Home_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Home_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Home_Tile.Click += new System.EventHandler(this.Home_Tile_Click);
            // 
            // Save_Tile
            // 
            this.Save_Tile.Location = new System.Drawing.Point(189, 383);
            this.Save_Tile.Name = "Save_Tile";
            this.Save_Tile.Size = new System.Drawing.Size(164, 155);
            this.Save_Tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.Save_Tile.TabIndex = 4;
            this.Save_Tile.Text = "Save Route";
            this.Save_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Save_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Save_Tile.Click += new System.EventHandler(this.Save_Tile_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 561);
            this.Controls.Add(this.Save_Tile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home_Tile);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Obeo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel Destination;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel Duration_Label;
        private MetroFramework.Controls.MetroLabel Distance_Label;
        private MetroFramework.Controls.MetroLabel Destination_Label;
        private MetroFramework.Controls.MetroLabel Origin_Label;
        private MetroFramework.Controls.MetroTile Home_Tile;
        private MetroFramework.Controls.MetroTile Save_Tile;
    }
}