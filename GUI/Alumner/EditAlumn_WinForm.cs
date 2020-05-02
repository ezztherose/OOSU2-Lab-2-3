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

namespace GUI.Alumner
{
    public partial class EditAlumn_WinForm : Form
    {
        public string namn;
        
        public string password;
        public string password2;
        public string arbete;
        public string utbildning;
        public string utgångsår;
        public string intresse;

        public Alumn Alumn { get; set; }
        BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public EditAlumn_WinForm(Alumn alumn)
        {
            InitializeComponent();
            Alumn = alumn;
        }

        private void EditAlumn_WinForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUtbildning_TextChanged(object sender, EventArgs e)
        {
            utbildning = textBoxUtbildning.Text;
        }

        private void textBoxUtgångsår_TextChanged(object sender, EventArgs e)
        {
            utgångsår = textBoxUtgångsår.Text;
        }

        private void textBoxNuvarandeArbete_TextChanged(object sender, EventArgs e)
        {
            arbete = textBoxNuvarandeArbete.Text;
        }

        private void textBoxLösen_TextChanged(object sender, EventArgs e)
        {
            password = textBoxLösen.Text;
        }

        private void textBoxLösen2_TextChanged(object sender, EventArgs e)
        {
            password2 = textBoxLösen2.Text;
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (namn != null)
            {
                Alumn.Namn = namn;
            }

            if (utbildning != null)
            {
                Alumn.Utbildning = utbildning;
            }

            if (utgångsår != null)
            {
                Alumn.Utgångsår = utgångsår;
            }

            if (arbete != null)
            {
                Alumn.Arbete = arbete;
            }

            if (intresse != null)
            {
                Alumn.Intressen = intresse;
            }

            if (password == password2 && password != null)
            {
                Alumn.Password = password;
            }

            if (password != password2)
                MessageBox.Show("Password must match Verified Password");
            else
            {
                Alumn alumn = new Alumn()
                {
                    Arbete = Alumn.Arbete,
                    Utbildning = Alumn.Utbildning,
                    Namn = Alumn.Namn,
                    Password = Alumn.Password,
                    Utgångsår = Alumn.Utgångsår,
                    AnvändarNamn = Alumn.AnvändarNamn,
                    Godkännande = DateTime.Now,
                    Intressen = Alumn.Intressen
                };

                businessManager.UpdateAlumn(Alumn, Alumn.ID);

                MessageBox.Show("Account was updated");
                DialogResult = DialogResult.OK;

                businessManager.uow.Complete();

                Alum_student a_s = new Alum_student(alumn);
                this.Hide();
                a_s.Show();
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Alum_student A_S = new Alum_student(Alumn);
            this.Hide();
            A_S.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            intresse = textBox1.Text;
        }
    }
}
