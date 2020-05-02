using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI.ViewModels
{
    public class PersonalEditProfileViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalEditProfileViewModel(Personal p)
        {
            Personal = p;
        }

        private string _name;
        private string _title;
        private string _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }


        public string Title
        {
            get { return _title; }
            set { _title = value; Changed(); }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalProfilViewModel(Personal), null, null);
            TryClose();
        }

        public void btnUpdate()
        {
            if (Name != null)
            {
                Personal.Namn = Name;
            }

            if (Title != null)
            {
                Personal.Titel = Title;
            }

            if (Password != null)
            {
                Personal.Password = Password;
            }

            BusinessManager.UpdatePersonal(Personal, Personal.ID);
            BusinessManager.uow.Complete();

            wm.ShowWindow(new PersonalProfilViewModel(Personal), null, null);
            TryClose();
        }
    }
}
