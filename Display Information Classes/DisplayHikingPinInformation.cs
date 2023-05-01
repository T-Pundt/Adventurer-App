using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DisplayHikingPinInformation : Form
    {
        #region Load In
        public DisplayHikingPinInformation()
        {
            InitializeComponent();
        }
        #endregion

        #region Button
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Properties
        public int HikeDistance { get; set; }
        public int HikeDifficulty { get; set; }
        public int NumberOfOverlooks { get; set; }
        public int BugLevel { get; set; }
        public string NameOfHikingSpot { get; set; }
        public string PictureFileName { get; set; }
        public string ClassName { get; set; }


        #endregion

        #region Timer To Update Values
        private void UpdateAllOfDisplayHikingPinInformation_Tick(object sender, EventArgs e)
        {
            HikingPictureOfArea.Image = Image.FromFile(PictureFileName);
            DisplayNameOfHikingSpotText.Text = NameOfHikingSpot;
            DisplayHikingDistanceText.Text = HikeDistance.ToString();
            DisplayHikingNumberOfOverlooksText.Text = NumberOfOverlooks.ToString();
            if(HikeDifficulty == 0) { DisplayHikingDifficultyText.Text = "Beginner"; }
            else if(HikeDifficulty == 1) { DisplayHikingDifficultyText.Text = "Intermediate"; }
            else if(HikeDifficulty == 2) { DisplayHikingDifficultyText.Text = "Advanced"; }
            if(BugLevel == 0) { DisplayHikingLevelOfBugsText.Text = "None"; }
            else if (BugLevel == 1) { DisplayHikingLevelOfBugsText.Text = "Low"; }
            else if (BugLevel == 2) { DisplayHikingLevelOfBugsText.Text = "Medium"; }
            else if (BugLevel == 3) { DisplayHikingLevelOfBugsText.Text = "High"; }
        }
        #endregion
    }
}
