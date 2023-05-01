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
    public partial class HikingMessageBox : Form
    {
        #region Load In
        public HikingMessageBox()
        {
            InitializeComponent();
        }

        #endregion

        #region Variables

        private string _pictureFileName;

        private string _itemTag;

        HikingPin HP1;
        HikingPin HP2;
        HikingPin HP3;
        HikingPin HP4;
        HikingPin HP5;

        #endregion

        #region Properties

        public string ItemTag
        {
            get { return _itemTag; }
        }

        #endregion

        #region Buttons
        private void HikingCreateHikingClassButton_Click(object sender, EventArgs e)
        {
            if(HikingDistanceBar.Value != 0 && HikingNameOfSpotTextBox.Text != null && _pictureFileName != null)
            {
                if(HP1 == null)
                {
                    HP1 = new HikingPin(HikingNameOfSpotTextBox.Text, HikingBugLevelBar.Value, HikingDifficultyBar.Value, HikingDistanceBar.Value, HikingNumberOfOverLooksBar.Value, _pictureFileName, "HP1");
                    _itemTag = "HP1";
                }
                else if(HP2 == null)
                {
                    HP2 = new HikingPin(HikingNameOfSpotTextBox.Text, HikingBugLevelBar.Value, HikingDifficultyBar.Value, HikingDistanceBar.Value, HikingNumberOfOverLooksBar.Value, _pictureFileName, "HP2");
                    _itemTag = "HP2";
                }
                else if (HP3 == null)
                {
                    HP3 = new HikingPin(HikingNameOfSpotTextBox.Text, HikingBugLevelBar.Value, HikingDifficultyBar.Value, HikingDistanceBar.Value, HikingNumberOfOverLooksBar.Value, _pictureFileName, "HP3");
                    _itemTag = "HP3";
                }
                else if (HP4 == null)
                {
                    HP4 = new HikingPin(HikingNameOfSpotTextBox.Text, HikingBugLevelBar.Value, HikingDifficultyBar.Value, HikingDistanceBar.Value, HikingNumberOfOverLooksBar.Value, _pictureFileName, "HP4");
                    _itemTag = "HP4";
                }
                else if (HP5 == null)
                {
                    HP5 = new HikingPin(HikingNameOfSpotTextBox.Text, HikingBugLevelBar.Value, HikingDifficultyBar.Value, HikingDistanceBar.Value, HikingNumberOfOverLooksBar.Value, _pictureFileName, "HP5");
                    _itemTag = "HP5";
                }
                else
                {
                    MessageBox.Show("There Are Five Swimming Pins on the Map already");
                    return;
                }
            }
            else { throw new Exception("There was atleast one empty field"); }
            ResetValues();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

      

        private void HikingUploadPictureButton_Click(object sender, EventArgs e)
        {
            HikingUploadPictureDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            DialogResult result = HikingUploadPictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _pictureFileName = HikingUploadPictureDialog.FileName;
                MessageBox.Show("You selected " + _pictureFileName);

                HikingDisplaySelectedPictureBox.Image = Image.FromFile(_pictureFileName);
            }
        }

        #endregion

        #region Update Hiking Message Box
        private void UpdateAllHikingMessageBox_Tick(object sender, EventArgs e)
        {
            HikingDistanceText.Text = HikingDistanceBar.Value.ToString();
            if (HikingDifficultyBar.Value == 0) { HikingDifficultyText.Text = "Beginner"; }
            else if (HikingDifficultyBar.Value == 1) { HikingDifficultyText.Text = "Intermediate"; }
            else if (HikingDifficultyBar.Value == 2) { HikingDifficultyText.Text = "Advanced"; }
            HikingNumberOfOverlooksText.Text = HikingNumberOfOverLooksBar.Value.ToString();
            if (HikingBugLevelBar.Value == 0) { HikingBugLevelText.Text = "None"; }
            else if (HikingBugLevelBar.Value == 1) { HikingBugLevelText.Text = "Low"; }
            else if (HikingBugLevelBar.Value == 2) { HikingBugLevelText.Text = "Medium"; }
            else if (HikingBugLevelBar.Value == 3) { HikingBugLevelText.Text = "High"; }
        }

        #endregion

        #region Methods

        public void ResetValues()
        {
            HikingDistanceBar.Value = 0;
            HikingDifficultyBar.Value = 0;
            HikingNumberOfOverLooksBar.Value = 0;
            HikingBugLevelBar.Value = 0;
            HikingNameOfSpotTextBox.Text = null;
            _pictureFileName = null;
            HikingDisplaySelectedPictureBox.Image = null;
        }




        public void DetermineClass(string ClassName)
        {
            if (ClassName == "HP1")
            {
                HP1.DisplayPinInformation("HP1");
            }
            else if (ClassName == "HP2")
            {
                HP2.DisplayPinInformation("HP2");
            }
            else if (ClassName == "HP3")
            {
                HP3.DisplayPinInformation("HP3");
            }
            else if (ClassName == "HP4")
            {
                HP4.DisplayPinInformation("HP4");
            }
            else if (ClassName == "HP5")
            {
                HP5.DisplayPinInformation("HP5");
            }
            else
            {
                throw new Exception("Class Not Found");
            }

        }

        #endregion


    }
}
