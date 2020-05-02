using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI.ViewModels
{
    public class AdminTaBortPersonalViewModel : ViewModelBase
    {
        public Administratör Administratör { get; set; }

        IWindowManager wm = new WindowManager();

        public AdminTaBortPersonalViewModel(Administratör a)
        {
            Administratör = a;
            TillagdPersonal = new List<Personal>(BusinessManager.GetAllPersonal());
        }

        private ICollection<Personal> _personal;
        private Personal _selectedPersonal;

        public Personal SelectedPersonal
        {
            get { return _selectedPersonal; }
            set { _selectedPersonal = value; Changed(); }
        }

        public ICollection<Personal> TillagdPersonal
        {
            get { return _personal; }
            set { _personal = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new AdminProfilViewModel(Administratör), null, null);
            TryClose();
        }

        public void btnDelete()
        {
            if (SelectedPersonal != null)
            {
                BusinessManager.RemovePersonal(SelectedPersonal);
                BusinessManager.uow.Complete();
            }
        }
    }
}
