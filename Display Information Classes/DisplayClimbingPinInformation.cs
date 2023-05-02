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
    public partial class DisplayClimbingPinInformation : Form
    {
        #region Load In
        public DisplayClimbingPinInformation()
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

        public int DegreeOfRoute { get; set; }
        public int RouteDistance { get; set; }
        public string TypeOfRock { get; set; }
        public string RouteDifficulty { get; set; }
        public string NameOfClimbingRoute { get; set; }
        public string PictureFileName { get; set; }
        public string ClassName { get; set; }


        #endregion

        #region Update Climbing Information
        private void DisplayClimbingInformationUpdateValues_Tick(object sender, EventArgs e)
        {
            ClimbingPictureOfArea.Image = Image.FromFile(PictureFileName);
            DisplayNameOfClimbingRouteText.Text = NameOfClimbingRoute;
            DisplayClimbingTypeOfRock.Text = TypeOfRock;
            DisplayClimbingDegreeOfRouteText.Text = DegreeOfRoute.ToString();
            DisplayRouteDifficultyText.Text = RouteDifficulty.ToString();
            DisplayClimbingDistanceText.Text = RouteDistance.ToString();
        }
        #endregion

    }
}
