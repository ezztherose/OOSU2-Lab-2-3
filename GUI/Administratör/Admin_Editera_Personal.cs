using BusinessEnteties.models;
using BusinessLayer_Framework;
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
    public partial class Admin_Editera_Personal : Form
    {
        public string namn;
        public string mail;
        public string lösenord;
        public string användarnamn;

        BusinessManager businessManager { get; set; }
        public Admin_Editera_Personal()
        {
            InitializeComponent();
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            mail = textBoxMail.Text;
        }

        private void textBoxAnvändarNamn_TextChanged(object sender, EventArgs e)
        {
            användarnamn = textBoxAnvändarNamn.Text;
        }

        private void textBoxLösenord_TextChanged(object sender, EventArgs e)
        {
            lösenord = textBoxLösenord.Text;
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            Personal p = new Personal()
            {
                Namn = namn,
                AnvändarNamn = användarnamn,
                Email = mail,
                Password = lösenord,
                Godkännande = new DateTime(2020, 05, 05)
            };

            businessManager.AddPersonal(p);
        }
    }
}
