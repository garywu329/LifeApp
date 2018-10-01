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
    public partial class AddForm : Form
    {
        private float lat;
        private float lng;
        private string date;
        private string time;
        private string videopath;
        private string picturepath;
        private int id;
        private bool yesno = false;
        Controller control;
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                EventID.Text = "ID" + id.ToString();
            }
        }

        public float Lat
        {
            get
            {
                return lat;
            }

            set
            {
                lat = value;
                Latitude.Text = lat.ToString();
            }
        }

        public float Lng
        {
            get
            {
                return lng;
            }

            set
            {
                lng = value;
                Longitude.Text = lng.ToString();
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public string Videopath
        {
            get
            {
                return videopath;
            }

            set
            {
                videopath = value;
            }
        }

        public string Picturepath
        {
            get
            {
                return picturepath;
            }

            set
            {
                picturepath = value;
            }
        }

        public AddForm(Controller control)
        {
            InitializeComponent();
            datestamp.Value.Date.ToString(date);
            timestamp = new DateTimePicker();
            timestamp.Format = DateTimePickerFormat.Time;
            timestamp.ShowUpDown = true;
            timestamp.Value.ToString(time);
            this.control = control;
            
        }


        override protected void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Event_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Long_Label_Click(object sender, EventArgs e)
        {

        }

        private void Add_Event_Button_Click(object sender, EventArgs e)
        {
            control.ButtonClicked();
            this.Hide();
        }

        public Event ReturnEvent()
        {
            Event events = new Event();

            if(!string.IsNullOrWhiteSpace(Description_Text_Box.Text))
            {
                events.Text = Description_Text_Box.Text;
            }
            if(!string.IsNullOrWhiteSpace(Picture_filepath.Text))
            {
                events.SetPicturePath(picturepath);
            }
            if(!string.IsNullOrWhiteSpace(Video_filepath.Text))
            {
                events.SetVideoPath(videopath);
            }
            events.Datetimestamp = date + " " + time;

            events.Eventid = EventID.Text;

            events.Latitude = lat;

            events.Longitude = lat;

            return events;
        }


        private void Latitude_Click(object sender, EventArgs e)
        {

        }

        private void Longitude_Click(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {
           // Description.Text;
        }

        private void Description_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventID_Click(object sender, EventArgs e)
        {

        }

        private void datetimestamp_TextChanged(object sender, EventArgs e)
        {

        }

        private void datestamp_ValueChanged(object sender, EventArgs e)
        {
            datestamp.Value.Date.ToString(date);
        }

        private void timestamp_ValueChanged(object sender, EventArgs e)
        {
            timestamp = new DateTimePicker();
            timestamp.Format = DateTimePickerFormat.Time;
            timestamp.ShowUpDown = true;
            timestamp.Value.ToString(time);
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void Picture_filepath_label_Click_1(object sender, EventArgs e)
        {

        }

        private void Video_filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Picture_filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Video_Enter(object sender, EventArgs e)
        {

        }
    }
}
