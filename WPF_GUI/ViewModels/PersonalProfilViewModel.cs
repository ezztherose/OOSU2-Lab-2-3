using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_GUI.ViewModels;
using WPF_GUI.Views;

namespace WPF_GUI.ViewModels
{
    public class PersonalProfilViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyOfPropertyChange(() => Name); }
        }


        public Personal Personal { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalProfilViewModel(Personal p)
        {
            Personal = p;
            Name = Personal.Namn;
        }

        public void btnLoggOut()
        {
            wm.ShowWindow(new ShellViewModel(), null, null);
            TryClose();
        }

        public void btnEditera()
        {
            //wm.ShowWindow(new EditeraPersonalViewModel(Personal), null, null);
            //TryClose();

            wm.ShowWindow(new PersonalEditProfileViewModel(Personal), null, null);
            TryClose();
        }

        public void btnMailing()
        {
            wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
            TryClose();
        }

        public void btnJobb()
        {
            wm.ShowWindow(new PersonalJobbListaViewModel(Personal), null, null);
            TryClose();
        }

        public void btnEvent()
        {
            wm.ShowWindow(new PersonalEventViewModel(Personal), null, null);
            TryClose();
        }
    }
}
