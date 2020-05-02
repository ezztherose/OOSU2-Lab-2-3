using BusinessEnteties.models;
using BusinessLayer_Framework;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class Admin_Profil : Form
    {
        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());
        public Administratör Administratör { get; set; }

        public Admin_Profil(Administratör admin)
        {
            InitializeComponent();
            Administratör = admin;
            if (Administratör.Namn != null)
            {
                label1.Text = Administratör.Namn;
            }
            else
            {
                label1.Text = "Admin";
            }
        }

        private void Admin_Profil_Load(object sender, EventArgs e)
        {

        }

        private void btnHanteraPersonal_Click(object sender, EventArgs e)
        {
            Admin_Editera_Personal aep = new Admin_Editera_Personal(Administratör);
            this.Hide();
            aep.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLäggTillPersonal_Click(object sender, EventArgs e)
        {
            Admin_Editera_Personal ltp = new Admin_Editera_Personal(Administratör);
            this.Hide();
            ltp.Show();
        }

        private void buttonLoggaUt_Click(object sender, EventArgs e)
        {
            LoggIn li = new LoggIn();
            this.Hide();
            li.Show();
        }
    }
}
