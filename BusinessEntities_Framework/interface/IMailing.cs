using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_Framework
{
    public interface IMailing
    {
        int ID { get; set; }
        string Namn { get; set; }
        string Message { get; set; }
        ICollection<Alumn> UtskicksLista { get; set; }
    }
}
