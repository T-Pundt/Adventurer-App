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
    public partial class SwimmingMessageBox : Form
    {
        #region Load In
        public SwimmingMessageBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables

        private string _pictureFileName;

        private string _itemTag;

        SwimmingPin SP1;
        SwimmingPin SP2;
        SwimmingPin SP3;
        SwimmingPin SP4;
        SwimmingPin SP5;

        #endregion

        #region Properties

        public string ItemTag
        {
            get { return _itemTag; }
        }

        #endregion

        #region Timer That Updates Values
        private void UpdateSwimmingMessageBoxTimer_Tick(object sender, EventArgs e)
        {
            SwimmingWaterDepthText.Text = SwimmingWaterDepthBar.Value.ToString();
            SwimmingwaterPolutionLevelText.Text = SwimmingWaterPolutionLevelBar.Value.ToString();
            SwimmingWaterClarityText.Text = SwimmingWaterClarityBar.Value.ToString();

        }



        #endregion

        #region Buttons
        private void SwimmingUploadPictureButton_Click(object sender, EventArgs e)
        {
         
             SwimmingUploadPictureDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            DialogResult result = SwimmingUploadPictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _pictureFileName = SwimmingUploadPictureDialog.FileName;
                MessageBox.Show("You selected " + _pictureFileName);

                SwimmingDisplaySelectedPictureBox.Image = Image.FromFile(_pictureFileName);
            }
        }

        private void SwimmingCreateSwimmingClassButton_Click(object sender, EventArgs e)
        {
            if (SwimmingWaterClarityBar.Value != 0 && SwimmingWaterDepthBar.Value != 0 && _pictureFileName != null && SwimmingNameOfSpotTextBox.Text != null && SwimmingWaterPolutionLevelBar.Value != 0)
            {
                if(SP1 == null) 
                {
                    SP1 = new SwimmingPin(SwimmingNameOfSpotTextBox.Text, SwimmingWaterPolutionLevelBar.Value, _pictureFileName, SwimmingWaterDepthBar.Value, SwimmingWaterClarityBar.Value, "SP1");
                    _itemTag = "SP1";
                }
                else if(SP2 == null) 
                {
                    SP2 = new SwimmingPin(SwimmingNameOfSpotTextBox.Text, SwimmingWaterPolutionLevelBar.Value, _pictureFileName, SwimmingWaterDepthBar.Value, SwimmingWaterClarityBar.Value, "SP2");
                    _itemTag = "SP2";
                }
                else if (SP3 == null)
                {
                    SP3 = new SwimmingPin(SwimmingNameOfSpotTextBox.Text, SwimmingWaterPolutionLevelBar.Value, _pictureFileName, SwimmingWaterDepthBar.Value, SwimmingWaterClarityBar.Value, "SP3");
                    _itemTag = "SP3";
                }
                else if (SP2 == null)
                {
                    SP4 = new SwimmingPin(SwimmingNameOfSpotTextBox.Text, SwimmingWaterPolutionLevelBar.Value, _pictureFileName, SwimmingWaterDepthBar.Value, SwimmingWaterClarityBar.Value, "SP4");
                    _itemTag = "SP4";
                }
                else if (SP2 == null)
                {
                    SP5 = new SwimmingPin(SwimmingNameOfSpotTextBox.Text, SwimmingWaterPolutionLevelBar.Value, _pictureFileName, SwimmingWaterDepthBar.Value, SwimmingWaterClarityBar.Value, "SP5");
                    _itemTag = "SP5";
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







        #endregion

        #region Methods

        public void ResetValues()
        {
            SwimmingNameOfSpotTextBox = null;
            SwimmingWaterPolutionLevelBar.Value = 0;           
            _pictureFileName = null;
            SwimmingWaterClarityBar.Value = 0;
            SwimmingWaterDepthBar.Value = 0;
            SwimmingDisplaySelectedPictureBox.Image = null;
        }




        public void DetermineClass(string ClassName)
        {
            if (ClassName == "SP1")
            {
                SP1.DisplayPinInformation("SP1");
            }
            else if (ClassName == "SP2")
            {
                SP2.DisplayPinInformation("SP2");
            }
            else if (ClassName == "SP3")
            {
                SP3.DisplayPinInformation("SP3");
            }
            else if (ClassName == "SP4")
            {
                SP4.DisplayPinInformation("SP4");
            }
            else if (ClassName == "SP5")
            {
                SP5.DisplayPinInformation("SP5");
            }
            else
            {
                throw new Exception("Class Not Found");
            }

        }


        #endregion
    }
}
