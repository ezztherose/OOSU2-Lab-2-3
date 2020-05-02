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
    public partial class Editera_Mailing : Form
    {
        string namn;
        string message;

        public Personal Personal { get; set; }
        public Mailing Mailing { get; set; }
        BusinessManager BusinessManager { get; set; } = new BusinessManager(new DatabaseContext());
        public Editera_Mailing(Personal p, Mailing m)
        {
            InitializeComponent();
            Personal = p;
            Mailing = m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mailing_Personal mp = new Mailing_Personal(Personal);
            this.Hide();
            mp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namn != null)
            {
                Mailing.Namn = namn;
            }

            if (message != null)
            {
                Mailing.Message = message;
            }

            BusinessManager.UpdateMailing(Mailing, Mailing.ID);
            BusinessManager.uow.Complete();

            Mailing_Personal mp = new Mailing_Personal(Personal);
            this.Hide();
            mp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            message = textBox2.Text;
        }
    }
}
