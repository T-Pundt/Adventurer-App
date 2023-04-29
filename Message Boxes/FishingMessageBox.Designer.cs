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
            this.CreateFishingClass = new System.Windows.Forms.Button();
            this.WaterDepthBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MaximumWaterDepthLabel = new System.Windows.Forms.Label();
            this.DisplayCurrentDepthForTrackBar = new System.Windows.Forms.TextBox();
            this.TimerToUpdateDepthBar = new System.Windows.Forms.Timer(this.components);
            this.WaterClarityBar = new System.Windows.Forms.TrackBar();
            this.WaterClarityBarLabel = new System.Windows.Forms.Label();
            this.DisplayCurrentWaterClarityForBar = new System.Windows.Forms.TextBox();
            this.BoatAccessibilityLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.FishThatAreFoundInTheAreaLabel = new System.Windows.Forms.Label();
            this.ListOfFishTextBox = new System.Windows.Forms.TextBox();
            this.UpLoadPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.AddAPictureButton = new System.Windows.Forms.Label();
            this.DisplayPictureSelected = new System.Windows.Forms.Label();
            this.DisplaySelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfFishingSpotBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WaterDepthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterClarityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySelectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateFishingClass
            // 
            this.CreateFishingClass.Location = new System.Drawing.Point(595, 785);
            this.CreateFishingClass.Name = "CreateFishingClass";
            this.CreateFishingClass.Size = new System.Drawing.Size(105, 45);
            this.CreateFishingClass.TabIndex = 1;
            this.CreateFishingClass.Text = "Create";
            this.CreateFishingClass.UseVisualStyleBackColor = true;
            this.CreateFishingClass.Click += new System.EventHandler(this.CreateFishingClass_Clicked);
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
            // WaterClarityBar
            // 
            this.WaterClarityBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WaterClarityBar.Location = new System.Drawing.Point(12, 172);
            this.WaterClarityBar.Name = "WaterClarityBar";
            this.WaterClarityBar.Size = new System.Drawing.Size(685, 45);
            this.WaterClarityBar.TabIndex = 7;
            // 
            // WaterClarityBarLabel
            // 
            this.WaterClarityBarLabel.AutoSize = true;
            this.WaterClarityBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterClarityBarLabel.Location = new System.Drawing.Point(298, 137);
            this.WaterClarityBarLabel.Name = "WaterClarityBarLabel";
            this.WaterClarityBarLabel.Size = new System.Drawing.Size(100, 16);
            this.WaterClarityBarLabel.TabIndex = 8;
            this.WaterClarityBarLabel.Text = "Water Clarity (ft)";
            // 
            // DisplayCurrentWaterClarityForBar
            // 
            this.DisplayCurrentWaterClarityForBar.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayCurrentWaterClarityForBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayCurrentWaterClarityForBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCurrentWaterClarityForBar.Location = new System.Drawing.Point(12, 223);
            this.DisplayCurrentWaterClarityForBar.Name = "DisplayCurrentWaterClarityForBar";
            this.DisplayCurrentWaterClarityForBar.Size = new System.Drawing.Size(103, 15);
            this.DisplayCurrentWaterClarityForBar.TabIndex = 9;
            // 
            // BoatAccessibilityLabel
            // 
            this.BoatAccessibilityLabel.AutoSize = true;
            this.BoatAccessibilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoatAccessibilityLabel.Location = new System.Drawing.Point(266, 260);
            this.BoatAccessibilityLabel.Name = "BoatAccessibilityLabel";
            this.BoatAccessibilityLabel.Size = new System.Drawing.Size(170, 16);
            this.BoatAccessibilityLabel.TabIndex = 10;
            this.BoatAccessibilityLabel.Text = "Is There Boat Accessability";
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(269, 292);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(61, 40);
            this.YesButton.TabIndex = 11;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(375, 292);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(61, 40);
            this.NoButton.TabIndex = 12;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // FishThatAreFoundInTheAreaLabel
            // 
            this.FishThatAreFoundInTheAreaLabel.AutoSize = true;
            this.FishThatAreFoundInTheAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FishThatAreFoundInTheAreaLabel.Location = new System.Drawing.Point(255, 394);
            this.FishThatAreFoundInTheAreaLabel.Name = "FishThatAreFoundInTheAreaLabel";
            this.FishThatAreFoundInTheAreaLabel.Size = new System.Drawing.Size(199, 16);
            this.FishThatAreFoundInTheAreaLabel.TabIndex = 13;
            this.FishThatAreFoundInTheAreaLabel.Text = "Fish That Are Found In The Area";
            // 
            // ListOfFishTextBox
            // 
            this.ListOfFishTextBox.Location = new System.Drawing.Point(12, 425);
            this.ListOfFishTextBox.Name = "ListOfFishTextBox";
            this.ListOfFishTextBox.Size = new System.Drawing.Size(685, 20);
            this.ListOfFishTextBox.TabIndex = 14;
            // 
            // UpLoadPictureDialog
            // 
            this.UpLoadPictureDialog.FileName = "openFileDialog1";
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPictureButton.Location = new System.Drawing.Point(323, 523);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(64, 47);
            this.UploadPictureButton.TabIndex = 15;
            this.UploadPictureButton.Text = "Add Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // AddAPictureButton
            // 
            this.AddAPictureButton.AutoSize = true;
            this.AddAPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAPictureButton.Location = new System.Drawing.Point(310, 492);
            this.AddAPictureButton.Name = "AddAPictureButton";
            this.AddAPictureButton.Size = new System.Drawing.Size(88, 16);
            this.AddAPictureButton.TabIndex = 16;
            this.AddAPictureButton.Text = "Add A Picture";
            // 
            // DisplayPictureSelected
            // 
            this.DisplayPictureSelected.AutoSize = true;
            this.DisplayPictureSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayPictureSelected.Location = new System.Drawing.Point(12, 554);
            this.DisplayPictureSelected.Name = "DisplayPictureSelected";
            this.DisplayPictureSelected.Size = new System.Drawing.Size(105, 16);
            this.DisplayPictureSelected.TabIndex = 17;
            this.DisplayPictureSelected.Text = "Selected Picture";
            // 
            // DisplaySelectedPictureBox
            // 
            this.DisplaySelectedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplaySelectedPictureBox.Location = new System.Drawing.Point(12, 582);
            this.DisplaySelectedPictureBox.Name = "DisplaySelectedPictureBox";
            this.DisplaySelectedPictureBox.Size = new System.Drawing.Size(75, 75);
            this.DisplaySelectedPictureBox.TabIndex = 18;
            this.DisplaySelectedPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 699);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name of Fishing Spot";
            // 
            // NameOfFishingSpotBox
            // 
            this.NameOfFishingSpotBox.Location = new System.Drawing.Point(15, 728);
            this.NameOfFishingSpotBox.Name = "NameOfFishingSpotBox";
            this.NameOfFishingSpotBox.Size = new System.Drawing.Size(685, 20);
            this.NameOfFishingSpotBox.TabIndex = 20;
            // 
            // FishingMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 846);
            this.Controls.Add(this.NameOfFishingSpotBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplaySelectedPictureBox);
            this.Controls.Add(this.DisplayPictureSelected);
            this.Controls.Add(this.AddAPictureButton);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.ListOfFishTextBox);
            this.Controls.Add(this.FishThatAreFoundInTheAreaLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.BoatAccessibilityLabel);
            this.Controls.Add(this.DisplayCurrentWaterClarityForBar);
            this.Controls.Add(this.WaterClarityBarLabel);
            this.Controls.Add(this.WaterClarityBar);
            this.Controls.Add(this.DisplayCurrentDepthForTrackBar);
            this.Controls.Add(this.MaximumWaterDepthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaterDepthBar);
            this.Controls.Add(this.CreateFishingClass);
            this.Name = "FishingMessageBox";
            this.Text = "FishingMessageBox";
            this.Load += new System.EventHandler(this.FishingMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WaterDepthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterClarityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySelectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateFishingClass;
        private System.Windows.Forms.TrackBar WaterDepthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaximumWaterDepthLabel;
        private System.Windows.Forms.TextBox DisplayCurrentDepthForTrackBar;
        private System.Windows.Forms.Timer TimerToUpdateDepthBar;
        private System.Windows.Forms.TrackBar WaterClarityBar;
        private System.Windows.Forms.Label WaterClarityBarLabel;
        private System.Windows.Forms.TextBox DisplayCurrentWaterClarityForBar;
        private System.Windows.Forms.Label BoatAccessibilityLabel;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label FishThatAreFoundInTheAreaLabel;
        private System.Windows.Forms.TextBox ListOfFishTextBox;
        private System.Windows.Forms.OpenFileDialog UpLoadPictureDialog;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.Label AddAPictureButton;
        private System.Windows.Forms.Label DisplayPictureSelected;
        private System.Windows.Forms.PictureBox DisplaySelectedPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameOfFishingSpotBox;
    }
}