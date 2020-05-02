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
    public class PersonalJobbViewModel : ViewModelBase
    {
        public Personal Personal { get; set; }

        IWindowManager wm = new WindowManager();

        public PersonalJobbViewModel(Personal p)
        {
            Personal = p;
        }

        private string _title;
        private string _arbetsgivare;
        private string _sysselsättningsgrad;
        private string _anställningsform;
        private string _beskrivning;

        public string Beskrivning
        {
            get { return _beskrivning; }
            set { _beskrivning = value; Changed(); }
        }

        public string Anställningsform
        {
            get { return _anställningsform; }
            set { _anställningsform = value; Changed(); }
        }

        public string Sysselsättningsgrad
        {
            get { return _sysselsättningsgrad; }
            set { _sysselsättningsgrad = value; Changed(); }
        }

        public string Arbetsgivare
        {
            get { return _arbetsgivare; }
            set { _arbetsgivare = value; Changed(); }
        }

        public string Titel
        {
            get { return _title; }
            set { _title = value; Changed(); }
        }

        public void btnTillbaka()
        {
            wm.ShowWindow(new PersonalJobbListaViewModel(Personal), null, null);
            TryClose();
        }

        public void btnCreate()
        {
            //Jobb j = new Jobb();
            //j.Titel = Titel;
            //j.Arbetsgivare = Arbetsgivare;
            //j.Sysselsättningsgrad = Sysselsättningsgrad;
            //j.Anställningsfrom = Anställningsform;
            //j.Beskrivning = Beskrivning;

            BusinessManager.AddJobb(new Jobb()
            {
                Titel = Titel,
                Arbetsgivare = Arbetsgivare,
                Sysselsättningsgrad = Sysselsättningsgrad,
                Anställningsfrom = Anställningsform,
                Beskrivning = Beskrivning,
                Datum = DateTime.Now,
                SistaAnsökningsdag = DateTime.Now

            });

            //BusinessManager.AddJobb(j);

            BusinessManager.uow.Complete();

            wm.ShowWindow(new PersonalJobbListaViewModel(Personal), null, null);
            TryClose();
        }
    }
}
