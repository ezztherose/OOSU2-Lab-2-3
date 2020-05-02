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
    public class PersonalJobbDeltagareViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }
        public Jobb Jobb { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalJobbDeltagareViewModel(Personal p, Jobb j)
        {
            Personal = p;
            Jobb = j;
            TillagdaAlumnus = BusinessManager.HämtaJobbAlumner(Jobb);
        }

        private ICollection<Alumn> _tillagdaAlumnus;

        public ICollection<Alumn> TillagdaAlumnus
        {
            get { return _tillagdaAlumnus; }
            set { _tillagdaAlumnus = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalJobbListaViewModel(Personal), null, null);
            TryClose();
        }

    }
}
