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
    public class MailingDeltagandeViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }
        public Mailing Mailing { get; set; }
        public ICollection<Alumn> Temp { get; set; }

        IWindowManager wm = new WindowManager();

        public MailingDeltagandeViewModel(Personal p, Mailing m)
        {
            Personal = p;
            Mailing = m;
            TillagdaAlumnus = BusinessManager.HämtaTillagdaAlumner(Mailing); //**********
            Temp = new List<Alumn>();
        }

        private ICollection<Alumn> _allaAlumner;
        private ICollection<Alumn> _tillagdaAlumner; // ***********
        private Alumn _selectedAlumn;

        public Alumn SelectedAlumn
        {
            get { return _selectedAlumn; }
            set { _selectedAlumn = value; Changed(); }
        }


        public ICollection<Alumn> TillagdaAlumnus // ******************
        {
            get { return _tillagdaAlumner; }
            set { _tillagdaAlumner = value; Changed(); }
        }


        public ICollection<Alumn> AllaAlumner
        {
            get { return _allaAlumner; }
            set { _allaAlumner = value; Changed(); }
        }

        public void btnAdd()
        {
            if (SelectedAlumn != null)
            {
                TillagdaAlumnus.Add(SelectedAlumn);
            }
           
            
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
            TryClose();
        }

    }
}
