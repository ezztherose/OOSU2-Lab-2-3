using BusinessEnteties.models;
using BusinessEntities_Framework;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_Framework
{
    public interface IJobbRepository : IGenericRepository<Jobb>
    {
        List<Jobb> SearchJob(string j);

        List<Alumn> HämtaJobbAlumner(Jobb j);
    }
}
