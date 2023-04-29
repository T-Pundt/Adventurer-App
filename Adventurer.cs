using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace Final_Project
{
    public partial class Adventurer : Form
    {
        #region Variables
        FishingPin FP1;
        FishingPin FP2;
        FishingPin FP3;
        FishingPin FP4;
        FishingPin FP5;

        #endregion





        public Adventurer()
        {
            InitializeComponent();
        }

        private void Adventurer_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(44.0121, -92.4802);
            gmap.Zoom = 7;
            gmap.ShowCenter = true;
        }

        #region Timer For Cordinates Update
        private void UpdateCordinatesTimer_Tick(object sender, EventArgs e)
        {
            DisplayCordinate.Text = gmap.Position.ToString();
        }
        #endregion

        private void AddFishingPinButton_Click(object sender, EventArgs e)
        {
            FishingMessageBox fishingmessagebox = new FishingMessageBox();
            fishingmessagebox.Show();
            fishingmessagebox.Visible = false;
            if (fishingmessagebox.ShowDialog() == DialogResult.OK )
            {
                //send this method to Fishing Message Box

                string _stringOfFish = fishingmessagebox.StringOfFish;
                bool _boataccess = fishingmessagebox.BoatAccessability;
                string _fileName = fishingmessagebox.PictureFileName;
                int _waterDepth = fishingmessagebox.WaterDepth;
                int _waterClarity = fishingmessagebox.WaterClarity;
                string _nameOfFishingSpot = fishingmessagebox.NameOfFishingSpot;

                if(FP1 == null)
                {
                    FP1 = new FishingPin(_nameOfFishingSpot, _stringOfFish, _boataccess, _fileName, _waterDepth, _waterClarity);
                }
                else if(FP2 == null) 
                {
                    FP2 = new FishingPin(_nameOfFishingSpot, _stringOfFish, _boataccess, _fileName, _waterDepth, _waterClarity );
                }
                else if (FP3 == null)
                {
                    FP3 = new FishingPin(_nameOfFishingSpot, _stringOfFish, _boataccess, _fileName, _waterDepth, _waterClarity);
                }
                else if (FP4 == null)
                {
                    FP4 = new FishingPin(_nameOfFishingSpot, _stringOfFish, _boataccess, _fileName, _waterDepth, _waterClarity);
                }
                else if (FP5 == null)
                {
                    FP5 = new FishingPin(_nameOfFishingSpot, _stringOfFish, _boataccess, _fileName, _waterDepth, _waterClarity);
                }
                else
                {
                    MessageBox.Show("There Are Five Fishing Pins on the Map already");
                    return;
                }


                //To here 

                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        gmap.Position,
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);



            }
        }






    }
}
