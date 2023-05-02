namespace Final_Project
{
    partial class ClimbingMessageBox
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
            this.ClimbingDistanceBar = new System.Windows.Forms.TrackBar();
            this.ClimbingDistanceLabel = new System.Windows.Forms.Label();
            this.ClimbingDistanceText = new System.Windows.Forms.Label();
            this.ClimbingRockTypeTextBox = new System.Windows.Forms.TextBox();
            this.ClimbingRockTypeLabel = new System.Windows.Forms.Label();
            this.ClimbingRouteDifficultyTextBox = new System.Windows.Forms.TextBox();
            this.RouteDifficultyLabel = new System.Windows.Forms.Label();
            this.ClimbingRouteDegreeBar = new System.Windows.Forms.TrackBar();
            this.ClimbingRouteDegreeLabel = new System.Windows.Forms.Label();
            this.ClimbingNameOfRouteTextBox = new System.Windows.Forms.TextBox();
            this.ClimbingNameOfRouteLabel = new System.Windows.Forms.Label();
            this.ClimbingUploadPictureButton = new System.Windows.Forms.Button();
            this.ClimbingAddAPictureButtonLabel = new System.Windows.Forms.Label();
            this.ClimbingDisplaySelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.ClimbingDisplayPictureSelectedLabel = new System.Windows.Forms.Label();
            this.ClimbingCreateClassButton = new System.Windows.Forms.Button();
            this.ClimbingRouteDegreeText = new System.Windows.Forms.Label();
            this.UpdateAllClimbingMessageBox = new System.Windows.Forms.Timer(this.components);
            this.ClimbingUploadPictureDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ClimbingDistanceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClimbingRouteDegreeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClimbingDisplaySelectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClimbingDistanceBar
            // 
            this.ClimbingDistanceBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClimbingDistanceBar.Location = new System.Drawing.Point(13, 58);
            this.ClimbingDistanceBar.Maximum = 200;
            this.ClimbingDistanceBar.Name = "ClimbingDistanceBar";
            this.ClimbingDistanceBar.Size = new System.Drawing.Size(685, 45);
            this.ClimbingDistanceBar.TabIndex = 5;
            this.ClimbingDistanceBar.TickFrequency = 20;
            // 
            // ClimbingDistanceLabel
            // 
            this.ClimbingDistanceLabel.AutoSize = true;
            this.ClimbingDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingDistanceLabel.Location = new System.Drawing.Point(294, 39);
            this.ClimbingDistanceLabel.Name = "ClimbingDistanceLabel";
            this.ClimbingDistanceLabel.Size = new System.Drawing.Size(122, 16);
            this.ClimbingDistanceLabel.TabIndex = 6;
            this.ClimbingDistanceLabel.Text = "Route Distance ( ft )";
            // 
            // ClimbingDistanceText
            // 
            this.ClimbingDistanceText.AutoSize = true;
            this.ClimbingDistanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingDistanceText.Location = new System.Drawing.Point(12, 115);
            this.ClimbingDistanceText.Name = "ClimbingDistanceText";
            this.ClimbingDistanceText.Size = new System.Drawing.Size(86, 16);
            this.ClimbingDistanceText.TabIndex = 11;
            this.ClimbingDistanceText.Text = "Place Holder";
            // 
            // ClimbingRockTypeTextBox
            // 
            this.ClimbingRockTypeTextBox.Location = new System.Drawing.Point(13, 216);
            this.ClimbingRockTypeTextBox.Name = "ClimbingRockTypeTextBox";
            this.ClimbingRockTypeTextBox.Size = new System.Drawing.Size(685, 20);
            this.ClimbingRockTypeTextBox.TabIndex = 18;
            // 
            // ClimbingRockTypeLabel
            // 
            this.ClimbingRockTypeLabel.AutoSize = true;
            this.ClimbingRockTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingRockTypeLabel.Location = new System.Drawing.Point(303, 197);
            this.ClimbingRockTypeLabel.Name = "ClimbingRockTypeLabel";
            this.ClimbingRockTypeLabel.Size = new System.Drawing.Size(90, 16);
            this.ClimbingRockTypeLabel.TabIndex = 19;
            this.ClimbingRockTypeLabel.Text = "Type Of Rock";
            // 
            // ClimbingRouteDifficultyTextBox
            // 
            this.ClimbingRouteDifficultyTextBox.Location = new System.Drawing.Point(13, 347);
            this.ClimbingRouteDifficultyTextBox.Name = "ClimbingRouteDifficultyTextBox";
            this.ClimbingRouteDifficultyTextBox.Size = new System.Drawing.Size(685, 20);
            this.ClimbingRouteDifficultyTextBox.TabIndex = 20;
            // 
            // RouteDifficultyLabel
            // 
            this.RouteDifficultyLabel.AutoSize = true;
            this.RouteDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteDifficultyLabel.Location = new System.Drawing.Point(298, 328);
            this.RouteDifficultyLabel.Name = "RouteDifficultyLabel";
            this.RouteDifficultyLabel.Size = new System.Drawing.Size(95, 16);
            this.RouteDifficultyLabel.TabIndex = 21;
            this.RouteDifficultyLabel.Text = "Route Difficulty";
            // 
            // ClimbingRouteDegreeBar
            // 
            this.ClimbingRouteDegreeBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClimbingRouteDegreeBar.Location = new System.Drawing.Point(13, 459);
            this.ClimbingRouteDegreeBar.Maximum = 90;
            this.ClimbingRouteDegreeBar.Name = "ClimbingRouteDegreeBar";
            this.ClimbingRouteDegreeBar.Size = new System.Drawing.Size(685, 45);
            this.ClimbingRouteDegreeBar.TabIndex = 22;
            this.ClimbingRouteDegreeBar.TickFrequency = 9;
            // 
            // ClimbingRouteDegreeLabel
            // 
            this.ClimbingRouteDegreeLabel.AutoSize = true;
            this.ClimbingRouteDegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingRouteDegreeLabel.Location = new System.Drawing.Point(298, 440);
            this.ClimbingRouteDegreeLabel.Name = "ClimbingRouteDegreeLabel";
            this.ClimbingRouteDegreeLabel.Size = new System.Drawing.Size(108, 16);
            this.ClimbingRouteDegreeLabel.TabIndex = 23;
            this.ClimbingRouteDegreeLabel.Text = "Degree Of Route";
            // 
            // ClimbingNameOfRouteTextBox
            // 
            this.ClimbingNameOfRouteTextBox.Location = new System.Drawing.Point(13, 611);
            this.ClimbingNameOfRouteTextBox.Name = "ClimbingNameOfRouteTextBox";
            this.ClimbingNameOfRouteTextBox.Size = new System.Drawing.Size(685, 20);
            this.ClimbingNameOfRouteTextBox.TabIndex = 24;
            // 
            // ClimbingNameOfRouteLabel
            // 
            this.ClimbingNameOfRouteLabel.AutoSize = true;
            this.ClimbingNameOfRouteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingNameOfRouteLabel.Location = new System.Drawing.Point(298, 592);
            this.ClimbingNameOfRouteLabel.Name = "ClimbingNameOfRouteLabel";
            this.ClimbingNameOfRouteLabel.Size = new System.Drawing.Size(99, 16);
            this.ClimbingNameOfRouteLabel.TabIndex = 25;
            this.ClimbingNameOfRouteLabel.Text = "Name Of Route";
            // 
            // ClimbingUploadPictureButton
            // 
            this.ClimbingUploadPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingUploadPictureButton.Location = new System.Drawing.Point(316, 742);
            this.ClimbingUploadPictureButton.Name = "ClimbingUploadPictureButton";
            this.ClimbingUploadPictureButton.Size = new System.Drawing.Size(64, 47);
            this.ClimbingUploadPictureButton.TabIndex = 26;
            this.ClimbingUploadPictureButton.Text = "Add Picture";
            this.ClimbingUploadPictureButton.UseVisualStyleBackColor = true;
            this.ClimbingUploadPictureButton.Click += new System.EventHandler(this.ClimbingUploadPictureButton_Click);
            // 
            // ClimbingAddAPictureButtonLabel
            // 
            this.ClimbingAddAPictureButtonLabel.AutoSize = true;
            this.ClimbingAddAPictureButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingAddAPictureButtonLabel.Location = new System.Drawing.Point(305, 714);
            this.ClimbingAddAPictureButtonLabel.Name = "ClimbingAddAPictureButtonLabel";
            this.ClimbingAddAPictureButtonLabel.Size = new System.Drawing.Size(88, 16);
            this.ClimbingAddAPictureButtonLabel.TabIndex = 27;
            this.ClimbingAddAPictureButtonLabel.Text = "Add A Picture";
            // 
            // ClimbingDisplaySelectedPictureBox
            // 
            this.ClimbingDisplaySelectedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClimbingDisplaySelectedPictureBox.Location = new System.Drawing.Point(12, 772);
            this.ClimbingDisplaySelectedPictureBox.Name = "ClimbingDisplaySelectedPictureBox";
            this.ClimbingDisplaySelectedPictureBox.Size = new System.Drawing.Size(75, 75);
            this.ClimbingDisplaySelectedPictureBox.TabIndex = 28;
            this.ClimbingDisplaySelectedPictureBox.TabStop = false;
            // 
            // ClimbingDisplayPictureSelectedLabel
            // 
            this.ClimbingDisplayPictureSelectedLabel.AutoSize = true;
            this.ClimbingDisplayPictureSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingDisplayPictureSelectedLabel.Location = new System.Drawing.Point(9, 742);
            this.ClimbingDisplayPictureSelectedLabel.Name = "ClimbingDisplayPictureSelectedLabel";
            this.ClimbingDisplayPictureSelectedLabel.Size = new System.Drawing.Size(105, 16);
            this.ClimbingDisplayPictureSelectedLabel.TabIndex = 29;
            this.ClimbingDisplayPictureSelectedLabel.Text = "Selected Picture";
            // 
            // ClimbingCreateClassButton
            // 
            this.ClimbingCreateClassButton.Location = new System.Drawing.Point(593, 802);
            this.ClimbingCreateClassButton.Name = "ClimbingCreateClassButton";
            this.ClimbingCreateClassButton.Size = new System.Drawing.Size(105, 45);
            this.ClimbingCreateClassButton.TabIndex = 30;
            this.ClimbingCreateClassButton.Text = "Create";
            this.ClimbingCreateClassButton.UseVisualStyleBackColor = true;
            this.ClimbingCreateClassButton.Click += new System.EventHandler(this.ClimbingCreateClassButton_Click);
            // 
            // ClimbingRouteDegreeText
            // 
            this.ClimbingRouteDegreeText.AutoSize = true;
            this.ClimbingRouteDegreeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimbingRouteDegreeText.Location = new System.Drawing.Point(12, 507);
            this.ClimbingRouteDegreeText.Name = "ClimbingRouteDegreeText";
            this.ClimbingRouteDegreeText.Size = new System.Drawing.Size(86, 16);
            this.ClimbingRouteDegreeText.TabIndex = 31;
            this.ClimbingRouteDegreeText.Text = "Place Holder";
            // 
            // UpdateAllClimbingMessageBox
            // 
            this.UpdateAllClimbingMessageBox.Enabled = true;
            this.UpdateAllClimbingMessageBox.Interval = 50;
            this.UpdateAllClimbingMessageBox.Tick += new System.EventHandler(this.UpdateAllClimbingMessageBox_Tick);
            // 
            // ClimbingUploadPictureDialog
            // 
            this.ClimbingUploadPictureDialog.FileName = "openFileDialog1";
            // 
            // ClimbingMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 859);
            this.Controls.Add(this.ClimbingRouteDegreeText);
            this.Controls.Add(this.ClimbingCreateClassButton);
            this.Controls.Add(this.ClimbingDisplayPictureSelectedLabel);
            this.Controls.Add(this.ClimbingDisplaySelectedPictureBox);
            this.Controls.Add(this.ClimbingAddAPictureButtonLabel);
            this.Controls.Add(this.ClimbingUploadPictureButton);
            this.Controls.Add(this.ClimbingNameOfRouteLabel);
            this.Controls.Add(this.ClimbingNameOfRouteTextBox);
            this.Controls.Add(this.ClimbingRouteDegreeLabel);
            this.Controls.Add(this.ClimbingRouteDegreeBar);
            this.Controls.Add(this.RouteDifficultyLabel);
            this.Controls.Add(this.ClimbingRouteDifficultyTextBox);
            this.Controls.Add(this.ClimbingRockTypeLabel);
            this.Controls.Add(this.ClimbingRockTypeTextBox);
            this.Controls.Add(this.ClimbingDistanceText);
            this.Controls.Add(this.ClimbingDistanceLabel);
            this.Controls.Add(this.ClimbingDistanceBar);
            this.Name = "ClimbingMessageBox";
            this.Text = "Create New Climbing Pin";
            ((System.ComponentModel.ISupportInitialize)(this.ClimbingDistanceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClimbingRouteDegreeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClimbingDisplaySelectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar ClimbingDistanceBar;
        private System.Windows.Forms.Label ClimbingDistanceLabel;
        private System.Windows.Forms.Label ClimbingDistanceText;
        private System.Windows.Forms.TextBox ClimbingRockTypeTextBox;
        private System.Windows.Forms.Label ClimbingRockTypeLabel;
        private System.Windows.Forms.TextBox ClimbingRouteDifficultyTextBox;
        private System.Windows.Forms.Label RouteDifficultyLabel;
        private System.Windows.Forms.TrackBar ClimbingRouteDegreeBar;
        private System.Windows.Forms.Label ClimbingRouteDegreeLabel;
        private System.Windows.Forms.TextBox ClimbingNameOfRouteTextBox;
        private System.Windows.Forms.Label ClimbingNameOfRouteLabel;
        private System.Windows.Forms.Button ClimbingUploadPictureButton;
        private System.Windows.Forms.Label ClimbingAddAPictureButtonLabel;
        private System.Windows.Forms.PictureBox ClimbingDisplaySelectedPictureBox;
        private System.Windows.Forms.Label ClimbingDisplayPictureSelectedLabel;
        private System.Windows.Forms.Button ClimbingCreateClassButton;
        private System.Windows.Forms.Label ClimbingRouteDegreeText;
        private System.Windows.Forms.Timer UpdateAllClimbingMessageBox;
        private System.Windows.Forms.OpenFileDialog ClimbingUploadPictureDialog;
    }
}