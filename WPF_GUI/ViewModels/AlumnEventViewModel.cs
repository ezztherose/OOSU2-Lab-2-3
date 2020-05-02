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
    public class AlumnEventViewModel : ViewModelBase
    {
        public Alumn Alumn { get; set; }
        //public ICollection<Event> EventList { get; set; }

        IWindowManager wm = new WindowManager();

        public AlumnEventViewModel(Alumn a)
        {
            Alumn = a;
           EventList = new List<Event>(BusinessManager.GetAllEvents());
        }

        private IEnumerable<Event> _eventLista;
        private Event _selectedEvent;

        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set { _selectedEvent = value; Changed(); }
        }

        public IEnumerable<Event> EventList
        {
            get { return _eventLista; }
            set { _eventLista = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
            TryClose();
        }

        public void btnRegistrera()
        {
            if (SelectedEvent != null)
            {
                BusinessManager.RegistreraPåEvent(Alumn.ID, SelectedEvent);
                BusinessManager.uow.Complete();

                wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
                TryClose();
            }
        }
    }
}
