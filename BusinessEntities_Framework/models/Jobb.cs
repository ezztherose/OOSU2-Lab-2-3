using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_Framework
{
    public class Jobb : IAktiviteter, IJobb
    {
        public string Beskrivning { get; set; }
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string Plats { get; set; }
        public string Titel {get; set;}
        public string Arbetsgivare { get; set; }
        public string Namn { get; set; }

        public string Anställningsfrom { get; set; }
        public string Sysselsättningsgrad { get; set; }
        public DateTime SistaAnsökningsdag { get; set; }

        public ICollection<Alumn> AlumnJobb { get; set; }
        public Personal personal { get; set; }

        public Jobb()
        {
            AlumnJobb = new List<Alumn>();
        }
    }
}
