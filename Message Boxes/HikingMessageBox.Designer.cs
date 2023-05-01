namespace Final_Project
{
    partial class HikingMessageBox
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
            this.HikingDistanceBar = new System.Windows.Forms.TrackBar();
            this.HikingDistanceLabel = new System.Windows.Forms.Label();
            this.HikingDifficultyBar = new System.Windows.Forms.TrackBar();
            this.HikingDifficultyLabel = new System.Windows.Forms.Label();
            this.HikingDifficultyText = new System.Windows.Forms.Label();
            this.HikingDistanceText = new System.Windows.Forms.Label();
            this.HikingNumberOfOverLooksBar = new System.Windows.Forms.TrackBar();
            this.HikingNumberOfOverlooksLabel = new System.Windows.Forms.Label();
            this.HikingNumberOfOverlooksText = new System.Windows.Forms.Label();
            this.HikingBugLevelBar = new System.Windows.Forms.TrackBar();
            this.HikingBugLevelLabel = new System.Windows.Forms.Label();
            this.HikingBugLevelText = new System.Windows.Forms.Label();
            this.HikingNameOfSpotTextBox = new System.Windows.Forms.TextBox();
            this.HikingNameOfSpotLabel = new System.Windows.Forms.Label();
            this.HikingCreateHikingClassButton = new System.Windows.Forms.Button();
            this.HikingUploadPictureButton = new System.Windows.Forms.Button();
            this.HikingAddAPictureButtonLabel = new System.Windows.Forms.Label();
            this.HikingDisplaySelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.HikingDisplayPictureSelectedLabel = new System.Windows.Forms.Label();
            this.HikingUploadPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.UpdateAllHikingMessageBox = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HikingDistanceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingDifficultyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingNumberOfOverLooksBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingBugLevelBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingDisplaySelectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HikingDistanceBar
            // 
            this.HikingDistanceBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HikingDistanceBar.Location = new System.Drawing.Point(13, 57);
            this.HikingDistanceBar.Maximum = 20;
            this.HikingDistanceBar.Name = "HikingDistanceBar";
            this.HikingDistanceBar.Size = new System.Drawing.Size(685, 45);
            this.HikingDistanceBar.TabIndex = 4;
            this.HikingDistanceBar.TickFrequency = 4;
            // 
            // HikingDistanceLabel
            // 
            this.HikingDistanceLabel.AutoSize = true;
            this.HikingDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingDistanceLabel.Location = new System.Drawing.Point(286, 38);
            this.HikingDistanceLabel.Name = "HikingDistanceLabel";
            this.HikingDistanceLabel.Size = new System.Drawing.Size(133, 16);
            this.HikingDistanceLabel.TabIndex = 5;
            this.HikingDistanceLabel.Text = "Trail Distance (Miles)";
            // 
            // HikingDifficultyBar
            // 
            this.HikingDifficultyBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HikingDifficultyBar.Location = new System.Drawing.Point(209, 189);
            this.HikingDifficultyBar.Maximum = 2;
            this.HikingDifficultyBar.Name = "HikingDifficultyBar";
            this.HikingDifficultyBar.Size = new System.Drawing.Size(277, 45);
            this.HikingDifficultyBar.TabIndex = 7;
            // 
            // HikingDifficultyLabel
            // 
            this.HikingDifficultyLabel.AutoSize = true;
            this.HikingDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingDifficultyLabel.Location = new System.Drawing.Point(303, 170);
            this.HikingDifficultyLabel.Name = "HikingDifficultyLabel";
            this.HikingDifficultyLabel.Size = new System.Drawing.Size(86, 16);
            this.HikingDifficultyLabel.TabIndex = 8;
            this.HikingDifficultyLabel.Text = "Trail Difficulty";
            // 
            // HikingDifficultyText
            // 
            this.HikingDifficultyText.AutoSize = true;
            this.HikingDifficultyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingDifficultyText.Location = new System.Drawing.Point(206, 246);
            this.HikingDifficultyText.Name = "HikingDifficultyText";
            this.HikingDifficultyText.Size = new System.Drawing.Size(86, 16);
            this.HikingDifficultyText.TabIndex = 9;
            this.HikingDifficultyText.Text = "Place Holder";
            // 
            // HikingDistanceText
            // 
            this.HikingDistanceText.AutoSize = true;
            this.HikingDistanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingDistanceText.Location = new System.Drawing.Point(10, 115);
            this.HikingDistanceText.Name = "HikingDistanceText";
            this.HikingDistanceText.Size = new System.Drawing.Size(86, 16);
            this.HikingDistanceText.TabIndex = 10;
            this.HikingDistanceText.Text = "Place Holder";
            // 
            // HikingNumberOfOverLooksBar
            // 
            this.HikingNumberOfOverLooksBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HikingNumberOfOverLooksBar.Location = new System.Drawing.Point(13, 348);
            this.HikingNumberOfOverLooksBar.Name = "HikingNumberOfOverLooksBar";
            this.HikingNumberOfOverLooksBar.Size = new System.Drawing.Size(685, 45);
            this.HikingNumberOfOverLooksBar.TabIndex = 11;
            this.HikingNumberOfOverLooksBar.TickFrequency = 2;
            // 
            // HikingNumberOfOverlooksLabel
            // 
            this.HikingNumberOfOverlooksLabel.AutoSize = true;
            this.HikingNumberOfOverlooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingNumberOfOverlooksLabel.Location = new System.Drawing.Point(283, 329);
            this.HikingNumberOfOverlooksLabel.Name = "HikingNumberOfOverlooksLabel";
            this.HikingNumberOfOverlooksLabel.Size = new System.Drawing.Size(136, 16);
            this.HikingNumberOfOverlooksLabel.TabIndex = 12;
            this.HikingNumberOfOverlooksLabel.Text = "Number Of Overlooks";
            // 
            // HikingNumberOfOverlooksText
            // 
            this.HikingNumberOfOverlooksText.AutoSize = true;
            this.HikingNumberOfOverlooksText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingNumberOfOverlooksText.Location = new System.Drawing.Point(12, 405);
            this.HikingNumberOfOverlooksText.Name = "HikingNumberOfOverlooksText";
            this.HikingNumberOfOverlooksText.Size = new System.Drawing.Size(86, 16);
            this.HikingNumberOfOverlooksText.TabIndex = 13;
            this.HikingNumberOfOverlooksText.Text = "Place Holder";
            // 
            // HikingBugLevelBar
            // 
            this.HikingBugLevelBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HikingBugLevelBar.Location = new System.Drawing.Point(209, 504);
            this.HikingBugLevelBar.Maximum = 3;
            this.HikingBugLevelBar.Name = "HikingBugLevelBar";
            this.HikingBugLevelBar.Size = new System.Drawing.Size(277, 45);
            this.HikingBugLevelBar.TabIndex = 14;
            // 
            // HikingBugLevelLabel
            // 
            this.HikingBugLevelLabel.AutoSize = true;
            this.HikingBugLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingBugLevelLabel.Location = new System.Drawing.Point(287, 485);
            this.HikingBugLevelLabel.Name = "HikingBugLevelLabel";
            this.HikingBugLevelLabel.Size = new System.Drawing.Size(102, 16);
            this.HikingBugLevelLabel.TabIndex = 15;
            this.HikingBugLevelLabel.Text = "Amount Of Bugs";
            // 
            // HikingBugLevelText
            // 
            this.HikingBugLevelText.AutoSize = true;
            this.HikingBugLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingBugLevelText.Location = new System.Drawing.Point(206, 563);
            this.HikingBugLevelText.Name = "HikingBugLevelText";
            this.HikingBugLevelText.Size = new System.Drawing.Size(86, 16);
            this.HikingBugLevelText.TabIndex = 16;
            this.HikingBugLevelText.Text = "Place Holder";
            // 
            // HikingNameOfSpotTextBox
            // 
            this.HikingNameOfSpotTextBox.Location = new System.Drawing.Point(13, 670);
            this.HikingNameOfSpotTextBox.Name = "HikingNameOfSpotTextBox";
            this.HikingNameOfSpotTextBox.Size = new System.Drawing.Size(685, 20);
            this.HikingNameOfSpotTextBox.TabIndex = 17;
            // 
            // HikingNameOfSpotLabel
            // 
            this.HikingNameOfSpotLabel.AutoSize = true;
            this.HikingNameOfSpotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingNameOfSpotLabel.Location = new System.Drawing.Point(299, 651);
            this.HikingNameOfSpotLabel.Name = "HikingNameOfSpotLabel";
            this.HikingNameOfSpotLabel.Size = new System.Drawing.Size(90, 16);
            this.HikingNameOfSpotLabel.TabIndex = 18;
            this.HikingNameOfSpotLabel.Text = "Name Of Trail";
            // 
            // HikingCreateHikingClassButton
            // 
            this.HikingCreateHikingClassButton.Location = new System.Drawing.Point(593, 800);
            this.HikingCreateHikingClassButton.Name = "HikingCreateHikingClassButton";
            this.HikingCreateHikingClassButton.Size = new System.Drawing.Size(105, 45);
            this.HikingCreateHikingClassButton.TabIndex = 22;
            this.HikingCreateHikingClassButton.Text = "Create";
            this.HikingCreateHikingClassButton.UseVisualStyleBackColor = true;
            this.HikingCreateHikingClassButton.Click += new System.EventHandler(this.HikingCreateHikingClassButton_Click);
            // 
            // HikingUploadPictureButton
            // 
            this.HikingUploadPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingUploadPictureButton.Location = new System.Drawing.Point(316, 785);
            this.HikingUploadPictureButton.Name = "HikingUploadPictureButton";
            this.HikingUploadPictureButton.Size = new System.Drawing.Size(64, 47);
            this.HikingUploadPictureButton.TabIndex = 23;
            this.HikingUploadPictureButton.Text = "Add Picture";
            this.HikingUploadPictureButton.UseVisualStyleBackColor = true;
            this.HikingUploadPictureButton.Click += new System.EventHandler(this.HikingUploadPictureButton_Click);
            // 
            // HikingAddAPictureButtonLabel
            // 
            this.HikingAddAPictureButtonLabel.AutoSize = true;
            this.HikingAddAPictureButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingAddAPictureButtonLabel.Location = new System.Drawing.Point(303, 757);
            this.HikingAddAPictureButtonLabel.Name = "HikingAddAPictureButtonLabel";
            this.HikingAddAPictureButtonLabel.Size = new System.Drawing.Size(88, 16);
            this.HikingAddAPictureButtonLabel.TabIndex = 24;
            this.HikingAddAPictureButtonLabel.Text = "Add A Picture";
            // 
            // HikingDisplaySelectedPictureBox
            // 
            this.HikingDisplaySelectedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HikingDisplaySelectedPictureBox.Location = new System.Drawing.Point(12, 770);
            this.HikingDisplaySelectedPictureBox.Name = "HikingDisplaySelectedPictureBox";
            this.HikingDisplaySelectedPictureBox.Size = new System.Drawing.Size(75, 75);
            this.HikingDisplaySelectedPictureBox.TabIndex = 25;
            this.HikingDisplaySelectedPictureBox.TabStop = false;
            // 
            // HikingDisplayPictureSelectedLabel
            // 
            this.HikingDisplayPictureSelectedLabel.AutoSize = true;
            this.HikingDisplayPictureSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HikingDisplayPictureSelectedLabel.Location = new System.Drawing.Point(10, 751);
            this.HikingDisplayPictureSelectedLabel.Name = "HikingDisplayPictureSelectedLabel";
            this.HikingDisplayPictureSelectedLabel.Size = new System.Drawing.Size(105, 16);
            this.HikingDisplayPictureSelectedLabel.TabIndex = 26;
            this.HikingDisplayPictureSelectedLabel.Text = "Selected Picture";
            // 
            // HikingUploadPictureDialog
            // 
            this.HikingUploadPictureDialog.FileName = "openFileDialog1";
            // 
            // UpdateAllHikingMessageBox
            // 
            this.UpdateAllHikingMessageBox.Enabled = true;
            this.UpdateAllHikingMessageBox.Interval = 50;
            this.UpdateAllHikingMessageBox.Tick += new System.EventHandler(this.UpdateAllHikingMessageBox_Tick);
            // 
            // HikingMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 857);
            this.Controls.Add(this.HikingDisplayPictureSelectedLabel);
            this.Controls.Add(this.HikingDisplaySelectedPictureBox);
            this.Controls.Add(this.HikingAddAPictureButtonLabel);
            this.Controls.Add(this.HikingUploadPictureButton);
            this.Controls.Add(this.HikingCreateHikingClassButton);
            this.Controls.Add(this.HikingNameOfSpotLabel);
            this.Controls.Add(this.HikingNameOfSpotTextBox);
            this.Controls.Add(this.HikingBugLevelText);
            this.Controls.Add(this.HikingBugLevelLabel);
            this.Controls.Add(this.HikingBugLevelBar);
            this.Controls.Add(this.HikingNumberOfOverlooksText);
            this.Controls.Add(this.HikingNumberOfOverlooksLabel);
            this.Controls.Add(this.HikingNumberOfOverLooksBar);
            this.Controls.Add(this.HikingDistanceText);
            this.Controls.Add(this.HikingDifficultyText);
            this.Controls.Add(this.HikingDifficultyLabel);
            this.Controls.Add(this.HikingDifficultyBar);
            this.Controls.Add(this.HikingDistanceLabel);
            this.Controls.Add(this.HikingDistanceBar);
            this.Name = "HikingMessageBox";
            this.Text = "Create New Hiking Pin";
            ((System.ComponentModel.ISupportInitialize)(this.HikingDistanceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingDifficultyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingNumberOfOverLooksBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingBugLevelBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HikingDisplaySelectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar HikingDistanceBar;
        private System.Windows.Forms.Label HikingDistanceLabel;
        private System.Windows.Forms.TrackBar HikingDifficultyBar;
        private System.Windows.Forms.Label HikingDifficultyLabel;
        private System.Windows.Forms.Label HikingDifficultyText;
        private System.Windows.Forms.Label HikingDistanceText;
        private System.Windows.Forms.TrackBar HikingNumberOfOverLooksBar;
        private System.Windows.Forms.Label HikingNumberOfOverlooksLabel;
        private System.Windows.Forms.Label HikingNumberOfOverlooksText;
        private System.Windows.Forms.TrackBar HikingBugLevelBar;
        private System.Windows.Forms.Label HikingBugLevelLabel;
        private System.Windows.Forms.Label HikingBugLevelText;
        private System.Windows.Forms.TextBox HikingNameOfSpotTextBox;
        private System.Windows.Forms.Label HikingNameOfSpotLabel;
        private System.Windows.Forms.Button HikingCreateHikingClassButton;
        private System.Windows.Forms.Button HikingUploadPictureButton;
        private System.Windows.Forms.Label HikingAddAPictureButtonLabel;
        private System.Windows.Forms.PictureBox HikingDisplaySelectedPictureBox;
        private System.Windows.Forms.Label HikingDisplayPictureSelectedLabel;
        private System.Windows.Forms.OpenFileDialog HikingUploadPictureDialog;
        private System.Windows.Forms.Timer UpdateAllHikingMessageBox;
    }
}