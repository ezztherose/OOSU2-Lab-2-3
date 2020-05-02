using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IAdministratörRepository : IGenericRepository<Administratör>
    { 
        Administratör LoggIn(string användarnamn, string password);
    }
}
