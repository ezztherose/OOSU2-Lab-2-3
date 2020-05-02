using BusinessEnteties.models;
using BusinessEntities_Framework;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI.ViewModels
{
    public class PersonalJobbListaViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalJobbListaViewModel(Personal p)
        {
            Personal = p;
            JobbLista = BusinessManager.GetAllJobb();
        }

        private ICollection<Jobb> _jobbLista;
        private Jobb _selectedJobb;

        public Jobb SelectedJobb
        {
            get { return _selectedJobb; }
            set { _selectedJobb = value; Changed(); }
        }

        public ICollection<Jobb> JobbLista
        {
            get { return _jobbLista; }
            set { _jobbLista = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalProfilViewModel(Personal), null, null);
            TryClose();
        }

        public void btnSkapa()
        {
            wm.ShowWindow(new PersonalJobbViewModel(Personal), null, null);
            TryClose();
        }

        public void btnDeltagare()
        {
            if (SelectedJobb != null)
            {
                wm.ShowWindow(new PersonalJobbDeltagareViewModel(Personal, SelectedJobb), null, null);
                TryClose();
            }
        }

        public void btnDelete()
        {
            if (SelectedJobb != null)
            {
                BusinessManager.RemoveJobb(SelectedJobb);
                BusinessManager.uow.Complete();

                wm.ShowWindow(new PersonalJobbListaViewModel(Personal), null, null);
                TryClose();
            }
        }
    }
}
