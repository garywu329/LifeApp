using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace LifeApp
{
    public class Controller
    {
        //XML stuff
        readonly XNamespace lle;
        XDocument document;
        IEnumerable<XElement> events;
        //Classes that the controller controls
        List<Event> EventList = new List<Event>();
        AddForm addform;
        Map_Form maps;
        //Variables to be used to send information from each form
        private float lat, lng;
        private string filepath;

        public float Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
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
            }
        }

        public string Filepath
        {
            get
            {
                return filepath;
            }
            set
            {
                filepath = value;
            }
        }
        
        public Controller(Map_Form maps)
        {
            filepath = "events.xml";
            document = XDocument.Load(filepath);
            lle = XNamespace.Get("http://www.xyz.org/lifelogevents");
            events = document.Descendants(lle + "Event");
            addform = new AddForm(this);
            this.maps = maps;
            FirstLoad();
        }

        public AddForm GetAddForm()
        {
            return addform;
        }

        public void AddForm()
        {
            addform.Show();
            addform.Lat = lat;
            addform.Lng = lng;

            Event lastevent = new Event();
            lastevent = EventList.Last();

            //Processing the last ID number
            int eventnumb = 0, indexof = 0;
            string eventid, controlstring;

            eventid = lastevent.Eventid;
            if(eventid != null)
            {
                indexof = eventid.LastIndexOf('D');
                controlstring = eventid.Substring(indexof + 1);
                eventnumb = Int32.Parse(controlstring);
            }

            eventnumb++;

            addform.Id = eventnumb;
        }

        public void ButtonClicked()
        {
            Event events = new Event();
            events = addform.ReturnEvent();
            AddEvent(events);
            addform.Hide();
            maps.AddMarker(events);
            AppendToXml(events);
        }

        private void AppendToXml(Event events)
        {
            XElement xEle = XElement.Load(filepath);
            xEle.Add(new XElement("Event",
                new XElement("eventid", events.Eventid),
                new XElement(events.Source,
                    new XElement("text", events.Text),
                    new XElement("location",
                            new XElement("lat", events.Latitude),
                            new XElement("long", events.Longitude),
                    new XElement("datetimestamp", events.Datetimestamp)))));
            xEle.Save(filepath);

        }

        public Event FindEvent(string uniqueid)
        {
            bool eventfound = false;
            int indexoffound = 0;
            for(int i = 0; i < GetLength(); i++)
            {
                if(uniqueid == EventList[i].Eventid)
                {
                    eventfound = true;
                    indexoffound = i;
                }
            }

            if(eventfound == false)
            {
                Console.WriteLine("No event with this ID found");
                return (null);
            }
            else
            {
                return (EventList[indexoffound]);
            }
        }

        public void PopBack()
        {
            Event events = new Event();
            EventList.Add(events);
        }

        public void AddEvent(Event events)
        {
            EventList.Add(events);
        }

        private int GetLength()
        {
            int length;
            length = EventList.Count;

            return length;
        }

        public void RetrieveEvent(Event events)
        {
            EventForm eventform = new EventForm(events);
        }

        private void FirstLoad()
        {
            float longitude, latitude;
            string ID, descriptiontext, datetimestamp, filepath;
            foreach (XElement Events in events)
            {
                Event iteevent = new Event();
                foreach(XElement ele in Events.Descendants())
                {
                    if (ele.Name.LocalName == "eventid")
                    {
                        ID = ele.Value;
                        Console.WriteLine(ID);
                        iteevent.Eventid = ID;
                    }
                    if (ele.Name.LocalName == "tweet" || ele.Name.LocalName == "facebook-status-update" || ele.Name.LocalName == "photo" || ele.Name.LocalName == "video")
                    {
                        foreach (XElement text in ele.Elements(lle + "text"))
                        {
                            descriptiontext = text.Value;
                            iteevent.Text = descriptiontext;
                        }

                        foreach (XElement location in ele.Elements(lle + "location"))
                        {
                            foreach (XElement Lat in location.Elements(lle + "lat"))
                            {
                                try
                                {
                                    latitude = Single.Parse(Lat.Value);
                                    iteevent.Latitude = latitude;
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            foreach (XElement Long in location.Elements(lle + "long"))
                            {
                                try
                                {
                                    longitude = Single.Parse(Long.Value);
                                    iteevent.Longitude = longitude;
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                        }

                        foreach (XElement datetime in ele.Elements(lle + "datetimestamp"))
                        {
                            datetimestamp = datetime.Value;
                            iteevent.Datetimestamp = datetimestamp;
                        }

                        foreach (XElement filelocation in ele.Elements(lle + "filepath"))
                        {

                            filepath = filelocation.Value;
                            if (filelocation.Name.LocalName == "photo")
                            {
                                iteevent.SetPicturePath(filepath);
                            }

                            if (filelocation.Name.LocalName == "video")
                            {
                                iteevent.SetVideoPath(filepath);
                            }
                        }

                        foreach (XElement starttime in ele.Elements(lle + "start-time"))
                        {
                            foreach (XElement datetime in starttime.Elements(lle + "datetimestamp"))
                            {
                                datetimestamp = datetime.Value;
                                iteevent.Datetimestamp = datetimestamp;
                            }
                        }

                        foreach (XElement endtime in ele.Elements(lle + "end-time"))
                        {
                            foreach (XElement datetime in endtime.Elements(lle + "datetimestamp"))
                            {
                                datetimestamp = datetime.Value;
                                iteevent.Datetimestamp = datetimestamp;
                            }
                        }

                    }
                }
                AddEvent(iteevent);
                maps.AddMarker(iteevent);
            }

        }
    }
}
