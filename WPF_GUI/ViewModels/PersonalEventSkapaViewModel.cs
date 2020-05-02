using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI.ViewModels
{
    public class PersonalEventSkapaViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalEventSkapaViewModel(Personal p)
        {
            Personal = p;
        }

        private string _name;
        private string _plats;
        private string _beskrivnig;
        private string _starttid;
        private string _sluttid;

        public string Sluttid
        {
            get { return _sluttid; }
            set { _sluttid = value; Changed(); }
        }

        public string Starttid
        {
            get { return _starttid; }
            set { _starttid = value; Changed(); }
        }

        public string Beskrivning
        {
            get { return _beskrivnig; }
            set { _beskrivnig = value; Changed(); }
        }

        public string Plats
        {
            get { return _plats; }
            set { _plats = value; Changed(); }
        }

        public string Namn
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalEventViewModel(Personal), null, null);
            TryClose();
        }

        public void btnCreate()
        {
            BusinessManager.AddEvent(new Event()
            {
                Namn = Namn,
                Plats = Plats,
                Beskrivning = Beskrivning,
                Starttid = Starttid,
                Sluttid = Sluttid,
                Datum = DateTime.Now,
                p = Personal
            });

            BusinessManager.uow.Complete();

            wm.ShowWindow(new PersonalEventViewModel(Personal), null, null);
            TryClose();
        }
    }
}
