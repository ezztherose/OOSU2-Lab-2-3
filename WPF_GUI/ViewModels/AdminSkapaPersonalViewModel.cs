using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI.ViewModels
{
    public class AdminSkapaPersonalViewModel : ViewModelBase
    {
        public Administratör Administratör { get; set; }

        IWindowManager wm = new WindowManager();

        public AdminSkapaPersonalViewModel(Administratör a)
        {
            Administratör = a;
        }

        private string _name;
        private string _mail;
        private string _titel;
        private string _användarNamn;
        private string _lösenord;

        public string Lösenord
        {
            get { return _lösenord; }
            set { _lösenord = value;Changed(); }
        }

        public string Användarnamn
        {
            get { return _användarNamn; }
            set { _användarNamn = value; Changed(); }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; Changed(); }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value;Changed(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new AdminProfilViewModel(Administratör), null, null);
            TryClose();
        }

        public void btnCreate()
        {
            BusinessManager.AddPersonal(new Personal()
            {
                Namn = Name,
                Email = Mail,
                Titel = Titel,
                AnvändarNamn = Användarnamn,
                Password = Lösenord,
                Godkännande = DateTime.Now
            });

            BusinessManager.uow.Complete();

            wm.ShowWindow(new AdminProfilViewModel(Administratör), null, null);
            TryClose();
        }
    }
}
