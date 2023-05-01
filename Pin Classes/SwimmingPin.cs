using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SwimmingPin
    {
        #region Variables
        private string _nameOfSwimmingSpot;
        private string _pictureFileName;
        private int _waterDepth;
        private int _waterClarity;
        private int _polutionLevel;
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

        public string NameOfSwimmingSpot
        {
            get { return _nameOfSwimmingSpot; }

            set
            {
                if (value.Contains('#'))
                {
                    throw new Exception("Name of swimming spot is not allowed to contain '#'");
                }
                else
                {
                    _nameOfSwimmingSpot = value;
                }
            }
        }

        public int PolutionLevel
        {
            get { return _polutionLevel; }

            set
            {
                _polutionLevel = value;
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

        public string PictureFileName
        {
            get { return _pictureFileName; }

            set
            {
                _pictureFileName = value;
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
        public SwimmingPin(string nameOfSwimmingSpot, int polutionLevel, string pictureFileName, int waterDepth, int waterClarity, string className)
        {
            NameOfSwimmingSpot = nameOfSwimmingSpot;
            PolutionLevel = polutionLevel;
            PictureFileName = pictureFileName;
            WaterDepth = waterDepth;
            WaterClarity = waterClarity;
            ClassName = className;
        }

        #endregion

        #region Methods
        public void DisplayPinInformation(string ClassName)
        {
        

        }
        #endregion



    }
}
