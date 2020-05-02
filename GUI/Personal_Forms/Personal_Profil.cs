using BusinessEnteties.models;
using BusinessEntities_Framework.models;
using GUI.Personal_Forms;
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
    public partial class Personal_Profil : Form
    {
        public Personal Personal { get; set; }
        public Event Event { get; set; }

        public Personal_Profil(Personal p)
        {
            InitializeComponent();
            Personal = p;

            label1.Text = Personal.Namn;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditPersonalProfil epp = new EditPersonalProfil(Personal);
            this.Hide();
            epp.Show();
        }

        private void buttonLoggaUt_Click(object sender, EventArgs e)
        {
            LoggIn LI = new LoggIn();
            this.Hide();
            LI.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skapa_Event se = new Skapa_Event(Personal);
            this.Hide();
            se.Show();
        }

        private void buttonSkapaJobb_Click(object sender, EventArgs e)
        {
            SkapaJobbAnnons sja = new SkapaJobbAnnons(Personal);
            this.Hide();
            sja.Show();
        }

        private void buttonRedigeraEent_Click(object sender, EventArgs e)
        {
            RedigeraEvent re = new RedigeraEvent(Personal);
            this.Hide();
            re.Show();
        }

        private void btnListor_Click(object sender, EventArgs e)
        {
            Mailing_Personal mp = new Mailing_Personal(Personal);
            this.Hide();
            mp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event_View ev = new Event_View(Personal);
            this.Hide();
            ev.Show();
        }
    }
}
