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
    public partial class ClimbingMessageBox : Form
    {

        #region Load In
        public ClimbingMessageBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables

        private string _pictureFileName;

        private string _itemTag;

        ClimbingPin CP1;
        ClimbingPin CP2;
        ClimbingPin CP3;
        ClimbingPin CP4;
        ClimbingPin CP5;

        #endregion

        #region Properties

        public string ItemTag
        {
            get { return _itemTag; }
        }

        #endregion

        #region Button
        private void ClimbingUploadPictureButton_Click(object sender, EventArgs e)
        {
            ClimbingUploadPictureDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            DialogResult result = ClimbingUploadPictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _pictureFileName = ClimbingUploadPictureDialog.FileName;
                MessageBox.Show("You selected " + _pictureFileName);

                ClimbingDisplaySelectedPictureBox.Image = Image.FromFile(_pictureFileName);
            }
        }

        private void ClimbingCreateClassButton_Click(object sender, EventArgs e)
        {
            if (ClimbingDistanceBar.Value != 0 && ClimbingRockTypeTextBox.Text != null && ClimbingRouteDifficultyTextBox.Text != null && ClimbingNameOfRouteTextBox.Text != null && _pictureFileName != null)
            {
                if (CP1 == null)
                {
                    CP1 = new ClimbingPin("CP1", _pictureFileName, ClimbingDistanceBar.Value, ClimbingRouteDegreeBar.Value, ClimbingRockTypeTextBox.Text, ClimbingRouteDifficultyTextBox.Text, ClimbingNameOfRouteTextBox.Text);
                    _itemTag = "CP1";
                }
                else if (CP2 == null)
                {
                    CP2 = new ClimbingPin("CP2", _pictureFileName, ClimbingDistanceBar.Value, ClimbingRouteDegreeBar.Value, ClimbingRockTypeTextBox.Text, ClimbingRouteDifficultyTextBox.Text, ClimbingNameOfRouteTextBox.Text);
                    _itemTag = "CP2";
                }
                else if (CP3 == null)
                {
                    CP3 = new ClimbingPin("CP3", _pictureFileName, ClimbingDistanceBar.Value, ClimbingRouteDegreeBar.Value, ClimbingRockTypeTextBox.Text, ClimbingRouteDifficultyTextBox.Text, ClimbingNameOfRouteTextBox.Text);
                    _itemTag = "CP3";
                }
                else if (CP4 == null)
                {
                    CP4 = new ClimbingPin("CP4", _pictureFileName, ClimbingDistanceBar.Value, ClimbingRouteDegreeBar.Value, ClimbingRockTypeTextBox.Text, ClimbingRouteDifficultyTextBox.Text, ClimbingNameOfRouteTextBox.Text);
                    _itemTag = "CP4";
                }
                else if (CP5 == null)
                {
                    CP5 = new ClimbingPin("CP5", _pictureFileName, ClimbingDistanceBar.Value, ClimbingRouteDegreeBar.Value, ClimbingRockTypeTextBox.Text, ClimbingRouteDifficultyTextBox.Text, ClimbingNameOfRouteTextBox.Text);
                    _itemTag = "CP5";
                }
                else
                {
                    MessageBox.Show("There Are Five Climbing Pins on the Map already");
                    return;
                }
            }
            else { throw new Exception("There was atleast one empty field"); }
            ResetValues();
            this.DialogResult = DialogResult.OK;
            this.Close();
                    
        }

        #endregion

        #region Update Climbing Message Box
        private void UpdateAllClimbingMessageBox_Tick(object sender, EventArgs e)
        {
            ClimbingDistanceText.Text = ClimbingDistanceBar.Value.ToString();
            ClimbingRouteDegreeText.Text = ClimbingRouteDegreeBar.Value.ToString();
        }
        #endregion

        #region Methods

        public void ResetValues()
        {
            ClimbingDistanceBar.Value = 0;
            ClimbingRouteDifficultyTextBox.Text = null;
            ClimbingRouteDegreeBar.Value = 0;
            ClimbingRockTypeTextBox.Text = null;
            ClimbingNameOfRouteTextBox.Text = null;
            _pictureFileName = null;
            ClimbingDisplaySelectedPictureBox.Image = null;
        }


        public void DetermineClass(string ClassName)
        {
            if (ClassName == "CP1")
            {
                CP1.DisplayPinInformation("CP1");
            }
            else if (ClassName == "CP2")
            {
                CP2.DisplayPinInformation("CP2");
            }
            else if (ClassName == "CP3")
            {
                CP3.DisplayPinInformation("CP3");
            }
            else if (ClassName == "CP4")
            {
                CP4.DisplayPinInformation("CP4");
            }
            else if (ClassName == "CP5")
            {
                CP5.DisplayPinInformation("CP5");
            }
            else
            {
                throw new Exception("Class Not Found");
            }

        }

        #endregion
    }
}
