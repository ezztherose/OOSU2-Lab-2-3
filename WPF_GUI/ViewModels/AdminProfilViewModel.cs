using BusinessEnteties.models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI.ViewModels
{
    public class AdminProfilViewModel : ViewModelBase
    {
        public Administratör Administratör { get; set; }

        IWindowManager wm = new WindowManager();

        public AdminProfilViewModel(Administratör a)
        {
            Administratör = a;
            LoadInfo();
        }

        private string _name;

        public string Namn
        {
            get { return _name; }
            set { _name = value; Changed(); NotifyOfPropertyChange(() => Namn); }
        }

        private void LoadInfo()
        {
            Namn = Administratör.Namn;
        }

        public void btnLoggOut()
        {
            wm.ShowWindow(new ShellViewModel(), null, null);
            TryClose();
        }

        public void btnEditPeronal()
        {
            wm.ShowWindow(new AdminSkapaPersonalViewModel(Administratör), null, null);
            TryClose();
        }

        public void btnDeletePeronal()
        {
            wm.ShowWindow(new AdminTaBortPersonalViewModel(Administratör), null, null);
            TryClose();
        }
    }
}
