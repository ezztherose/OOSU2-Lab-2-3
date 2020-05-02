using BusinessEnteties.models;
using BusinessEntities_Framework.models;
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

namespace GUI.Personal_Forms
{
    public partial class Editera_Event : Form
    {
        public string namn;
        public string beskrivning;
        public string plats;
        public string starttid;
        public string sluttid;
        public DateTime datum;

        public Event Event { get; set; }
        public Personal Personal { get; set; }

        BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public Editera_Event(Event e, Personal p)
        {
            InitializeComponent();
            Event = e;
            Personal = p;
        }

        private void Editera_Event_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            plats = textBox4.Text;
        }

        private void textBoxVerifera_TextChanged(object sender, EventArgs e)
        {
            starttid = textBoxVerifera.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sluttid = textBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            beskrivning = textBox2.Text;
        }

        private void buttonUppdater_Click(object sender, EventArgs e)
        {
            if (namn != null)
            {
                Event.Namn = namn;
            }

            if (beskrivning != null)
            {
                Event.Beskrivning = beskrivning;
            }

            if (plats != null)
            {
                Event.Plats = plats;
            }

            if (starttid != null)
            {
                Event.Starttid = starttid;
            }

            if (sluttid != null)
            {
                Event.Sluttid = sluttid;
            }

            Event ev = new Event()
            {
                Namn = Event.Namn,
                Beskrivning = Event.Beskrivning,
                Plats = Event.Plats,
                Starttid = Event.Starttid,
                Sluttid = Event.Sluttid,
                Datum = new DateTime(2020, 05, 05)
            };

            businessManager.UpdateEvent(Event, Event.ID);

            MessageBox.Show("Event är uppdaterat", "", MessageBoxButtons.OK);
            businessManager.uow.Complete();

            RedigeraEvent er = new RedigeraEvent(Personal);
            this.Hide();
            er.Show();
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            RedigeraEvent er = new RedigeraEvent(Personal);
            this.Hide();
            er.Show();
        }
    }
}
