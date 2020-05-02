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
    public class MailingEditeraViewModel : ViewModelBase
    {
        IWindowManager wm = new WindowManager();
        public Personal Personal { get; set; }
        public Mailing MailingList { get; set; }

        public MailingEditeraViewModel(Personal p, Mailing m)
        {
            Personal = p;
            MailingList = m;
        }

        private string _message;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; Changed(); }
        }

        public void btnUpdate()
        {
            if (Name != null)
            {
                MailingList.Namn = Name;
            }

            if (Message != null)
            {
                MailingList.Message = Message;
            }

            BusinessManager.UpdateMailing(MailingList, MailingList.ID);
            BusinessManager.uow.Complete();

            wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
            TryClose();
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalMailingViewModel(Personal), null, null);
            TryClose();
        }
    }
}
