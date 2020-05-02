using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_GUI.Views;

namespace WPF_GUI.ViewModels
{
    public class AlumnProfilViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); NotifyOfPropertyChange(() => Name); }
        }

        public Alumn Alumn { get; set; }

        IWindowManager wm = new WindowManager();

        public AlumnProfilViewModel(Alumn a)
        {
            Alumn = a;
            LoadInfo();
        }

        private void LoadInfo()
        {
            Name = Alumn.Namn;
        }

        public void btnEditProfil()
        {
            wm.ShowWindow(new AlumnEditProfileViewModel(Alumn), null, null);
            TryClose();
        }

        public void btnEvent()
        {
            wm.ShowWindow(new AlumnEventViewModel(Alumn), null, null);
            TryClose();
        }

        public void btnLoggOut()
        {
            wm.ShowWindow(new ShellViewModel(), null, null);
            TryClose();
        }

        public void btnDelete()
        {
            MessageBoxResult answer = MessageBox.Show("This will delete your account permanently. Are you sure you whant to delete the account?","Varning", MessageBoxButton.YesNo);

            switch (answer)
            {
                case MessageBoxResult.Yes:
                    BusinessManager.RemoveAlumn(Alumn);
                    wm.ShowWindow(new ShellViewModel(), null, null);
                    TryClose();
                    break;
                case MessageBoxResult.No:
                break;
   
                default:
                    break;
            }
        }

        public void btnJobb()
        {
            wm.ShowWindow(new AlumnJobbViewModel(Alumn), null, null);
            TryClose();
        }
    }
}
