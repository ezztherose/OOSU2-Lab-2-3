using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_Framework
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        void LäggTillAlumn(Alumn a);
        void CreateEvent(Event e, Personal p);
        List<Event> SearchEvent(string search);
        void RegistreraTillEvent(Alumn a, int id, Event e);
        List<Alumn> HämtaEventetsAlumner(Event e);
    }
}
