using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_WPF.models
{
    class EventModel
    {
        public string Beskrivning { get; set; }
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string Plats { get; set; }
        public string Starttid { get; set; }
        public string Sluttid { get; set; }
        public string Namn { get; set; }

        public List<AlumnModel> EventAlumner = new List<AlumnModel>();
        public PersonalModel p { get; set; }

        public EventModel()
        {

        }
    }
}
