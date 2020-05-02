using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_GUI.ViewModels
{
    public class PersonalEventViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }
        //public IEnumerable<Event> EventLista { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalEventViewModel(Personal p)
        {
            Personal = p;
            EventLista = new List<Event>(BusinessManager.GetAllEvents());
        }

        private Event _selectedEvent;
        private IEnumerable<Event> _eventLista;

        public IEnumerable<Event> EventLista
        {
            get { return _eventLista; }
            set { _eventLista = value; Changed(); }
        }


        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set { _selectedEvent = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalProfilViewModel(Personal), null, null);
            TryClose();
        }

        public void btnSkapa()
        {
            wm.ShowWindow(new PersonalEventSkapaViewModel(Personal), null, null);
            TryClose();
        }

        public void btnSeeAlumns()
        {
            if (SelectedEvent != null)
            {
                wm.ShowWindow(new PersonalEventDeltagareViewModel(Personal, SelectedEvent), null, null);
                TryClose();
            }
        }

        public void btnDelete()
        {
            if (SelectedEvent != null)
            {
                BusinessManager.RemoveEvent(SelectedEvent);
                BusinessManager.uow.Complete();
                wm.ShowWindow(new PersonalEventViewModel(Personal), null, null);
                TryClose();
            }
            else
            {
                MessageBox.Show("No list has med selected");
            }
        }

    }
}
