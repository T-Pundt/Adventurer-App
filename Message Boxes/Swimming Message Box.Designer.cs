namespace Final_Project
{
    partial class SwimmingMessageBox
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
            this.SwimmingWaterDepthBar = new System.Windows.Forms.TrackBar();
            this.SwimmingWaterDepthLabel = new System.Windows.Forms.Label();
            this.SwimmingWaterDepthText = new System.Windows.Forms.Label();
            this.UpdateSwimmingMessageBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SwimmingWaterPolutionLevelBar = new System.Windows.Forms.TrackBar();
            this.SwimmingWaterPolutionLevelLabel = new System.Windows.Forms.Label();
            this.SwimmingwaterPolutionLevelText = new System.Windows.Forms.Label();
            this.SwimmingWaterClarityBar = new System.Windows.Forms.TrackBar();
            this.SwimmingWaterClarityText = new System.Windows.Forms.Label();
            this.SwimmingWaterClarityLabel = new System.Windows.Forms.Label();
            this.SwimmingNameOfSpotTextBox = new System.Windows.Forms.TextBox();
            this.SwimmingNameOfSpotLabel = new System.Windows.Forms.Label();
            this.SwimmingUploadPictureButton = new System.Windows.Forms.Button();
            this.SwimmingAddAPictureButtonLabel = new System.Windows.Forms.Label();
            this.SwimmingDisplaySelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.SwimmingDisplayPictureSelectedLabel = new System.Windows.Forms.Label();
            this.SwimmingCreateSwimmingClassButton = new System.Windows.Forms.Button();
            this.SwimmingUploadPictureDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingWaterDepthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingWaterPolutionLevelBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingWaterClarityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingDisplaySelectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SwimmingWaterDepthBar
            // 
            this.SwimmingWaterDepthBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SwimmingWaterDepthBar.Location = new System.Drawing.Point(13, 43);
            this.SwimmingWaterDepthBar.Maximum = 40;
            this.SwimmingWaterDepthBar.Name = "SwimmingWaterDepthBar";
            this.SwimmingWaterDepthBar.Size = new System.Drawing.Size(685, 45);
            this.SwimmingWaterDepthBar.TabIndex = 3;
            this.SwimmingWaterDepthBar.TickFrequency = 5;
            // 
            // SwimmingWaterDepthLabel
            // 
            this.SwimmingWaterDepthLabel.AutoSize = true;
            this.SwimmingWaterDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterDepthLabel.Location = new System.Drawing.Point(261, 24);
            this.SwimmingWaterDepthLabel.Name = "SwimmingWaterDepthLabel";
            this.SwimmingWaterDepthLabel.Size = new System.Drawing.Size(189, 16);
            this.SwimmingWaterDepthLabel.TabIndex = 4;
            this.SwimmingWaterDepthLabel.Text = "Average Water Depth ( in feet )";
            // 
            // SwimmingWaterDepthText
            // 
            this.SwimmingWaterDepthText.AutoSize = true;
            this.SwimmingWaterDepthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterDepthText.Location = new System.Drawing.Point(12, 104);
            this.SwimmingWaterDepthText.Name = "SwimmingWaterDepthText";
            this.SwimmingWaterDepthText.Size = new System.Drawing.Size(83, 16);
            this.SwimmingWaterDepthText.TabIndex = 5;
            this.SwimmingWaterDepthText.Text = "PlaceHolder";
            // 
            // UpdateSwimmingMessageBoxTimer
            // 
            this.UpdateSwimmingMessageBoxTimer.Interval = 50;
            this.UpdateSwimmingMessageBoxTimer.Tick += new System.EventHandler(this.UpdateSwimmingMessageBoxTimer_Tick);
            // 
            // SwimmingWaterPolutionLevelBar
            // 
            this.SwimmingWaterPolutionLevelBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SwimmingWaterPolutionLevelBar.Location = new System.Drawing.Point(212, 189);
            this.SwimmingWaterPolutionLevelBar.Maximum = 3;
            this.SwimmingWaterPolutionLevelBar.Name = "SwimmingWaterPolutionLevelBar";
            this.SwimmingWaterPolutionLevelBar.Size = new System.Drawing.Size(277, 45);
            this.SwimmingWaterPolutionLevelBar.TabIndex = 6;
            // 
            // SwimmingWaterPolutionLevelLabel
            // 
            this.SwimmingWaterPolutionLevelLabel.AutoSize = true;
            this.SwimmingWaterPolutionLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterPolutionLevelLabel.Location = new System.Drawing.Point(283, 170);
            this.SwimmingWaterPolutionLevelLabel.Name = "SwimmingWaterPolutionLevelLabel";
            this.SwimmingWaterPolutionLevelLabel.Size = new System.Drawing.Size(130, 16);
            this.SwimmingWaterPolutionLevelLabel.TabIndex = 7;
            this.SwimmingWaterPolutionLevelLabel.Text = "Water Polution Level";
            // 
            // SwimmingwaterPolutionLevelText
            // 
            this.SwimmingwaterPolutionLevelText.AutoSize = true;
            this.SwimmingwaterPolutionLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingwaterPolutionLevelText.Location = new System.Drawing.Point(209, 246);
            this.SwimmingwaterPolutionLevelText.Name = "SwimmingwaterPolutionLevelText";
            this.SwimmingwaterPolutionLevelText.Size = new System.Drawing.Size(83, 16);
            this.SwimmingwaterPolutionLevelText.TabIndex = 8;
            this.SwimmingwaterPolutionLevelText.Text = "PlaceHolder";
            // 
            // SwimmingWaterClarityBar
            // 
            this.SwimmingWaterClarityBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SwimmingWaterClarityBar.Location = new System.Drawing.Point(12, 362);
            this.SwimmingWaterClarityBar.Name = "SwimmingWaterClarityBar";
            this.SwimmingWaterClarityBar.Size = new System.Drawing.Size(685, 45);
            this.SwimmingWaterClarityBar.TabIndex = 9;
            // 
            // SwimmingWaterClarityText
            // 
            this.SwimmingWaterClarityText.AutoSize = true;
            this.SwimmingWaterClarityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterClarityText.Location = new System.Drawing.Point(12, 410);
            this.SwimmingWaterClarityText.Name = "SwimmingWaterClarityText";
            this.SwimmingWaterClarityText.Size = new System.Drawing.Size(83, 16);
            this.SwimmingWaterClarityText.TabIndex = 10;
            this.SwimmingWaterClarityText.Text = "PlaceHolder";
            // 
            // SwimmingWaterClarityLabel
            // 
            this.SwimmingWaterClarityLabel.AutoSize = true;
            this.SwimmingWaterClarityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingWaterClarityLabel.Location = new System.Drawing.Point(283, 343);
            this.SwimmingWaterClarityLabel.Name = "SwimmingWaterClarityLabel";
            this.SwimmingWaterClarityLabel.Size = new System.Drawing.Size(129, 16);
            this.SwimmingWaterClarityLabel.TabIndex = 11;
            this.SwimmingWaterClarityLabel.Text = "Water Clarity (in feet)";
            // 
            // SwimmingNameOfSpotTextBox
            // 
            this.SwimmingNameOfSpotTextBox.Location = new System.Drawing.Point(15, 504);
            this.SwimmingNameOfSpotTextBox.Name = "SwimmingNameOfSpotTextBox";
            this.SwimmingNameOfSpotTextBox.Size = new System.Drawing.Size(685, 20);
            this.SwimmingNameOfSpotTextBox.TabIndex = 15;
            // 
            // SwimmingNameOfSpotLabel
            // 
            this.SwimmingNameOfSpotLabel.AutoSize = true;
            this.SwimmingNameOfSpotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingNameOfSpotLabel.Location = new System.Drawing.Point(302, 485);
            this.SwimmingNameOfSpotLabel.Name = "SwimmingNameOfSpotLabel";
            this.SwimmingNameOfSpotLabel.Size = new System.Drawing.Size(92, 16);
            this.SwimmingNameOfSpotLabel.TabIndex = 16;
            this.SwimmingNameOfSpotLabel.Text = "Name Of Area";
            // 
            // SwimmingUploadPictureButton
            // 
            this.SwimmingUploadPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingUploadPictureButton.Location = new System.Drawing.Point(319, 632);
            this.SwimmingUploadPictureButton.Name = "SwimmingUploadPictureButton";
            this.SwimmingUploadPictureButton.Size = new System.Drawing.Size(64, 47);
            this.SwimmingUploadPictureButton.TabIndex = 17;
            this.SwimmingUploadPictureButton.Text = "Add Picture";
            this.SwimmingUploadPictureButton.UseVisualStyleBackColor = true;
            this.SwimmingUploadPictureButton.Click += new System.EventHandler(this.SwimmingUploadPictureButton_Click);
            // 
            // SwimmingAddAPictureButtonLabel
            // 
            this.SwimmingAddAPictureButtonLabel.AutoSize = true;
            this.SwimmingAddAPictureButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingAddAPictureButtonLabel.Location = new System.Drawing.Point(306, 603);
            this.SwimmingAddAPictureButtonLabel.Name = "SwimmingAddAPictureButtonLabel";
            this.SwimmingAddAPictureButtonLabel.Size = new System.Drawing.Size(88, 16);
            this.SwimmingAddAPictureButtonLabel.TabIndex = 18;
            this.SwimmingAddAPictureButtonLabel.Text = "Add A Picture";
            // 
            // SwimmingDisplaySelectedPictureBox
            // 
            this.SwimmingDisplaySelectedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwimmingDisplaySelectedPictureBox.Location = new System.Drawing.Point(15, 695);
            this.SwimmingDisplaySelectedPictureBox.Name = "SwimmingDisplaySelectedPictureBox";
            this.SwimmingDisplaySelectedPictureBox.Size = new System.Drawing.Size(75, 75);
            this.SwimmingDisplaySelectedPictureBox.TabIndex = 19;
            this.SwimmingDisplaySelectedPictureBox.TabStop = false;
            // 
            // SwimmingDisplayPictureSelectedLabel
            // 
            this.SwimmingDisplayPictureSelectedLabel.AutoSize = true;
            this.SwimmingDisplayPictureSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingDisplayPictureSelectedLabel.Location = new System.Drawing.Point(12, 676);
            this.SwimmingDisplayPictureSelectedLabel.Name = "SwimmingDisplayPictureSelectedLabel";
            this.SwimmingDisplayPictureSelectedLabel.Size = new System.Drawing.Size(105, 16);
            this.SwimmingDisplayPictureSelectedLabel.TabIndex = 20;
            this.SwimmingDisplayPictureSelectedLabel.Text = "Selected Picture";
            // 
            // SwimmingCreateSwimmingClassButton
            // 
            this.SwimmingCreateSwimmingClassButton.Location = new System.Drawing.Point(593, 758);
            this.SwimmingCreateSwimmingClassButton.Name = "SwimmingCreateSwimmingClassButton";
            this.SwimmingCreateSwimmingClassButton.Size = new System.Drawing.Size(105, 45);
            this.SwimmingCreateSwimmingClassButton.TabIndex = 21;
            this.SwimmingCreateSwimmingClassButton.Text = "Create";
            this.SwimmingCreateSwimmingClassButton.UseVisualStyleBackColor = true;
            this.SwimmingCreateSwimmingClassButton.Click += new System.EventHandler(this.SwimmingCreateSwimmingClassButton_Click);
            // 
            // SwimmingUploadPictureDialog
            // 
            this.SwimmingUploadPictureDialog.FileName = "openFileDialog1";
            // 
            // SwimmingMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 815);
            this.Controls.Add(this.SwimmingCreateSwimmingClassButton);
            this.Controls.Add(this.SwimmingDisplayPictureSelectedLabel);
            this.Controls.Add(this.SwimmingDisplaySelectedPictureBox);
            this.Controls.Add(this.SwimmingAddAPictureButtonLabel);
            this.Controls.Add(this.SwimmingUploadPictureButton);
            this.Controls.Add(this.SwimmingNameOfSpotLabel);
            this.Controls.Add(this.SwimmingNameOfSpotTextBox);
            this.Controls.Add(this.SwimmingWaterClarityLabel);
            this.Controls.Add(this.SwimmingWaterClarityText);
            this.Controls.Add(this.SwimmingWaterClarityBar);
            this.Controls.Add(this.SwimmingwaterPolutionLevelText);
            this.Controls.Add(this.SwimmingWaterPolutionLevelLabel);
            this.Controls.Add(this.SwimmingWaterPolutionLevelBar);
            this.Controls.Add(this.SwimmingWaterDepthText);
            this.Controls.Add(this.SwimmingWaterDepthLabel);
            this.Controls.Add(this.SwimmingWaterDepthBar);
            this.Name = "SwimmingMessageBox";
            this.Text = "Create New Swimming Pin";
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingWaterDepthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingWaterPolutionLevelBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingWaterClarityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmingDisplaySelectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar SwimmingWaterDepthBar;
        private System.Windows.Forms.Label SwimmingWaterDepthLabel;
        private System.Windows.Forms.Label SwimmingWaterDepthText;
        private System.Windows.Forms.Timer UpdateSwimmingMessageBoxTimer;
        private System.Windows.Forms.TrackBar SwimmingWaterPolutionLevelBar;
        private System.Windows.Forms.Label SwimmingWaterPolutionLevelLabel;
        private System.Windows.Forms.Label SwimmingwaterPolutionLevelText;
        private System.Windows.Forms.TrackBar SwimmingWaterClarityBar;
        private System.Windows.Forms.Label SwimmingWaterClarityText;
        private System.Windows.Forms.Label SwimmingWaterClarityLabel;
        private System.Windows.Forms.TextBox SwimmingNameOfSpotTextBox;
        private System.Windows.Forms.Label SwimmingNameOfSpotLabel;
        private System.Windows.Forms.Button SwimmingUploadPictureButton;
        private System.Windows.Forms.Label SwimmingAddAPictureButtonLabel;
        private System.Windows.Forms.PictureBox SwimmingDisplaySelectedPictureBox;
        private System.Windows.Forms.Label SwimmingDisplayPictureSelectedLabel;
        private System.Windows.Forms.Button SwimmingCreateSwimmingClassButton;
        private System.Windows.Forms.OpenFileDialog SwimmingUploadPictureDialog;
    }
}