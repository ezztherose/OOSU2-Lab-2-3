using BusinessEntities_Framework;
using BusinessEntities_Framework.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessEnteties.models
{
    public class Alumn : IAnvändare, IAlumn, INotifyPropertyChanged
    {
      
        public DateTime Godkännande { get; set; }
        public string Password { get; set; }
        public string AnvändarNamn { get; set; }
        public string Namn { get; set; }
        public int ID { get; set; }

        public string Utbildning { get; set; }
        public string Arbete { get; set; }
        public string Utgångsår { get; set; }
        public string Intressen { get; set; }

        public ICollection<Event> events { get; set; }
        public ICollection<Jobb> JobbAlumn { get; set; }
        public ICollection<Mailing> mailings { get; set; }

        public Alumn()
        {
            events = new List<Event>();
            JobbAlumn = new List<Jobb>();
            mailings = new List<Mailing>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
