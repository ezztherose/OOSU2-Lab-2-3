using BusinessEntities_Framework.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEnteties.models;
using BusinessLayer_Framework;
using DataLayer.models;

namespace GUI.Personal_Forms
{
    public partial class RedigeraEvent : Form
    {
        public string search;

        public Event Event { get; set; }
        public Event ev = new Event();
        public Personal Personal { get; set; }
        public BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public RedigeraEvent(Personal p)
        {
            InitializeComponent();
            Personal = p;
            
            dataGridView1.DataSource = businessManager.GetAllEvents();
            HideColumns();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessManager.GetAllEvents();
            dataGridView1.AutoSize = true;
            HideColumns();
        }

        private void HideColumns()
        {
            dataGridView1.Columns["Sluttid"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ev = (Event)dataGridView1.CurrentRow.DataBoundItem;
                Editera_Event ee = new Editera_Event(ev, Personal);
                this.Hide();
                ee.Show();
            }
            else
            {
                MessageBox.Show("Du måste välja ett event!", "", MessageBoxButtons.YesNo);
            }
           
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ev = (Event)dataGridView1.CurrentRow.DataBoundItem;
            }

            businessManager.RemoveEvent(ev);
            UpdateDataGrid();
        }

        private void buttonSök_Click(object sender, EventArgs e)
        {
            search = textBoxSearch.Text;
            UpdateDataGrid();

            businessManager.SearchEvent(search);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
