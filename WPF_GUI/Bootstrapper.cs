using Caliburn.Micro;
using DataLayer.models;
using DataLayer.UnitToWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_GUI.ViewModels;

namespace WPF_GUI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Connector Con { get; set; }

        public Bootstrapper()
        {
            Initialize();
            //Con = new Connector();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

    }
}
