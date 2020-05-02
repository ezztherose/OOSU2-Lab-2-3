    using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IAnvändareRepository : IGenericRepository<Användare>
    {
        DateTime _godkännande { get; set;}
        void RegisterOnEvent();
    }
}
