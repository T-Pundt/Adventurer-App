using JetBrains.Annotations;
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
    public partial class FishingMessageBox : Form
    {

        #region Properties
        private bool _boatAccessability = false;

        private bool _yesOrNoBoxWasClicked = false;

        private string _pictureFileName;

        public string StringOfFish
        {
            get { return ListOfFishTextBox.Text; }
        }

        public bool BoatAccessability
        {
            get { return _boatAccessability;}
        }

        public string PictureFileName
        {
            get { return _pictureFileName; }
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        #endregion

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
    }
}
