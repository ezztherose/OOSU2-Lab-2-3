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
    class MailingSkapaViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }

        private ICollection<Alumn> _allaAlumner;
        private ICollection<Alumn> _tempAlumner;
        private Alumn _selectedAlumn;
        private string _name;
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; Changed(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }

        public ICollection<Alumn> TempAlumner
        {
            get { return _tempAlumner; }
            set { _tempAlumner = value; Changed(); }
        }

        public Alumn SelectedAlumn
        {
            get { return _selectedAlumn; }
            set { _selectedAlumn = value; Changed(); }
        }


        public ICollection<Alumn> AllaAlumner
        {
            get { return _allaAlumner; }
            set { _allaAlumner = value; Changed(); }
        }


        IWindowManager wm = new WindowManager();

        public MailingSkapaViewModel(Personal p)
        {
            Personal = p;
            AllaAlumner = BusinessManager.GetAllAlumns();
            TempAlumner = new List<Alumn>();
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
            TryClose();
        }

        public void btnVälj()
        {
            TempAlumner.Add(SelectedAlumn);
        }

        public void btnSkapa()
        {
            Mailing m = new Mailing();
            m.Namn = Name;
            m.Message = Message;
            m.UtskicksLista = TempAlumner;

            BusinessManager.AddMailing(m);
            BusinessManager.uow.Complete();

            wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
            TryClose();
        }

    }
}
