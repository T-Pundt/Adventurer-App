using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FishingMessageBox : Form
    {
        #region Variables

        private bool _boatAccessability = false;

        private bool _yesOrNoBoxWasClicked = false;

        private string _pictureFileName;

        private string _itemTag;

        FishingPin FP1;
        FishingPin FP2;
        FishingPin FP3;
        FishingPin FP4;
        FishingPin FP5;

        #endregion

        #region Properties

        public string ItemTag
        {
            get { return _itemTag; }
        }

        #endregion

        #region Loading
        public FishingMessageBox()
        {
            InitializeComponent();
        }

        private void FishingMessageBox_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Update Bars
        private void TimerToUpdateDepthBar_Tick(object sender, EventArgs e)
        {
            if (WaterDepthBar.Value == 100)
            {
                DisplayCurrentDepthForTrackBar.Text = ">100";
            }
            else
            {
                DisplayCurrentDepthForTrackBar.Text = WaterDepthBar.Value.ToString();
            }

            if (WaterClarityBar.Value == 10)
            {
                DisplayCurrentWaterClarityForBar.Text = ">10";
            }
            else
            {
                DisplayCurrentWaterClarityForBar.Text = WaterClarityBar.Value.ToString();
            }


        }


        #endregion

        #region Buttons
        private void YesButton_Click(object sender, EventArgs e)
        {
            _yesOrNoBoxWasClicked = true;
            _boatAccessability = true;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            _yesOrNoBoxWasClicked = true;
            _boatAccessability = false;
        }

        private void CreateFishingClass_Clicked(object sender, EventArgs e)
        {

            if (NameOfFishingSpotBox.Text != null && ListOfFishTextBox.Text != null && _yesOrNoBoxWasClicked != false && _pictureFileName != null && WaterDepthBar.Value != 0 && WaterClarityBar.Value != 0)
            {
                if (FP1 == null)
                {
                    FP1 = new FishingPin(NameOfFishingSpotBox.Text, ListOfFishTextBox.Text, _boatAccessability, _pictureFileName, WaterDepthBar.Value, WaterClarityBar.Value, "FP1");
                    _itemTag = "FP1";
                }
                else if (FP2 == null)
                {
                    FP2 = new FishingPin(NameOfFishingSpotBox.Text, ListOfFishTextBox.Text, _boatAccessability, _pictureFileName, WaterDepthBar.Value, WaterClarityBar.Value, "FP2");
                    _itemTag = "FP2";
                }
                else if (FP3 == null)
                {
                    FP3 = new FishingPin(NameOfFishingSpotBox.Text, ListOfFishTextBox.Text, _boatAccessability, _pictureFileName, WaterDepthBar.Value, WaterClarityBar.Value, "FP3");
                    _itemTag = "FP3";
                }
                else if (FP4 == null)
                {
                    FP4 = new FishingPin(NameOfFishingSpotBox.Text, ListOfFishTextBox.Text, _boatAccessability, _pictureFileName, WaterDepthBar.Value, WaterClarityBar.Value, "FP4");
                    _itemTag = "FP4";
                }
                else if (FP5 == null)
                {
                    FP5 = new FishingPin(NameOfFishingSpotBox.Text, ListOfFishTextBox.Text, _boatAccessability, _pictureFileName, WaterDepthBar.Value, WaterClarityBar.Value, "FP5");
                    _itemTag = "FP5";
                }
                else
                {
                    MessageBox.Show("There Are Five Fishing Pins on the Map already");
                    return;
                }
            }
            else { throw new Exception("There was atleast one empty field"); }

            ResetValues();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            UpLoadPictureDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            DialogResult result = UpLoadPictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _pictureFileName = UpLoadPictureDialog.FileName;
                MessageBox.Show("You selected " + _pictureFileName);

                DisplaySelectedPictureBox.Image = Image.FromFile(_pictureFileName);
            }
        }

        #endregion

        #region Methods

        public void ResetValues()
        {
            NameOfFishingSpotBox.Text = null;
            ListOfFishTextBox.Text = null;
            _yesOrNoBoxWasClicked = false;
            _pictureFileName = null;
            WaterClarityBar.Value = 0;
            WaterDepthBar.Value = 0;
            DisplaySelectedPictureBox.Image = null;
        }




        public void DetermineClass(string ClassName)
        {
            if(ClassName == "FP1")
            {
                FP1.DisplayPinInformation("FP1");
            }
            else if(ClassName == "FP2")
            {
               FP2.DisplayPinInformation("FP2");
            }
            else if (ClassName == "FP3")
            {
                FP3.DisplayPinInformation("FP3");
            }
            else if (ClassName == "FP4")
            {
               FP4.DisplayPinInformation("FP4");
            }
            else if (ClassName == "FP5")
            {
                FP5.DisplayPinInformation("FP5");
            }
            else
            {
                throw new Exception("Class Not Found");
            }

        }


        #endregion

    }
}
