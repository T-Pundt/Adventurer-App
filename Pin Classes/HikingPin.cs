using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class HikingPin
    {
        #region Variables
        private string _nameOfHikingSpot;
        private string _pictureFileName;
        private int _bugLevel;
        private int _hikeDifficulty;
        private int _hikeDistance;
        private int _numberOfOverlooks;
        private string _classname;
        #endregion

        #region Properties

        public int BugLevel
        {
            get { return _bugLevel; }

            set
            {
                _bugLevel = value;
            }
        }

        public int HikeDifficulty
        {
            get { return _hikeDifficulty; }

            set
            {
                _hikeDifficulty = value;
            }
        }

        public int HikeDistance
        {
            get { return _hikeDistance; }

            set
            {
                _hikeDistance = value;
            }
        }


        public int NumberOfOverLooks
        {
            get { return _numberOfOverlooks; }

            set
            {
                _numberOfOverlooks = value;
            }
        }

        public string ClassName
        {
            get { return _classname; }

            set
            {
                _classname = value;
            }
        }

        public string NameOfHikingSpot
        {
            get { return _nameOfHikingSpot; }

            set
            {
                if (value.Contains('='))
                {
                    throw new Exception("Name of hiking spot is not allowed to contain '='");
                }
                else
                {
                    _nameOfHikingSpot = value;
                }
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



        #endregion

        #region Constructor
        public HikingPin(string nameOfHikingSpot, int bugLevel, int hikeDifficulty, int hikeDistance, int numberOfOverLooks, string pictureFileName, string className)
        {
            NameOfHikingSpot = nameOfHikingSpot;
            PictureFileName = pictureFileName;
            ClassName = className;
            BugLevel = bugLevel;
            HikeDifficulty = hikeDifficulty;
            HikeDistance = hikeDistance;
            NumberOfOverLooks = numberOfOverLooks;
        }

        #endregion

        #region Methods
        public void DisplayPinInformation(string ClassName)
        {
            DisplayHikingPinInformation displayhikinginformation = new DisplayHikingPinInformation();
            displayhikinginformation.ClassName = ClassName;
            displayhikinginformation.PictureFileName = PictureFileName;
            displayhikinginformation.BugLevel = BugLevel;
            displayhikinginformation.HikeDifficulty = HikeDifficulty;
            displayhikinginformation.HikeDistance = HikeDistance;
            displayhikinginformation.NumberOfOverlooks = NumberOfOverLooks;
            displayhikinginformation.NameOfHikingSpot = NameOfHikingSpot;
            displayhikinginformation.Show();
        }
        #endregion
    }
}
