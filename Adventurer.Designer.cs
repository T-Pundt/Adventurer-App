namespace Final_Project
{
    partial class Adventurer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adventurer));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.DisplayCordinate = new System.Windows.Forms.TextBox();
            this.UpdateCordinatesTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrentCordinatesLabel = new System.Windows.Forms.Label();
            this.AddPinLabel = new System.Windows.Forms.Label();
            this.AddFishingPinButton = new System.Windows.Forms.Button();
            this.AddClimbingPinButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.AllowDrop = true;
            this.gmap.AutoScroll = true;
            this.gmap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gmap.Bearing = 0F;
            this.gmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gmap.CanDragMap = true;
            this.gmap.Cursor = System.Windows.Forms.Cursors.Default;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.Margin = new System.Windows.Forms.Padding(0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 4;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1223, 762);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 13D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // DisplayCordinate
            // 
            this.DisplayCordinate.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayCordinate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayCordinate.ForeColor = System.Drawing.Color.Black;
            this.DisplayCordinate.Location = new System.Drawing.Point(1226, 737);
            this.DisplayCordinate.Name = "DisplayCordinate";
            this.DisplayCordinate.Size = new System.Drawing.Size(262, 20);
            this.DisplayCordinate.TabIndex = 1;
            this.DisplayCordinate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateCordinatesTimer
            // 
            this.UpdateCordinatesTimer.Enabled = true;
            this.UpdateCordinatesTimer.Tick += new System.EventHandler(this.UpdateCordinatesTimer_Tick);
            // 
            // CurrentCordinatesLabel
            // 
            this.CurrentCordinatesLabel.AutoSize = true;
            this.CurrentCordinatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCordinatesLabel.Location = new System.Drawing.Point(1310, 709);
            this.CurrentCordinatesLabel.Name = "CurrentCordinatesLabel";
            this.CurrentCordinatesLabel.Size = new System.Drawing.Size(109, 15);
            this.CurrentCordinatesLabel.TabIndex = 2;
            this.CurrentCordinatesLabel.Text = "Current Cordinates";
            this.CurrentCordinatesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddPinLabel
            // 
            this.AddPinLabel.AutoSize = true;
            this.AddPinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPinLabel.Location = new System.Drawing.Point(1332, 9);
            this.AddPinLabel.Name = "AddPinLabel";
            this.AddPinLabel.Size = new System.Drawing.Size(49, 15);
            this.AddPinLabel.TabIndex = 3;
            this.AddPinLabel.Text = "Add Pin";
            // 
            // AddFishingPinButton
            // 
            this.AddFishingPinButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddFishingPinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFishingPinButton.BackgroundImage")));
            this.AddFishingPinButton.Location = new System.Drawing.Point(1236, 46);
            this.AddFishingPinButton.Name = "AddFishingPinButton";
            this.AddFishingPinButton.Size = new System.Drawing.Size(75, 75);
            this.AddFishingPinButton.TabIndex = 5;
            this.AddFishingPinButton.UseVisualStyleBackColor = false;
            // 
            // AddClimbingPinButton
            // 
            this.AddClimbingPinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddClimbingPinButton.BackgroundImage")));
            this.AddClimbingPinButton.Location = new System.Drawing.Point(1406, 46);
            this.AddClimbingPinButton.Name = "AddClimbingPinButton";
            this.AddClimbingPinButton.Size = new System.Drawing.Size(75, 75);
            this.AddClimbingPinButton.TabIndex = 5;
            this.AddClimbingPinButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1236, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(1406, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Adventurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 762);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddClimbingPinButton);
            this.Controls.Add(this.AddFishingPinButton);
            this.Controls.Add(this.AddPinLabel);
            this.Controls.Add(this.CurrentCordinatesLabel);
            this.Controls.Add(this.DisplayCordinate);
            this.Controls.Add(this.gmap);
            this.Name = "Adventurer";
            this.Text = "Adventurer";
            this.Load += new System.EventHandler(this.Adventurer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Timer UpdateCordinatesTimer;
        private System.Windows.Forms.TextBox DisplayCordinate;
        private System.Windows.Forms.Label CurrentCordinatesLabel;
        private System.Windows.Forms.Label AddPinLabel;
        private System.Windows.Forms.Button AddFishingPinButton;
        private System.Windows.Forms.Button AddClimbingPinButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

