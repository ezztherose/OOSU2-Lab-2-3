using BusinessEnteties.models;
using BusinessLayer_Framework;
using Caliburn.Micro;
using DataLayer.models;
using DataLayer.UnitToWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_GUI.ViewModels;

namespace WPF_GUI.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
		private string _userName;
		private string _password;

		Alumn alumn;
		Personal personal;
		Administratör administratör;

		IWindowManager wm = new WindowManager();

		public ShellViewModel()
		{
			Alumn = new Alumn();
			Administratör = new Administratör();
			Personal = new Personal();
		}

		public string UserName
		{
			get { return _userName; }
			set 
			{
				_userName = value;
				Changed();
			}
		}

		public string Password
		{
			get { return _password; }
			set 
			{ 
				_password = value;
				Changed();
			}
		}

		public Alumn Alumn
		{
			get { return alumn; } 
			set { alumn = value; Changed(); }
		}

		public Personal Personal
		{
			get { return personal; }
			set { personal = value; Changed(); }
		}

		public Administratör Administratör
		{
			get { return administratör; }
			set { administratör = value; Changed(); }
		}


		public void btnLoggin()
		{
			Alumn = BusinessManager.LoggInAlumn(UserName, Password);
			Administratör = BusinessManager.LoggInAdmin(UserName, Password);
			Personal = BusinessManager.LoggInPersonal(UserName, Password);

			if (Alumn == null && Personal == null && Administratör == null)
			{
				MessageBox.Show("Invalid login info");
			}
			else if (Alumn != null)
			{
				wm.ShowWindow(new AlumnProfilViewModel(Alumn), null, null);
				TryClose();
			}
			else if (Personal != null)
			{
				wm.ShowWindow(new PersonalProfilViewModel(Personal), null, null);
				TryClose();
			}
			else if (Administratör != null)
			{
				wm.ShowWindow(new AdminProfilViewModel(Administratör), null, null);
				TryClose();
			}
		}

		public void btnCreateAlumn()
		{
			wm.ShowWindow(new CreateAlumnViewModel(), null, null);
			TryClose();
		}

	}
}
