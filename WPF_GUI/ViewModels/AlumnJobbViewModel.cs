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
    public class AlumnJobbViewModel : ViewModelBase
    {
        public Alumn Alumn { get; set; }

        IWindowManager wm = new WindowManager();

        public AlumnJobbViewModel(Alumn a)
        {
            Alumn = a;
            JobbList = BusinessManager.GetAllJobb();
        }

        private ICollection<Jobb> _joibbList;
        private Jobb _selectedJobb;

        public Jobb SelectedJobb
        {
            get { return _selectedJobb; }
            set { _selectedJobb = value; Changed(); }
        }


        public ICollection<Jobb> JobbList
        {
            get { return _joibbList; }
            set { _joibbList = value;  Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
            TryClose();
        }

        public void btnRegistrera()
        {
            if (SelectedJobb != null)
            {
                BusinessManager.RegistreraJobb(Alumn.ID, SelectedJobb);
                BusinessManager.uow.Complete();

                wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
                TryClose();
            }
        }
    }
}
