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
    public interface IMailingRepository : IGenericRepository<Mailing>
    {
        List<Alumn> SökLista(string value);
        List<Alumn> HämtaTillgängligaAlumner(Mailing m);
    }
}
