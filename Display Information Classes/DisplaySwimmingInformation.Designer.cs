namespace Final_Project
{
    partial class DisplaySwimmingInformation
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
            this.SwimmingPictureOfArea = new System.Windows.Forms.PictureBox();
            this.DisplayNameOfSwimmingSpotText = new System.Windows.Forms.Label();
            this.SwimmingWaterClarirtyDisplayLabel = new System.Windows.Forms.Label();
            this.WaterClarityDisplayTextBox = new System.Windows.Forms.Label();
            this.SwimmingWaterDepthDisplayLabel = new System.Windows.Forms.Label();
            this.SwimmingDisplayWaterDepthText = new System.Windows.Forms.Label();
            this.DisplaySwimmingPolutionLevelLabel = new System.Windows.Forms.Label();
            this.SwimmingDisplayPolutionLevel = new System.Windows.Forms.Label();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.UpdateSwimmingInformationBoxesTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingPictureOfArea)).BeginInit();
            this.SuspendLayout();
            // 
            // SwimmingPictureOfArea
            // 
            this.SwimmingPictureOfArea.Location = new System.Drawing.Point(12, 12);
            this.SwimmingPictureOfArea.Name = "SwimmingPictureOfArea";
            this.SwimmingPictureOfArea.Size = new System.Drawing.Size(75, 75);
            this.SwimmingPictureOfArea.TabIndex = 2;
            this.SwimmingPictureOfArea.TabStop = false;
            // 
            // DisplayNameOfSwimmingSpotText
            // 
            this.DisplayNameOfSwimmingSpotText.AutoSize = true;
            this.DisplayNameOfSwimmingSpotText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameOfSwimmingSpotText.Location = new System.Drawing.Point(106, 43);
            this.DisplayNameOfSwimmingSpotText.Name = "DisplayNameOfSwimmingSpotText";
            this.DisplayNameOfSwimmingSpotText.Size = new System.Drawing.Size(83, 16);
            this.DisplayNameOfSwimmingSpotText.TabIndex = 4;
            this.DisplayNameOfSwimmingSpotText.Text = "PlaceHolder";
            // 
            // SwimmingWaterClarirtyDisplayLabel
            // 
            this.SwimmingWaterClarirtyDisplayLabel.AutoSize = true;
            this.SwimmingWaterClarirtyDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwimmingWaterClarirtyDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterClarirtyDisplayLabel.Location = new System.Drawing.Point(12, 123);
            this.SwimmingWaterClarirtyDisplayLabel.Name = "SwimmingWaterClarirtyDisplayLabel";
            this.SwimmingWaterClarirtyDisplayLabel.Size = new System.Drawing.Size(136, 18);
            this.SwimmingWaterClarirtyDisplayLabel.TabIndex = 5;
            this.SwimmingWaterClarirtyDisplayLabel.Text = "Water Clarity (In Feet)";
            // 
            // WaterClarityDisplayTextBox
            // 
            this.WaterClarityDisplayTextBox.AutoSize = true;
            this.WaterClarityDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterClarityDisplayTextBox.Location = new System.Drawing.Point(56, 151);
            this.WaterClarityDisplayTextBox.Name = "WaterClarityDisplayTextBox";
            this.WaterClarityDisplayTextBox.Size = new System.Drawing.Size(83, 16);
            this.WaterClarityDisplayTextBox.TabIndex = 6;
            this.WaterClarityDisplayTextBox.Text = "PlaceHolder";
            // 
            // SwimmingWaterDepthDisplayLabel
            // 
            this.SwimmingWaterDepthDisplayLabel.AutoSize = true;
            this.SwimmingWaterDepthDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwimmingWaterDepthDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterDepthDisplayLabel.Location = new System.Drawing.Point(13, 196);
            this.SwimmingWaterDepthDisplayLabel.Name = "SwimmingWaterDepthDisplayLabel";
            this.SwimmingWaterDepthDisplayLabel.Size = new System.Drawing.Size(135, 18);
            this.SwimmingWaterDepthDisplayLabel.TabIndex = 7;
            this.SwimmingWaterDepthDisplayLabel.Text = "Water Depth (In Feet)";
            // 
            // SwimmingDisplayWaterDepthText
            // 
            this.SwimmingDisplayWaterDepthText.AutoSize = true;
            this.SwimmingDisplayWaterDepthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingDisplayWaterDepthText.Location = new System.Drawing.Point(56, 223);
            this.SwimmingDisplayWaterDepthText.Name = "SwimmingDisplayWaterDepthText";
            this.SwimmingDisplayWaterDepthText.Size = new System.Drawing.Size(83, 16);
            this.SwimmingDisplayWaterDepthText.TabIndex = 8;
            this.SwimmingDisplayWaterDepthText.Text = "PlaceHolder";
            // 
            // DisplaySwimmingPolutionLevelLabel
            // 
            this.DisplaySwimmingPolutionLevelLabel.AutoSize = true;
            this.DisplaySwimmingPolutionLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplaySwimmingPolutionLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySwimmingPolutionLevelLabel.Location = new System.Drawing.Point(15, 273);
            this.DisplaySwimmingPolutionLevelLabel.Name = "DisplaySwimmingPolutionLevelLabel";
            this.DisplaySwimmingPolutionLevelLabel.Size = new System.Drawing.Size(132, 18);
            this.DisplaySwimmingPolutionLevelLabel.TabIndex = 9;
            this.DisplaySwimmingPolutionLevelLabel.Text = "Water Polution Level";
            // 
            // SwimmingDisplayPolutionLevel
            // 
            this.SwimmingDisplayPolutionLevel.AutoSize = true;
            this.SwimmingDisplayPolutionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingDisplayPolutionLevel.Location = new System.Drawing.Point(12, 302);
            this.SwimmingDisplayPolutionLevel.Name = "SwimmingDisplayPolutionLevel";
            this.SwimmingDisplayPolutionLevel.Size = new System.Drawing.Size(83, 16);
            this.SwimmingDisplayPolutionLevel.TabIndex = 10;
            this.SwimmingDisplayPolutionLevel.Text = "PlaceHolder";
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindowButton.Location = new System.Drawing.Point(252, 317);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(84, 41);
            this.CloseWindowButton.TabIndex = 11;
            this.CloseWindowButton.Text = "Close Window";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // UpdateSwimmingInformationBoxesTimer
            // 
            this.UpdateSwimmingInformationBoxesTimer.Enabled = true;
            this.UpdateSwimmingInformationBoxesTimer.Tick += new System.EventHandler(this.UpdateSwimmingInformationBoxesTimer_Tick);
            // 
            // DisplaySwimmingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 370);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.SwimmingDisplayPolutionLevel);
            this.Controls.Add(this.DisplaySwimmingPolutionLevelLabel);
            this.Controls.Add(this.SwimmingDisplayWaterDepthText);
            this.Controls.Add(this.SwimmingWaterDepthDisplayLabel);
            this.Controls.Add(this.WaterClarityDisplayTextBox);
            this.Controls.Add(this.SwimmingWaterClarirtyDisplayLabel);
            this.Controls.Add(this.DisplayNameOfSwimmingSpotText);
            this.Controls.Add(this.SwimmingPictureOfArea);
            this.Name = "DisplaySwimmingInformation";
            this.Text = "Swimming Pin Information";
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingPictureOfArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SwimmingPictureOfArea;
        private System.Windows.Forms.Label DisplayNameOfSwimmingSpotText;
        private System.Windows.Forms.Label SwimmingWaterClarirtyDisplayLabel;
        private System.Windows.Forms.Label WaterClarityDisplayTextBox;
        private System.Windows.Forms.Label SwimmingWaterDepthDisplayLabel;
        private System.Windows.Forms.Label SwimmingDisplayWaterDepthText;
        private System.Windows.Forms.Label DisplaySwimmingPolutionLevelLabel;
        private System.Windows.Forms.Label SwimmingDisplayPolutionLevel;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Timer UpdateSwimmingInformationBoxesTimer;
    }
}