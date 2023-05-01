namespace Final_Project
{
    partial class DisplayFishingInformationForm
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
            this.WaterClarirtyDisplayLabel = new System.Windows.Forms.Label();
            this.UpdateAllTextBoxes = new System.Windows.Forms.Timer(this.components);
            this.PictureOfArea = new System.Windows.Forms.PictureBox();
            this.WaterClarityDisplayTextBox = new System.Windows.Forms.Label();
            this.DisplayNameOfFishingSpotText = new System.Windows.Forms.Label();
            this.BoatAccessLabel = new System.Windows.Forms.Label();
            this.DisplayBoatAccessabilityText = new System.Windows.Forms.Label();
            this.WaterDepthDisplayLabel = new System.Windows.Forms.Label();
            this.DisplayWaterDepthText = new System.Windows.Forms.Label();
            this.FishInTheAreaLabel = new System.Windows.Forms.Label();
            this.DisplayFishInTheAreaText = new System.Windows.Forms.Label();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfArea)).BeginInit();
            this.SuspendLayout();
            // 
            // WaterClarirtyDisplayLabel
            // 
            this.WaterClarirtyDisplayLabel.AutoSize = true;
            this.WaterClarirtyDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WaterClarirtyDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterClarirtyDisplayLabel.Location = new System.Drawing.Point(9, 116);
            this.WaterClarirtyDisplayLabel.Name = "WaterClarirtyDisplayLabel";
            this.WaterClarirtyDisplayLabel.Size = new System.Drawing.Size(136, 18);
            this.WaterClarirtyDisplayLabel.TabIndex = 0;
            this.WaterClarirtyDisplayLabel.Text = "Water Clarity (In Feet)";
            // 
            // UpdateAllTextBoxes
            // 
            this.UpdateAllTextBoxes.Enabled = true;
            this.UpdateAllTextBoxes.Tick += new System.EventHandler(this.UpdateAllTextBoxes_Tick);
            // 
            // PictureOfArea
            // 
            this.PictureOfArea.Location = new System.Drawing.Point(12, 12);
            this.PictureOfArea.Name = "PictureOfArea";
            this.PictureOfArea.Size = new System.Drawing.Size(75, 75);
            this.PictureOfArea.TabIndex = 1;
            this.PictureOfArea.TabStop = false;
            // 
            // WaterClarityDisplayTextBox
            // 
            this.WaterClarityDisplayTextBox.AutoSize = true;
            this.WaterClarityDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterClarityDisplayTextBox.Location = new System.Drawing.Point(54, 142);
            this.WaterClarityDisplayTextBox.Name = "WaterClarityDisplayTextBox";
            this.WaterClarityDisplayTextBox.Size = new System.Drawing.Size(83, 16);
            this.WaterClarityDisplayTextBox.TabIndex = 2;
            this.WaterClarityDisplayTextBox.Text = "PlaceHolder";
            // 
            // DisplayNameOfFishingSpotText
            // 
            this.DisplayNameOfFishingSpotText.AutoSize = true;
            this.DisplayNameOfFishingSpotText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameOfFishingSpotText.Location = new System.Drawing.Point(105, 40);
            this.DisplayNameOfFishingSpotText.Name = "DisplayNameOfFishingSpotText";
            this.DisplayNameOfFishingSpotText.Size = new System.Drawing.Size(83, 16);
            this.DisplayNameOfFishingSpotText.TabIndex = 3;
            this.DisplayNameOfFishingSpotText.Text = "PlaceHolder";
            // 
            // BoatAccessLabel
            // 
            this.BoatAccessLabel.AutoSize = true;
            this.BoatAccessLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoatAccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoatAccessLabel.Location = new System.Drawing.Point(30, 194);
            this.BoatAccessLabel.Name = "BoatAccessLabel";
            this.BoatAccessLabel.Size = new System.Drawing.Size(85, 18);
            this.BoatAccessLabel.TabIndex = 4;
            this.BoatAccessLabel.Text = "Boat Access";
            // 
            // DisplayBoatAccessabilityText
            // 
            this.DisplayBoatAccessabilityText.AutoSize = true;
            this.DisplayBoatAccessabilityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBoatAccessabilityText.Location = new System.Drawing.Point(54, 222);
            this.DisplayBoatAccessabilityText.Name = "DisplayBoatAccessabilityText";
            this.DisplayBoatAccessabilityText.Size = new System.Drawing.Size(83, 16);
            this.DisplayBoatAccessabilityText.TabIndex = 5;
            this.DisplayBoatAccessabilityText.Text = "PlaceHolder";
            // 
            // WaterDepthDisplayLabel
            // 
            this.WaterDepthDisplayLabel.AutoSize = true;
            this.WaterDepthDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WaterDepthDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterDepthDisplayLabel.Location = new System.Drawing.Point(30, 283);
            this.WaterDepthDisplayLabel.Name = "WaterDepthDisplayLabel";
            this.WaterDepthDisplayLabel.Size = new System.Drawing.Size(81, 18);
            this.WaterDepthDisplayLabel.TabIndex = 6;
            this.WaterDepthDisplayLabel.Text = "WaterDepth";
            // 
            // DisplayWaterDepthText
            // 
            this.DisplayWaterDepthText.AutoSize = true;
            this.DisplayWaterDepthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayWaterDepthText.Location = new System.Drawing.Point(54, 312);
            this.DisplayWaterDepthText.Name = "DisplayWaterDepthText";
            this.DisplayWaterDepthText.Size = new System.Drawing.Size(83, 16);
            this.DisplayWaterDepthText.TabIndex = 7;
            this.DisplayWaterDepthText.Text = "PlaceHolder";
            // 
            // FishInTheAreaLabel
            // 
            this.FishInTheAreaLabel.AutoSize = true;
            this.FishInTheAreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FishInTheAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FishInTheAreaLabel.Location = new System.Drawing.Point(21, 372);
            this.FishInTheAreaLabel.Name = "FishInTheAreaLabel";
            this.FishInTheAreaLabel.Size = new System.Drawing.Size(106, 18);
            this.FishInTheAreaLabel.TabIndex = 8;
            this.FishInTheAreaLabel.Text = "Fish In The Area";
            // 
            // DisplayFishInTheAreaText
            // 
            this.DisplayFishInTheAreaText.AutoSize = true;
            this.DisplayFishInTheAreaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFishInTheAreaText.Location = new System.Drawing.Point(27, 400);
            this.DisplayFishInTheAreaText.Name = "DisplayFishInTheAreaText";
            this.DisplayFishInTheAreaText.Size = new System.Drawing.Size(83, 16);
            this.DisplayFishInTheAreaText.TabIndex = 9;
            this.DisplayFishInTheAreaText.Text = "PlaceHolder";
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindowButton.Location = new System.Drawing.Point(252, 458);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(84, 41);
            this.CloseWindowButton.TabIndex = 10;
            this.CloseWindowButton.Text = "Close Window";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // DisplayFishingInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 511);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.DisplayFishInTheAreaText);
            this.Controls.Add(this.FishInTheAreaLabel);
            this.Controls.Add(this.DisplayWaterDepthText);
            this.Controls.Add(this.WaterDepthDisplayLabel);
            this.Controls.Add(this.DisplayBoatAccessabilityText);
            this.Controls.Add(this.BoatAccessLabel);
            this.Controls.Add(this.DisplayNameOfFishingSpotText);
            this.Controls.Add(this.WaterClarityDisplayTextBox);
            this.Controls.Add(this.PictureOfArea);
            this.Controls.Add(this.WaterClarirtyDisplayLabel);
            this.Name = "DisplayFishingInformationForm";
            this.Text = "Fishing Pin Information";
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WaterClarirtyDisplayLabel;
        private System.Windows.Forms.Timer UpdateAllTextBoxes;
        private System.Windows.Forms.PictureBox PictureOfArea;
        private System.Windows.Forms.Label WaterClarityDisplayTextBox;
        private System.Windows.Forms.Label DisplayNameOfFishingSpotText;
        private System.Windows.Forms.Label BoatAccessLabel;
        private System.Windows.Forms.Label DisplayBoatAccessabilityText;
        private System.Windows.Forms.Label WaterDepthDisplayLabel;
        private System.Windows.Forms.Label DisplayWaterDepthText;
        private System.Windows.Forms.Label FishInTheAreaLabel;
        private System.Windows.Forms.Label DisplayFishInTheAreaText;
        private System.Windows.Forms.Button CloseWindowButton;
    }
}