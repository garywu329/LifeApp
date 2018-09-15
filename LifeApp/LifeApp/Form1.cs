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

namespace LifeApp
{
    public sealed partial class Form1 : Form
    {
        //variables for long/lat
        private int x;
        private int y;
        //Singleton implementation
        private static Form1 aForm = null;

        public static Form1 Instance()
        {
            if(aForm == null)
            {
                aForm = new Form1();
            }
            return aForm;
        }

        //Form contructor and implementation below
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Map.MapProvider = GoogleMapProvider.Instance;

        }

        private void popup_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void retrieve_button_Click(object sender, EventArgs e)
        {

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
                x = e.X;
                y = e.Y;

                popup_panel.Location = new Point(x, y);
                popup_panel.Visible = true;
            }

            if(e.Button == MouseButtons.Right)
            {
                popup_panel.Visible = false;
            }
        }
    }
}
