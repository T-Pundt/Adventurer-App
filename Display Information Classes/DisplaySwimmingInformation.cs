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
    public partial class DisplaySwimmingInformation : Form
    {

        #region Load In
        public DisplaySwimmingInformation()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        public int WaterClarity { get; set; }
        public int WaterDepth { get; set; }
        public int WaterPolution { get; set; }
        public string NameOfSwimmingSpot { get; set; }
        public string PictureFileName { get; set; }
        public string ClassName { get; set; }

        #endregion

        #region Button
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Update Information Boxes
        private void UpdateSwimmingInformationBoxesTimer_Tick(object sender, EventArgs e)
        {
            {
                SwimmingPictureOfArea.Image = Image.FromFile(PictureFileName);
                WaterClarityDisplayTextBox.Text = WaterClarity.ToString();
                DisplayNameOfSwimmingSpotText.Text = NameOfSwimmingSpot;
                SwimmingDisplayWaterDepthText.Text = WaterDepth.ToString();
                if(WaterPolution == 0) { SwimmingDisplayPolutionLevel.Text = "None"; }
                else if(WaterPolution == 1) { SwimmingDisplayPolutionLevel.Text = "Low";  }
                else if(WaterPolution == 2) { SwimmingDisplayPolutionLevel.Text = "Medium"; }
                else if(WaterPolution == 3) { SwimmingDisplayPolutionLevel.Text = "High";  }
            }
        }
        #endregion

    }
}
