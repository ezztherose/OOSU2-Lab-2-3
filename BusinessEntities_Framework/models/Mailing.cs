using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_Framework.models
{
    public class Mailing : IMailing
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public string Message { get; set; }
        public ICollection<Alumn> UtskicksLista { get; set; }

        public Mailing()
        {
            UtskicksLista = new List<Alumn>();
        }
    }
}
