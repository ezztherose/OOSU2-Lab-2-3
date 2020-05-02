using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessEntities_Framework.models
{
    public class Event : IAktiviteter, IEvent
    {
        public string Beskrivning { get; set; }
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string Plats { get; set; }
        public string Namn { get; set; }

        public string Starttid { get; set; }
        public string Sluttid { get; set; }
        public Personal p { get; set; }
        public ICollection<Alumn> EventAlumner { get; set; } 
        
        public Event()
        {
            EventAlumner = new List<Alumn>();

        }
    }
}
