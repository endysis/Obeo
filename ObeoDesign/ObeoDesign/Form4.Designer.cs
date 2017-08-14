namespace ObeoDesign
{
    partial class Form4
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
            this.DataLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DataLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DataLabel3 = new MetroFramework.Controls.MetroLabel();
            this.DataLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Home_Tile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // DataLabel1
            // 
            this.DataLabel1.AutoSize = true;
            this.DataLabel1.Location = new System.Drawing.Point(23, 98);
            this.DataLabel1.Name = "DataLabel1";
            this.DataLabel1.Size = new System.Drawing.Size(65, 19);
            this.DataLabel1.TabIndex = 0;
            this.DataLabel1.Text = "Loading...";
            this.DataLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DataLabel2
            // 
            this.DataLabel2.AutoSize = true;
            this.DataLabel2.Location = new System.Drawing.Point(23, 127);
            this.DataLabel2.Name = "DataLabel2";
            this.DataLabel2.Size = new System.Drawing.Size(0, 0);
            this.DataLabel2.TabIndex = 1;
            this.DataLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DataLabel3
            // 
            this.DataLabel3.AutoSize = true;
            this.DataLabel3.Location = new System.Drawing.Point(23, 156);
            this.DataLabel3.Name = "DataLabel3";
            this.DataLabel3.Size = new System.Drawing.Size(0, 0);
            this.DataLabel3.TabIndex = 2;
            this.DataLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DataLabel4
            // 
            this.DataLabel4.AutoSize = true;
            this.DataLabel4.Location = new System.Drawing.Point(23, 185);
            this.DataLabel4.Name = "DataLabel4";
            this.DataLabel4.Size = new System.Drawing.Size(0, 0);
            this.DataLabel4.TabIndex = 3;
            this.DataLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Home_Tile
            // 
            this.Home_Tile.Location = new System.Drawing.Point(633, 381);
            this.Home_Tile.Name = "Home_Tile";
            this.Home_Tile.Size = new System.Drawing.Size(152, 157);
            this.Home_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Home_Tile.TabIndex = 4;
            this.Home_Tile.Text = "Home";
            this.Home_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Home_Tile.Click += new System.EventHandler(this.Home_Tile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 561);
            this.Controls.Add(this.Home_Tile);
            this.Controls.Add(this.DataLabel4);
            this.Controls.Add(this.DataLabel3);
            this.Controls.Add(this.DataLabel2);
            this.Controls.Add(this.DataLabel1);
            this.Name = "Form4";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Obeo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel DataLabel1;
        private MetroFramework.Controls.MetroLabel DataLabel2;
        private MetroFramework.Controls.MetroLabel DataLabel3;
        private MetroFramework.Controls.MetroLabel DataLabel4;
        private MetroFramework.Controls.MetroTile Home_Tile;
    }
}