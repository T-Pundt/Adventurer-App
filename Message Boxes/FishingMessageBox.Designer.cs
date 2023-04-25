namespace Final_Project
{
    partial class FishingMessageBox
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
            this.button1 = new System.Windows.Forms.Button();
            this.WaterDepthBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MaximumWaterDepthLabel = new System.Windows.Forms.Label();
            this.DisplayCurrentDepthForTrackBar = new System.Windows.Forms.TextBox();
            this.TimerToUpdateDepthBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WaterDepthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WaterDepthBar
            // 
            this.WaterDepthBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WaterDepthBar.Location = new System.Drawing.Point(12, 43);
            this.WaterDepthBar.Maximum = 100;
            this.WaterDepthBar.Name = "WaterDepthBar";
            this.WaterDepthBar.Size = new System.Drawing.Size(685, 45);
            this.WaterDepthBar.TabIndex = 2;
            this.WaterDepthBar.TickFrequency = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            // 
            // MaximumWaterDepthLabel
            // 
            this.MaximumWaterDepthLabel.AutoSize = true;
            this.MaximumWaterDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumWaterDepthLabel.Location = new System.Drawing.Point(271, 9);
            this.MaximumWaterDepthLabel.Name = "MaximumWaterDepthLabel";
            this.MaximumWaterDepthLabel.Size = new System.Drawing.Size(165, 16);
            this.MaximumWaterDepthLabel.TabIndex = 4;
            this.MaximumWaterDepthLabel.Text = "Maximum Water Depth ( ft )";
            // 
            // DisplayCurrentDepthForTrackBar
            // 
            this.DisplayCurrentDepthForTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayCurrentDepthForTrackBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayCurrentDepthForTrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCurrentDepthForTrackBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DisplayCurrentDepthForTrackBar.Location = new System.Drawing.Point(12, 94);
            this.DisplayCurrentDepthForTrackBar.Name = "DisplayCurrentDepthForTrackBar";
            this.DisplayCurrentDepthForTrackBar.Size = new System.Drawing.Size(180, 15);
            this.DisplayCurrentDepthForTrackBar.TabIndex = 6;
            // 
            // TimerToUpdateDepthBar
            // 
            this.TimerToUpdateDepthBar.Enabled = true;
            this.TimerToUpdateDepthBar.Interval = 50;
            this.TimerToUpdateDepthBar.Tick += new System.EventHandler(this.TimerToUpdateDepthBar_Tick);
            // 
            // FishingMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 681);
            this.Controls.Add(this.DisplayCurrentDepthForTrackBar);
            this.Controls.Add(this.MaximumWaterDepthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaterDepthBar);
            this.Controls.Add(this.button1);
            this.Name = "FishingMessageBox";
            this.Text = "FishingMessageBox";
            this.Load += new System.EventHandler(this.FishingMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WaterDepthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar WaterDepthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaximumWaterDepthLabel;
        private System.Windows.Forms.TextBox DisplayCurrentDepthForTrackBar;
        private System.Windows.Forms.Timer TimerToUpdateDepthBar;
    }
}