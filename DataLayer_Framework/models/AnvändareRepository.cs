using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer.models
{
    public class AnvändareRepository : GenericRepository<Användare>, IAnvändareRepository
    {
        public AnvändareRepository(DatabaseContext context) : base(context)
        {

        }

        Användare IGenericRepository<Användare>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Användare> IGenericRepository<Användare>.GetAll()
        {
            throw new NotImplementedException();
        }

        public void RegisterOnEvent()
        {
            throw new NotImplementedException();
        }

        public void LoggaIn()
        {
            throw new NotImplementedException();
        }


        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public DateTime _godkännande { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
