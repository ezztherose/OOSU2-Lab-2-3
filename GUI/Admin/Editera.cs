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
    public partial class Editera_Persoanl : Form
    {
        public string namn;
        public string titel;
        public string email;
        public string användarnamn;
        public string password;

        public Administratör Administratör { get; set; }
        public Personal Personal { get; set; }
        public BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public Editera_Persoanl(Personal p, Administratör a)
        {
            InitializeComponent();
            Personal = p;
            Administratör = a;
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUppdater_Click(object sender, EventArgs e)
        {
            if (namn != null)
            {
                Personal.Namn = namn;
            }

            if (titel != null)
            {
                Personal.Titel = titel;
            }

            if (email != null)
            {
                Personal.Email = email;
            }

            if (användarnamn != null)
            {
                Personal.AnvändarNamn = användarnamn;
            }

            if (password != null)
            {
                Personal.Password = password;
            }

            businessManager.UpdatePersonal(Personal, Personal.ID);

            MessageBox.Show($"Personal { namn} är updaterad", "Registrerat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            businessManager.uow.Complete();

            Admin_Editera_Personal aep = new Admin_Editera_Personal(Administratör);
            this.Hide();
            aep.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            titel = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = textBox3.Text;
        }

        private void textBoxVerifera_TextChanged(object sender, EventArgs e)
        {
            användarnamn = textBoxVerifera.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            password = textBox4.Text;
        }

        private void Editera_Persoanl_Load(object sender, EventArgs e)
        {

        }
    }
}
