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
    public partial class Admin_Editera_Personal : Form
    {
        public string namn;
        public string email;
        public string lösenord;
        public string användarnamn;
        public string titel;

        BusinessManager businessManager = new BusinessManager(new DatabaseContext());
        public Administratör Administratör { get; set; }
        Personal p = new Personal();

        public Admin_Editera_Personal(Administratör admin)
        {
            InitializeComponent();
            Administratör = admin;

            dataGridView1.DataSource = businessManager.GetAllPersonal();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessManager.GetAllPersonal();
            dataGridView1.AutoSize = true;
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            email = textBoxMail.Text;
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
                AnvändarNamn = användarnamn,
                Password = lösenord,
                Namn = namn,
                Email = email,
               Titel = titel,
                Godkännande = DateTime.Now

            };

            businessManager.AddPersonal(p);
            MessageBox.Show($"Personal { namn} är registrerad", "Registrerat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            businessManager.uow.Complete();
            UpdateDataGrid();

            textBoxNamn.Clear();
            textBoxMail.Clear();
            textBoxAnvändarNamn.Clear();
            textBoxLösenord.Clear();
            textBox1.Clear();
        }

        private void btnEditera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                p = (Personal)dataGridView1.CurrentRow.DataBoundItem;
                Editera_Persoanl ep = new Editera_Persoanl(p, Administratör);
                this.Hide();
                ep.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            titel = textBox1.Text;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Admin_Profil ap = new Admin_Profil(Administratör);
            this.Hide();
            ap.Show();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                p = (Personal)dataGridView1.CurrentRow.DataBoundItem;
                businessManager.RemovePersonal(p);
            }

            businessManager.uow.Complete();

            MessageBox.Show($"Personal { namn} är raderad", "Registrerat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateDataGrid();
        }
    }
}
