using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.models;
using BusinessEnteties.models;
using BusinessLayer_Framework;
using BusinessEntities_Framework;

namespace GUI
{
    public partial class SkapaJobbAnnons : Form
    {
        public string titel;
        public string arbetsgivare;
        public string sysselsättningsgrad;
        public string anställningsform;
        public DateTime tillträde;
        public DateTime sistaAnsökningsDag;
        public string beskrivning;

        public Personal Personal { get; }
        public Jobb jobb = new Jobb();

        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());

        public SkapaJobbAnnons(Personal personal)
        {
            InitializeComponent();
            Personal = personal;
        }

        private void textBoxTitel_TextChanged(object sender, EventArgs e)
        {
            titel = textBoxTitel.Text;
        }

        private void textBoxArbetsgivare_TextChanged(object sender, EventArgs e)
        {
            arbetsgivare = textBoxArbetsgivare.Text;
        }

        private void textBoxSGrad_TextChanged(object sender, EventArgs e)
        {
            sysselsättningsgrad = textBoxSGrad.Text;
        }

        private void textBoxANställningsfrom_TextChanged(object sender, EventArgs e)
        {
            anställningsform = textBoxANställningsfrom.Text;
        }

        private void dateTimePickerTillträde_ValueChanged(object sender, EventArgs e)
        {
            tillträde = dateTimePickerTillträde.Value;
        }

        private void dateTimePickerSistaDag_ValueChanged(object sender, EventArgs e)
        {
            sistaAnsökningsDag = dateTimePickerSistaDag.Value;
        }

        private void richTextBoxBeskrivning_TextChanged(object sender, EventArgs e)
        {
            beskrivning = richTextBoxBeskrivning.Text;
        }

        private void buttonLäggTillAlumn_Click(object sender, EventArgs e)
        {
            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();
        }

        private void buttonSkapaJobb_Click(object sender, EventArgs e)
        {
            if(arbetsgivare == null || anställningsform == null || titel == null || sysselsättningsgrad == null) 
            {
                MessageBox.Show("Fyll i samtliga fält");
            }
            else
            {
                BusinessManager.AddJobb(new Jobb()
                {
                    Titel = titel,
                    Arbetsgivare = arbetsgivare,
                    Sysselsättningsgrad = sysselsättningsgrad,
                    Anställningsfrom = anställningsform,
                    Beskrivning = beskrivning,
                    Datum = DateTime.Now,
                    SistaAnsökningsdag = DateTime.Now

                });

                MessageBox.Show("Jobbannons skapad");
                BusinessManager.uow.Complete();
            }

            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();
        }
    }
}
