using System;
using BusinessEnteties.models;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
   public interface IPersonalRepository : IGenericRepository<Personal>
   {
        Personal LoggIn(string användarnamn, string password);
   }
}
