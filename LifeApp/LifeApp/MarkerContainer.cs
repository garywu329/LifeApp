using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
//Wrapper object for the MarkerContainer, used with ID to get the ID of each event.
namespace LifeApp
{
    class MarkerContainer : GMarkerGoogle
    { 
        string id;

        public MarkerContainer(PointLatLng p, GMarkerGoogleType type, string id) : base(p, type)
        {
            this.id = id;
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

    }
}
