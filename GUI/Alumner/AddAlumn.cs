using BusinessEnteties.models;
using BusinessLayer_Framework;
using DataLayer.models;
using GUI.Observer_Pattern;
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
    public partial class Form1 : Form
    {
        public string namn;
        public string arbete;
        public string utgångsår;
        public string utbildning;
        public string lösen;
        public string intresse;
        public string användarNamn;

        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());
        ObserverRadioButton ObserverRadioButton { get; set; } = new ObserverRadioButton();
        SubjectButton SubjectButton { get; set; } = new SubjectButton();

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(ObserverRadioButton);
            this.Controls.Add(SubjectButton);

            ObserverRadioButton.Location = Godkännande.Location;
            SubjectButton.Location = button1.Location;
            ObserverRadioButton.Text = Godkännande.Text;
            ObserverRadioButton.Width = Godkännande.Width;
            SubjectButton.Text = button1.Text;

            Godkännande.Hide();
            button1.Hide();

            ObserverRadioButton.CheckedChanged += Godkännande_CheckedChanged;
            SubjectButton.Click += button1_Click_1;

            SubjectButton.Subject.Attach(ObserverRadioButton);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SubjectButton.Subject.Notify();

            if (ObserverRadioButton.Checked == true)
            {
                BusinessManager.AddAlumn(new Alumn()
                {
                    Godkännande = DateTime.Now,
                    Namn = namn,
                    Arbete = arbete,
                    Utgångsår = utgångsår,
                    Utbildning = utbildning,
                    Password = lösen,
                    Intressen = intresse,
                    AnvändarNamn = användarNamn
                });

                BusinessManager.uow.Complete();
                MessageBox.Show("Ditt konto är nu skapat", "Registrerat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoggIn loggin = new LoggIn();
                this.Hide();
                loggin.Show();
            }
            else
            {
                MessageBox.Show("Måste godkänna villkor");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            namn = textBox1.Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            arbete = textBox2.Text;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            utbildning = textBox4.Text;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            utgångsår = textBox3.Text;
        }

        private void richTextBoxIntressen_TextChanged_1(object sender, EventArgs e)
        {
            intresse = richTextBoxIntressen.Text;
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            användarNamn = textBox6.Text;
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            lösen = textBox5.Text;
        }

        private void Godkännande_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
