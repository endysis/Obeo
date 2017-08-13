namespace ObeoDesign
{
    partial class Form2
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
            this.Destination_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Origin_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Execute_Tile = new MetroFramework.Controls.MetroTile();
            this.Switch_Tile = new MetroFramework.Controls.MetroTile();
            this.Home_Tile = new MetroFramework.Controls.MetroTile();
            this.MethodBike_Tile = new MetroFramework.Controls.MetroTile();
            this.MethodCar_Tile = new MetroFramework.Controls.MetroTile();
            this.Reset_Tile = new MetroFramework.Controls.MetroTile();
            this.MethodWalk_Tile = new MetroFramework.Controls.MetroTile();
            this.Method_Tile = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // Destination_TextBox
            // 
            this.Destination_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Destination_TextBox.Location = new System.Drawing.Point(23, 159);
            this.Destination_TextBox.Name = "Destination_TextBox";
            this.Destination_TextBox.Size = new System.Drawing.Size(288, 90);
            this.Destination_TextBox.TabIndex = 3;
            this.Destination_TextBox.Text = "Manchester";
            this.Destination_TextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Destination_TextBox.Click += new System.EventHandler(this.Destination_TextBox_Click);
            // 
            // Origin_TextBox
            // 
            this.Origin_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Origin_TextBox.Location = new System.Drawing.Point(23, 63);
            this.Origin_TextBox.Name = "Origin_TextBox";
            this.Origin_TextBox.Size = new System.Drawing.Size(288, 90);
            this.Origin_TextBox.TabIndex = 4;
            this.Origin_TextBox.Text = "Sheffield";
            this.Origin_TextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Origin_TextBox.Click += new System.EventHandler(this.Origin_TextBox_Click);
            // 
            // Execute_Tile
            // 
            this.Execute_Tile.Location = new System.Drawing.Point(317, 63);
            this.Execute_Tile.Name = "Execute_Tile";
            this.Execute_Tile.Size = new System.Drawing.Size(138, 475);
            this.Execute_Tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.Execute_Tile.TabIndex = 5;
            this.Execute_Tile.Text = "Query Route";
            this.Execute_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Execute_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Execute_Tile.Click += new System.EventHandler(this.Execute_Tile_Click);
            // 
            // Switch_Tile
            // 
            this.Switch_Tile.Location = new System.Drawing.Point(23, 255);
            this.Switch_Tile.Name = "Switch_Tile";
            this.Switch_Tile.Size = new System.Drawing.Size(63, 65);
            this.Switch_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Switch_Tile.TabIndex = 12;
            this.Switch_Tile.Text = "Switch";
            this.Switch_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Switch_Tile.Click += new System.EventHandler(this.Switch_Tile_Click);
            // 
            // Home_Tile
            // 
            this.Home_Tile.Location = new System.Drawing.Point(461, 63);
            this.Home_Tile.Name = "Home_Tile";
            this.Home_Tile.Size = new System.Drawing.Size(324, 475);
            this.Home_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Home_Tile.TabIndex = 13;
            this.Home_Tile.Text = "Go To Home";
            this.Home_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Home_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Home_Tile.Click += new System.EventHandler(this.Home_Tile_Click);
            // 
            // MethodBike_Tile
            // 
            this.MethodBike_Tile.Location = new System.Drawing.Point(121, 326);
            this.MethodBike_Tile.Name = "MethodBike_Tile";
            this.MethodBike_Tile.Size = new System.Drawing.Size(92, 98);
            this.MethodBike_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.MethodBike_Tile.TabIndex = 14;
            this.MethodBike_Tile.Text = "Cycle";
            this.MethodBike_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MethodBike_Tile.Click += new System.EventHandler(this.MethodBike_Tile_Click);
            // 
            // MethodCar_Tile
            // 
            this.MethodCar_Tile.Location = new System.Drawing.Point(23, 326);
            this.MethodCar_Tile.Name = "MethodCar_Tile";
            this.MethodCar_Tile.Size = new System.Drawing.Size(92, 98);
            this.MethodCar_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.MethodCar_Tile.TabIndex = 15;
            this.MethodCar_Tile.Text = "Car";
            this.MethodCar_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MethodCar_Tile.Click += new System.EventHandler(this.MethodCar_Tile_Click);
            // 
            // Reset_Tile
            // 
            this.Reset_Tile.Location = new System.Drawing.Point(23, 430);
            this.Reset_Tile.Name = "Reset_Tile";
            this.Reset_Tile.Size = new System.Drawing.Size(288, 108);
            this.Reset_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Reset_Tile.TabIndex = 17;
            this.Reset_Tile.Text = "Reset";
            this.Reset_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Reset_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Reset_Tile.Click += new System.EventHandler(this.Reset_Tile_Click);
            // 
            // MethodWalk_Tile
            // 
            this.MethodWalk_Tile.Location = new System.Drawing.Point(219, 326);
            this.MethodWalk_Tile.Name = "MethodWalk_Tile";
            this.MethodWalk_Tile.Size = new System.Drawing.Size(92, 98);
            this.MethodWalk_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.MethodWalk_Tile.TabIndex = 18;
            this.MethodWalk_Tile.Text = "Walk";
            this.MethodWalk_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MethodWalk_Tile.Click += new System.EventHandler(this.MethodWalk_Tile_Click);
            // 
            // Method_Tile
            // 
            this.Method_Tile.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Method_Tile.Location = new System.Drawing.Point(92, 255);
            this.Method_Tile.Name = "Method_Tile";
            this.Method_Tile.Size = new System.Drawing.Size(220, 65);
            this.Method_Tile.TabIndex = 19;
            this.Method_Tile.Text = "Travel Method";
            this.Method_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 561);
            this.Controls.Add(this.Method_Tile);
            this.Controls.Add(this.MethodWalk_Tile);
            this.Controls.Add(this.Reset_Tile);
            this.Controls.Add(this.MethodCar_Tile);
            this.Controls.Add(this.MethodBike_Tile);
            this.Controls.Add(this.Home_Tile);
            this.Controls.Add(this.Destination_TextBox);
            this.Controls.Add(this.Switch_Tile);
            this.Controls.Add(this.Origin_TextBox);
            this.Controls.Add(this.Execute_Tile);
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Obeo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox Destination_TextBox;
        private MetroFramework.Controls.MetroTextBox Origin_TextBox;
        private MetroFramework.Controls.MetroTile Execute_Tile;
        private MetroFramework.Controls.MetroTile Switch_Tile;
        private MetroFramework.Controls.MetroTile Home_Tile;
        private MetroFramework.Controls.MetroTile MethodBike_Tile;
        private MetroFramework.Controls.MetroTile MethodCar_Tile;
        private MetroFramework.Controls.MetroTile Reset_Tile;
        private MetroFramework.Controls.MetroTile MethodWalk_Tile;
        private MetroFramework.Controls.MetroTextBox Method_Tile;
    }
}