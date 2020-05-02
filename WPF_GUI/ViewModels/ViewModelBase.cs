using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_GUI.ViewModels
{
    public class ViewModelBase : Screen, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected BusinessLayer_Framework.BusinessManager BusinessManager = Connector.BusinessManager;
        protected Window windowView = new Window();

        public ViewModelBase()
        {
            
        }

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
