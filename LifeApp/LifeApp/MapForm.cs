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
using GMap.NET.WindowsForms.Markers;

namespace LifeApp
{
    public sealed partial class Map_Form : Form
    {
        //variables for long/lat
        private float x;
        private float y;
        //Singleton implementation
        private static Map_Form aForm = null;
        //GMap stuff
        GMapOverlay markersoverlay = new GMapOverlay("markers");
        List<GMapMarker> markers = new List<GMapMarker>();

        Controller ctrl;


        public static Map_Form Instance()
        {
            if(aForm == null)
            {
                aForm = new Map_Form();
            }
            return aForm;
        }

        //Form contructor and implementation below
        public Map_Form()
        {
            InitializeComponent();
            popup_panel.Visible = false;
            ctrl = new Controller(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Map.MapProvider = GoogleMapProvider.Instance;
            Map.ShowCenter = false;
        }

        private void popup_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            popup_panel.Visible = false;

            ctrl.Lat = x;
            ctrl.Lng = y;
            ctrl.AddForm();
        }

        public void AddMarker(float lat, float lng)
        {
            GMarkerGoogle addmarker = new GMarkerGoogle(
                new PointLatLng(lat, lng),
                GMarkerGoogleType.blue_pushpin);
            markersoverlay.Markers.Add(addmarker);
            Map.Overlays.Add(markersoverlay);
            markers.Add(addmarker);
        }

        private void retrieve_button_Click(object sender, EventArgs e)
        {
            popup_panel.Visible = false;
            var pi = Math.PI;
            var R = 6371; //Radius of earth
           // var distance = [];
            var closest = -1;

            //for(int i = 0; i < markers.)
        }

        private void Map_Load(object sender, EventArgs e)
        {
            Map.SetPositionByKeywords("Perth, Australia");
            Map.Dock = DockStyle.Fill;
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //Gets lat/long for the map itself
                x = (float)Map.FromLocalToLatLng(e.X, e.Y).Lat;
                y = (float)Map.FromLocalToLatLng(e.X, e.Y).Lng;

                //Gets lat/long for the "camera"
                int lat, lng;
                lat = e.X;
                lng = e.Y;
                
                popup_panel.Location = new Point(lat, lng);
                if (popup_panel.Visible == false)
                {
                    popup_panel.Visible = true;
                }
                else
                {
                    popup_panel.Visible = false;
                }
            }

            if(e.Button == MouseButtons.Right)
            {
                //Gets lat/long for the map itself
                x = (float)Map.FromLocalToLatLng(e.X, e.Y).Lat;
                y = (float)Map.FromLocalToLatLng(e.X, e.Y).Lng;

                //Gets lat/long for the "camera"
                int lat, lng;
                lat = e.X;
                lng = e.Y;
                popup_panel.Visible = false;
            }
        }

        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                AddForm form = new AddForm(ctrl);
            }
        }
    }
}
