using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeApp
{
    public partial class EventForm : Form
    {
        public EventForm(Event events)
        {
            InitializeComponent();
            EventID.Text = events.Eventid;
            Longitude.Text = events.Longitude.ToString();
            Latitude.Text = events.Latitude.ToString();

            if(events.GetPicturePath() != null)
            {
                Picture.Image = Image.FromFile(events.GetPicturePath());
            }
            if(events.GetVideoPath() != null)
            {
                Video.URL = events.GetVideoPath();
            }
            Description.Text = events.Text;
            Description.ReadOnly = true;
            this.Show();
        }

        private void CloseEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void Latitude_Click(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
