using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class FishingPin : Adventurer
    {
        #region Variables
        string nameOfFishingSpot;
        string stringOfFish;
        bool boatAccess;
        string pictureFileName;
        int waterDepth;
        int waterClarity;
        #endregion


        //Construtctor
        public FishingPin(string NameOfFishingSpot, string StringOfFish, bool BoatAccess, string PictureFileName, int WaterDepth, int WaterClarity)
        {
            nameOfFishingSpot = NameOfFishingSpot;
            stringOfFish = StringOfFish;
            boatAccess = BoatAccess;
            pictureFileName = PictureFileName;
            waterDepth = WaterDepth;
            waterClarity = WaterClarity;
        }

    }
}
