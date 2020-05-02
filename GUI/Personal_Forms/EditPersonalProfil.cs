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

namespace GUI
{
    public partial class EditPersonalProfil : Form
    {
        public string namn;
        public string titel;
        public string password;
        public string password2;

        public Personal Personal {get; set;}
        public string Titel { get; private set; }
        public string Password { get; private set; }

        BusinessManager businessManager = new BusinessManager(new DataLayer.models.DatabaseContext());
    public EditPersonalProfil(Personal personal)
        {
            InitializeComponent();
            Personal = personal;
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            titel = textBox2.Text;
        }

        private void buttonUppdater_Click(object sender, EventArgs e)
        {
            if (namn!=null)
            {
                Personal.Namn = namn;
            }

            if (titel!=null)
            {
                Personal.Titel = titel;
            }

            if (password == password2 && password !=null)
            {
                Personal.Password = password;
            }

            if (password != password2)
            {
                MessageBox.Show("Password must match Verified Password");
            }

            else
            {
                Personal personal = new Personal()
                {
                    Namn= Personal.Namn,
                    Titel = Personal.Titel,
                    Password = Personal.Password
                };

                businessManager.UpdatePersonal(Personal, Personal.ID);
               
                MessageBox.Show("Account was updated");
                DialogResult = DialogResult.OK;

                businessManager.uow.Complete();

                Personal_Profil pp = new Personal_Profil(Personal);
                this.Hide();
                pp.Show();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            password = textBox4.Text;
        }

        private void textBoxVerifera_TextChanged(object sender, EventArgs e)
        {
            password2 = textBoxVerifera.Text;
        }
    }
}
