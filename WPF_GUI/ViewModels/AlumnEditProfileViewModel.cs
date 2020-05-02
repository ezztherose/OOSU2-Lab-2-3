using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_GUI.Views;

namespace WPF_GUI.ViewModels
{
    public class AlumnEditProfileViewModel : ViewModelBase
    {
        public Alumn Alumn { get; set; }

        private string _name;
        private string _arbete;
        private string _utgångsÅr;
        private string _intressen;
        private string _användarnamn;
        private string _password;
        private string _utbildning;
        private bool _checked;

        IWindowManager wm = new WindowManager();

        public string Utbildning
        {
            get { return _utbildning; }
            set { _utbildning = value; Changed(); }
        }

        public bool Checked
        {
            get { return _checked; }
            set { _checked = value; Changed(); }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; Changed(); }
        }


        public string UserName
        {
            get { return _användarnamn; }
            set { _användarnamn = value; Changed(); }
        }


        public string Intressen
        {
            get { return _intressen; }
            set { _intressen = value; Changed(); }
        }


        public string UtgångsÅr
        {
            get { return _utgångsÅr; }
            set { _utgångsÅr = value; Changed(); }
        }


        public string Arbete
        {
            get { return _arbete; }
            set { _arbete = value; Changed(); }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }

        public AlumnEditProfileViewModel(Alumn a)
        {
            Alumn = a;
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
            TryClose();
        }

        public void btnUpdate()
        {
            if (Name != null)
            {
                Alumn.Namn = Name;
            }

            if (Arbete != null)
            {
                Alumn.Arbete = Arbete;
            }

            if (Utbildning != null)
            {
                Alumn.Utbildning = Utbildning;
            }

            if (UtgångsÅr != null)
            {
                Alumn.Utgångsår = UtgångsÅr;
            }

            if (Intressen != null)
            {
                Alumn.Intressen = Intressen;
            }

            if (UserName != null)
            {
                Alumn.AnvändarNamn = UserName;
            }

            if (Password != null)
            {
                Alumn.Password = Password;
            }

            BusinessManager.UpdateAlumn(Alumn, Alumn.ID);
            BusinessManager.uow.Complete();

            wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
            TryClose();
        }

        public void btnEvent()
        {
            wm.ShowWindow(new AlumnEventViewModel(Alumn), null, null);
            TryClose();
        }
    }
}
