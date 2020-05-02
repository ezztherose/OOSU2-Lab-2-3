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
    public class PersonalEventDeltagareViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }
        public Event Event { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalEventDeltagareViewModel(Personal p, Event ev)
        {
            Personal = p;
            Event = ev;
            EventDeltagare = new List<Alumn>(BusinessManager.HämtaEventetsAlumner(Event));
        }

        private ICollection<Alumn> _eventDeltagare;
        private Alumn _selectedAlumn;

        public Alumn SelectedAlumn
        {
            get { return _selectedAlumn; }
            set { _selectedAlumn = value; Changed(); }
        }

        public ICollection<Alumn> EventDeltagare
        {
            get { return _eventDeltagare; }
            set { _eventDeltagare = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalEventViewModel(Personal), null, null);
            TryClose();
        }
    }
}
