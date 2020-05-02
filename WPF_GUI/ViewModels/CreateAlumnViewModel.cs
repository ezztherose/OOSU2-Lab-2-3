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
    public class CreateAlumnViewModel : ViewModelBase
    {
        private string _name;
        private string _arbete;
        private string _utgångsÅr;
        private string _intressen;
        private string _användarnamn;
        private string _password;
        private string _utbildning;
        private bool _checked;

        IWindowManager wm = new WindowManager();

        public string Utbildning
        {
            get { return _utbildning; }
            set { _utbildning = value; Changed(); }
        }

        public bool Checked
        {
            get { return _checked; }
            set { _checked = value; Changed(); }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; Changed(); }
        }


        public string UserName
        {
            get { return _användarnamn; }
            set { _användarnamn = value; Changed(); }
        }


        public string Intressen
        {
            get { return _intressen; }
            set { _intressen = value; Changed(); }
        }


        public string UtgångsÅr
        {
            get { return _utgångsÅr; }
            set { _utgångsÅr = value; Changed(); }
        }


        public string Arbete
        {
            get { return _arbete; }
            set { _arbete = value; Changed(); }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; Changed(); }
        }

        public CreateAlumnViewModel()
        {

        }

        public void btnCreate()
        {
            if (Checked == false)
            {
                MessageBox.Show("You need to accept SIT's Terms and Conditions to create the account");
            }
            else
            {
                BusinessManager.AddAlumn(new Alumn()
                {
                    Godkännande = DateTime.Now,
                    Namn = Name,
                    Arbete = Arbete,
                    Utgångsår = UtgångsÅr,
                    Utbildning = Utbildning,
                    Password = Password,
                    Intressen = Intressen,
                    AnvändarNamn = UserName
                });

                BusinessManager.uow.Complete();

                wm.ShowWindow(new ShellViewModel(), null, null);
                TryClose();
            }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new ShellViewModel(), null, null);
            TryClose();
        }
    }
}
