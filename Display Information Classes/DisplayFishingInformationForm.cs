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
    public partial class DisplayFishingInformationForm : Form
    {
        #region Load in
        public DisplayFishingInformationForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Update Display Page
        private void UpdateAllTextBoxes_Tick(object sender, EventArgs e)
        {
            PictureOfArea.Image = Image.FromFile(PictureFileName);
            WaterClarityDisplayTextBox.Text = WaterClarity.ToString();
            DisplayNameOfFishingSpotText.Text = NameOfFishingSpot;
            if (BoatAccess == false) { DisplayBoatAccessabilityText.Text = "No"; }
            else { DisplayBoatAccessabilityText.Text = "Yes"; }
            DisplayWaterDepthText.Text = WaterDepth.ToString();
            DisplayFishInTheAreaText.Text = StringOfFish;
        }
        #endregion

        #region Properties

        public int WaterClarity { get; set; }
        public int WaterDepth { get; set; }
        public string StringOfFish { get; set; }
        public string NameOfFishingSpot { get; set;}
        public bool BoatAccess { get; set; }
        public string PictureFileName { get; set; }
        public string ClassName { get; set; }



        #endregion

        #region Button
        public void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
