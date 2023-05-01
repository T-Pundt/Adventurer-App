using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    internal class FishingPin
    {
        #region Variables
        private string _nameOfFishingSpot;
        private string _stringOfFish;
        private bool _boatAccess;
        private string _pictureFileName;
        private int _waterDepth;
        private int _waterClarity;
        private string _classname;
        #endregion

        #region Properties

        public string ClassName
        {
            get { return _classname; }

            set
            {
                _classname = value;
            }
        }

        public string NameOfFishingSpot
        {
            get { return _nameOfFishingSpot; }

            set
            {
                if(value.Contains('#'))
                {
                    throw new Exception("Name of fishing spot is not allowed to contain '#'");
                }
                else
                {
                    _nameOfFishingSpot = value;
                }
            }
        }

        public string StringOfFish
        {
            get { return _stringOfFish; }

            set
            {
                if (value.Contains('#'))
                {
                    throw new Exception("Fish in the area is not allowed to contain '#'");
                }
                else
                {
                    _stringOfFish = value;
                }
            }
        }

        public bool BoatAccess
        {
            get { return _boatAccess; }

            set
            {
              _boatAccess = value;
            }
        }

        public string PictureFileName
        {
            get { return _pictureFileName; }

            set
            {
                _pictureFileName = value;
            }
        }

        public int WaterDepth
        {
            get { return _waterDepth; }

            set
            {
                _waterDepth = value;
            }
        }

        public int WaterClarity
        {
            get { return _waterClarity; }

            set
            {
                _waterClarity = value;
            }
        }


        #endregion

        #region Constructor
        public FishingPin(string nameOfFishingSpot, string stringOfFish, bool boatAccess, string pictureFileName, int waterDepth, int waterClarity, string className)
        {
            NameOfFishingSpot = nameOfFishingSpot;
            StringOfFish = stringOfFish;
            BoatAccess = boatAccess;
            PictureFileName = pictureFileName;
            WaterDepth = waterDepth;
            WaterClarity = waterClarity;
            ClassName = className;
        }

        #endregion

        #region Methods
        public void DisplayPinInformation(string ClassName)
        {
            DisplayFishingInformationForm displayFishingInformation = new DisplayFishingInformationForm();
            displayFishingInformation.WaterClarity = WaterClarity;
            displayFishingInformation.WaterDepth = WaterDepth;
            displayFishingInformation.StringOfFish = StringOfFish;
            displayFishingInformation.NameOfFishingSpot = NameOfFishingSpot;
            displayFishingInformation.BoatAccess = BoatAccess;
            displayFishingInformation.PictureFileName = PictureFileName;
            displayFishingInformation.ClassName = ClassName;
            displayFishingInformation.Show();

        }
        #endregion

    }
}
