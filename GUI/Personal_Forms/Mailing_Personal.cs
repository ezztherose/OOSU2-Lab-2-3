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
    public partial class Mailing_Personal : Form
    {
        public Personal Personal { get; set; }
        public BusinessManager businessManager = new BusinessManager(new DatabaseContext());
        public Mailing mailing = new Mailing();

        public Mailing_Personal(Personal p)
        {
            InitializeComponent();
            Personal = p;

            dataGridView1.DataSource = businessManager.GetAllMailings();
            HideColumns();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessManager.GetAllMailings();
            dataGridView1.AutoSize = true;
            HideColumns();
        }

        private void HideColumns()
        {
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["UtskicksLista"].Visible = false;
        }

        private void btnEditera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                mailing = (Mailing)dataGridView1.CurrentRow.DataBoundItem;
            }
            Editera_Mailing em = new Editera_Mailing(Personal, mailing);
            this.Hide();
            em.Show();
        }

        private void btnSkapaLista_Click(object sender, EventArgs e)
        {
            Skapa_Mailing sm = new Skapa_Mailing(Personal);
            this.Hide();
            sm.Show();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();
        }

        private void btnTaBortLista_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                businessManager.RemoveMailing((Mailing)dataGridView1.CurrentRow.DataBoundItem);
                MessageBox.Show("Listan är borttagen");
            }

            UpdateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mailing m = new Mailing();
            if (dataGridView1.SelectedRows != null)
            {
                m = (Mailing)dataGridView1.CurrentRow.DataBoundItem;
            }

            Mailing_SeDeltagare msd = new Mailing_SeDeltagare(Personal, m);
            this.Hide();
            msd.Show();
        }
    }
}
