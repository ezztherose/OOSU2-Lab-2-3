using BusinessEntities_Framework;
using BusinessEntities_Framework.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEnteties
{
    public interface IAlumn
    {
        string Utbildning { get; set; }
        string Arbete { get; set; }
        string Utgångsår { get; set; }
        string Intressen { get; set; }

        ICollection<Event> events { get; set; }
        ICollection<Jobb> JobbAlumn { get; set; }
        ICollection<Mailing> mailings { get; set; }
    }
}
