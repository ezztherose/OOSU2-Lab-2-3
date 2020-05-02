using BusinessEnteties.models;
using BusinessLayer_Framework;
using DataLayer.models;
using GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggIn : Form
    {
        public string användarNamn;
        public string lösenord;

        BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public Alumn Alumn = null;
        public Personal Personal = null;
        public Administratör Administratör = null;
        //public Användare användare { get; set; }


        public LoggIn()
        {
            InitializeComponent();
            
        }

        private void textBoxAnvändarNamn_TextChanged(object sender, EventArgs e)
        {
            användarNamn = textBoxAnvändarNamn.Text;
        }

        private void textBoxLösenord_TextChanged(object sender, EventArgs e)
        {
            lösenord = textBoxLösenord.Text;
        }

        private void buttonLogaIn_Click(object sender, EventArgs e)
        {
            Alumn = businessManager.LoggInAlumn(användarNamn, lösenord);
            Personal = businessManager.LoggInPersonal(användarNamn, lösenord);
            Administratör = businessManager.LoggInAdmin(användarNamn, lösenord);

            if (Alumn == null && Personal == null && Administratör == null)
            {
                MessageBox.Show("Access denied :/");
            }
            else if (Alumn != null)
            {
                //Alumn = businessManager.LoggnAlumn(användarNamn, lösenord);
                Alum_student a_s = new Alum_student(Alumn);
                this.Hide();
                a_s.Show();
            }
            else if (Personal != null)
            {
                Personal_Profil pp = new Personal_Profil(Personal);
                this.Hide();
                pp.Show();
            }
            else if (Administratör != null)
            {
                Admin_Profil ap = new Admin_Profil(Administratör);
                this.Hide();
                ap.Show();
            }

        }

        private void linkLabelSkapaAlumnKonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // länka till testAddAlumn
            Form1 aa = new Form1();
            this.Hide();
            aa.Show();
        }
    }
}
