using BusinessEnteties.models;
using BusinessEntities_Framework.models;
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
    public partial class Skapa_Event : Form
    {
        public string eNamn;
        public string plats;
        public string starttid;
        public string sluttid;
        public DateTime datum;
        public string beskrivning;
        public string search;
        
        public Event Event = new Event();
        public Personal Personal {get; set;}

        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());

        public Skapa_Event(Personal personal)
        {
            InitializeComponent();
            Personal = personal;
        }

        private void buttonSkapaEvent_Click(object sender, EventArgs e)
        {
            if (eNamn == null || plats == null || starttid == null || datum == null)
            {
                MessageBox.Show("Fyll i samtliga fält");
            }
            else
            {
                Event ev = new Event()
                {
                    Plats = plats,
                    Starttid = starttid,
                    Sluttid = sluttid,
                    Datum = DateTime.Now,
                    Namn = eNamn,
                    Beskrivning = beskrivning
                };



                BusinessManager.CreateEvent(ev, Personal);

                MessageBox.Show("Event skapat");
                BusinessManager.uow.Complete();
            }

           
        }

        private void textBoxENamn_TextChanged(object sender, EventArgs e)
        {
            eNamn = textBoxENamn.Text;
        }

        private void textBoxPlats_TextChanged(object sender, EventArgs e)
        {
            plats = textBoxPlats.Text;
        }

        private void Skapa_Event_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSlutTid_TextChanged(object sender, EventArgs e)
        {
            sluttid = textBoxSlutTid.Text;
        }

        private void dateTimePickerEvent_ValueChanged(object sender, EventArgs e)
        {
            datum = dateTimePickerEvent.Value;
        }

        private void richTextBoxBeskrivning_TextChanged(object sender, EventArgs e)
        {
            beskrivning = richTextBoxBeskrivning.Text;
        }

        private void textBoxStartTid_TextChanged(object sender, EventArgs e)
        {
            starttid = textBoxStartTid.Text;
        }

        private void btnBjudIn_Click(object sender, EventArgs e)
        {
            BjudIn bi = new BjudIn();
            bi.Show();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();
        }
    }
}
