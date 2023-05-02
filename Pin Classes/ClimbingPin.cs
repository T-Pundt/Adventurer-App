using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class ClimbingPin
    {
        #region Variables
        private string _nameOfClimbingRoute;
        private string _pictureFileName;
        private string _classname;
        private string _routeDifficulty;
        private string _typeOfRock;
        private int _routeDistance;
        private int _degreeOfRoute;
        #endregion

        #region Properties

        public int DegreeOfRoute
        {
            get { return _degreeOfRoute; }

            set
            {
                _degreeOfRoute = value;
            }
        }

        public int RouteDistance
        {
            get { return _routeDistance; }

            set
            {
                _routeDistance = value;
            }
        }


        public string TypeOfRock
        {
            get { return _typeOfRock; }

            set
            {
                if (value.Contains('='))
                {
                    throw new Exception("Name of hiking spot is not allowed to contain '='");
                }
                else
                {
                    _typeOfRock = value;
                }
            }
        }

        public string RouteDifficulty
        {
            get { return _routeDifficulty; }

            set
            {
                if (value.Contains('='))
                {
                    throw new Exception("Name of hiking spot is not allowed to contain '='");
                }
                else
                {
                    _routeDifficulty = value;
                }
            }
        }

        public string NameOfClimbingRoute
        {
            get { return _nameOfClimbingRoute; }

            set
            {
                if (value.Contains('#'))
                {
                    throw new Exception("Name of hiking spot is not allowed to contain '='");
                }
                else
                {
                    _nameOfClimbingRoute = value;
                }
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
        public ClimbingPin(string className, string pictureFileName, int routeDistance, int degreeOfRoute, string typeOfRock, string routeDifficulty, string nameOfClimbingRoute)
        {
            PictureFileName = pictureFileName;
            ClassName = className;
            RouteDistance = routeDistance;
            DegreeOfRoute = degreeOfRoute;
            TypeOfRock = typeOfRock;
            RouteDifficulty = routeDifficulty;
            NameOfClimbingRoute = nameOfClimbingRoute;
        }

        #endregion

        #region Methods
        public void DisplayPinInformation(string ClassName)
        {
          DisplayClimbingPinInformation displayclimbinginformation = new DisplayClimbingPinInformation();
          displayclimbinginformation.ClassName = ClassName;
          displayclimbinginformation.PictureFileName = PictureFileName;
          displayclimbinginformation.NameOfClimbingRoute = NameOfClimbingRoute;
          displayclimbinginformation.RouteDifficulty = RouteDifficulty;
          displayclimbinginformation.TypeOfRock = TypeOfRock;
          displayclimbinginformation.RouteDistance = RouteDistance;
          displayclimbinginformation.DegreeOfRoute = DegreeOfRoute;
          displayclimbinginformation.Show();
        }
        #endregion
    }
}
