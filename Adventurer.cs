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
using JetBrains.Annotations;

namespace Final_Project
{
    public partial class Adventurer : Form
    {

        #region MessageBoxVariables
        FishingMessageBox fishingmessagebox = new FishingMessageBox();
        #endregion



        #region Initial Load In

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
        #endregion


        #region Timer For Cordinates Update
        private void UpdateCordinatesTimer_Tick(object sender, EventArgs e)
        {
            DisplayCordinate.Text = gmap.Position.ToString();
        }
        #endregion


        #region Buttons
        private void AddFishingPinButton_Click(object sender, EventArgs e)
        {
            
            fishingmessagebox.Show();
            fishingmessagebox.Visible = false;


            if (fishingmessagebox.ShowDialog() == DialogResult.OK)
            {

                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker =
                  new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                      gmap.Position,
                     GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);


                string tag = fishingmessagebox.ItemTag;
                marker.Tag = tag;
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
            }
        }

        #endregion


        //Work On implementation next
        private void gmap_OnMarkerClick_1(GMapMarker item, MouseEventArgs e)
        {
            MessageBox.Show("The class was clicked", (string)item.Tag);

            //if first char of tag starts with F go this branch
            fishingmessagebox.DisplayPinInformation((string)item.Tag);

        }
    }






}

