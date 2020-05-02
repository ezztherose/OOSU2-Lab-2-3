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
    public class PersonalMailingViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }
        private List<Mailing> _mailing;
        private Mailing _selectedMailing;

        public Mailing SelectedMailing
        {
            get { return _selectedMailing; }
            set { _selectedMailing = value; Changed(); }
        }

        public List<Mailing> Mailing
        {
            get { return _mailing; }
            set { _mailing = value; Changed(); }
        }


        IWindowManager wm = new WindowManager();

        public PersonalMailingViewModel(Personal p)
        {
            Personal = p;
            Mailing = new List<Mailing>(BusinessManager.GetAllMailings());
        }

        public void btnSkapaLista()
        {
            wm.ShowWindow(new MailingSkapaViewModel(Personal), null, null);
            TryClose();
        }

        public void btnDelete()
        {
            if (SelectedMailing != null)
            {
                BusinessManager.RemoveMailing(SelectedMailing);
                BusinessManager.uow.Complete();
                wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
                TryClose();
            }
            else
            {
                MessageBox.Show("No list has med selected");
            }

        }

        public void btnEditera()
        {
            if (SelectedMailing != null)
            {
                wm.ShowWindow(new MailingEditeraViewModel(Personal, SelectedMailing), null, null);
                TryClose();
            }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalProfilViewModel(Personal), null, null);
            TryClose();
        }

        public void btnDeltagare()
        {
            if (SelectedMailing != null)
            {
                wm.ShowWindow(new MailingDeltagandeViewModel(Personal, SelectedMailing), null, null);
                TryClose();
            }
            
        }
    }
}
