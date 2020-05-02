using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_Framework
{
    interface IEvent
    {
        string Starttid { get; set; }
        string Sluttid { get; set; }
        Personal p { get; set; }
        ICollection<Alumn> EventAlumner { get; set; }
    }
}
