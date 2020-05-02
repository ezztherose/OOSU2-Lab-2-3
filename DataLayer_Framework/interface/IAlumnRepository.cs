using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IAlumnRepository : IGenericRepository<Alumn>
    {
        void RegistreraTillEvent(Alumn alumn, int id, Event e);
        Alumn LoggIn(string användarnamn, string password);
        List<Alumn> SearchAlumn(string value);
    }
}
