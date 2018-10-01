using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeApp
{
    public class Event
    {
        private float longitude, latitude;
        private string eventid, text, datetimestamp;
        private string[] filepathname = new string[2];

        public Event()
        {
            Console.WriteLine("Creating new Event");
        }

        public Event(float longitude, float latitude, string eventid, string text, string datetimestamp, string filepathname)
        {
            int total;
            this.longitude = longitude;
            this.latitude = latitude;
            this.eventid = eventid;
            this.text = text;
            this.datetimestamp = datetimestamp;
            total = filepathname.Count();
            this.filepathname[total] = filepathname;
        }

        public Event(float longitude, float latitude, string eventid, string text, string datetimestamp, string picturepathname, string videopathname)
        {
            int total;
            this.longitude = longitude;
            this.latitude = latitude;
            this.eventid = eventid;
            this.text = text;
            this.datetimestamp = datetimestamp;
            total = filepathname.Count();
            this.filepathname[total] = picturepathname;
            total = filepathname.Count();
            this.filepathname[total] = videopathname;
        }

        public float Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public float Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
            }
        }

        public string Eventid
        {
            get
            {
                return eventid;
            }

            set
            {
                eventid = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public string Datetimestamp
        {
            get
            {
                return datetimestamp;
            }

            set
            {
                datetimestamp = value;
            }
        }

        public void SetPicturePath(string picpath)
        {
            filepathname[0] = picpath;
        }

        public string GetPicturePath()
        {
            return filepathname[0];
        }

        public void SetVideoPath(string vidpath)
        {
            filepathname[1] = vidpath;
        }

        public string GetVideoPath()
        {
            return filepathname[1];
        }
    }
}
