using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_Framework
{
   public interface IAktiviteter
      {
        string Beskrivning { get; set; }
        int ID { get; set; }
        DateTime Datum { get; set; }
        string Plats { get; set; }
        string Namn { get; set; }
      }
}
