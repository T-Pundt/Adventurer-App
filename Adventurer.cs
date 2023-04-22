using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace Final_Project
{
    public partial class Adventurer : Form
    {
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
            gmap.Position = new GMap.NET.PointLatLng(44.0121, -92.4802);
            gmap.Zoom = 7;
            gmap.ShowCenter = true;
        }

        private void UpdateCordinatesTimer_Tick(object sender, EventArgs e)
        {
            DisplayCordinate.Text = gmap.Position.ToString();
        }


    }
}
