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
    public partial class Skapa_Mailing : Form
    {
        string namn;
        string message;

        public Personal Personal { get; set; }
        public Alumn Alumn { get; set; }
        Alumn a = new Alumn();
        public List<Alumn> TillgängligaAlumner = new List<Alumn>();
        public List<Alumn> valdaAlumner = new List<Alumn>();
        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());

        public Skapa_Mailing(Personal p)
        {
            InitializeComponent();
            Personal = p;

            dataGridViewAlla.DataSource = BusinessManager.GetAllAlumns();
            TillgängligaAlumner.AddRange(BusinessManager.GetAllAlumns());
        }

        private void UpdateGridAlla()
        {
            dataGridViewAlla.DataSource = null;
            dataGridViewAlla.DataSource = TillgängligaAlumner;
        }

        private void UpdateGridVald()
        {
            dataGridViewValda.DataSource = null;
            dataGridViewValda.DataSource = valdaAlumner;
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            message = textBoxMessage.Text;
        }

        private void btnLäggTillAlumn_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlla.CurrentRow != null)
            {
                a = (Alumn)dataGridViewAlla.CurrentRow.DataBoundItem;
                TillgängligaAlumner.Remove(a);
                valdaAlumner.Add(a);
            }

            UpdateGridAlla();
            UpdateGridVald();
        }

        private void dataGridViewValda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Mailing_Personal mp = new Mailing_Personal(Personal);
            this.Hide();
            mp.Show();
        }

        private void btnSkapa_Click(object sender, EventArgs e)
        {
            if (namn == null)
            {
                MessageBox.Show("Du behöver ett namn");
            }

            if (message == null)
            {
                MessageBox.Show("Lista behöver ett meddelande");
            }

            BusinessManager.AddMailing(new Mailing()
            {
                Namn = namn,
                Message = message,
                UtskicksLista = valdaAlumner
            });

            BusinessManager.uow.Complete();

            Mailing_Personal mp = new Mailing_Personal(Personal);
            this.Hide();
            mp.Show();
        }
    }
}
