using BusinessEnteties.models;
using BusinessLayer_Framework;
using DataLayer.models;
using GUI.Alumner;
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
    public partial class Alum_student : Form
    {
        public string namn;
        public string utbildning;
        public string utgångsår;
        public string arbete;
        public string intressen;
        public int id;

        BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public Alumn Alumn { get; set; }

        public Alum_student(Alumn alumn)
        {
            InitializeComponent();
            Alumn = alumn;

            textBoxUtbildning.Text = Alumn.Utbildning;
            textBoxUtgångsår.Text = Alumn.Utgångsår;
            textBoxNuvarandeArbete.Text = Alumn.Arbete;
            richTextBoxIntressen.Text = Alumn.Intressen;

            labelAnvändarNamn.Text = Alumn.Namn;
        }

        private void textBoxAnvändarnNamn_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUtbildning_TextChanged(object sender, EventArgs e)
        {
            textBoxUtbildning.Text = Alumn.Utbildning;
        }

        private void textBoxUtgångsår_TextChanged(object sender, EventArgs e)
        {
            textBoxUtgångsår.Text = Alumn.Utgångsår;
        }

        private void textBoxNuvarandeArbete_TextChanged(object sender, EventArgs e)
        {
            textBoxNuvarandeArbete.Text = Alumn.Arbete;
        }

        private void richTextBoxIntressen_TextChanged(object sender, EventArgs e)
        {
            richTextBoxIntressen.Text = Alumn.Intressen;
        }

        private void buttonEditProfil_Click(object sender, EventArgs e)
        {
            EditAlumn_WinForm ea = new EditAlumn_WinForm(Alumn);
            this.Hide();
            ea.Show();
        }

        private void Alum_student_Load(object sender, EventArgs e)
        {

        }

        private void btnTaBortKonto_Click(object sender, EventArgs e)
        {
            businessManager.RemoveAlumn(Alumn);

            LoggIn loggin = new LoggIn();
            this.Hide();
            loggin.Show();
        }

        private void labelAnvändarNamn_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoggaUt_Click(object sender, EventArgs e)
        {
            LoggIn LI = new LoggIn();
            this.Hide();
            LI.Show();
        }

        private void buttonJobbErbjudande_Click(object sender, EventArgs e)
        {
            AlumnJobb aj = new AlumnJobb(Alumn);
            this.Hide();
            aj.Show();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            Alumner_Event ae = new Alumner_Event(Alumn);
            this.Hide();
            ae.Show();
        }
    }
}
