using BusinessEnteties.models;
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

namespace GUI.Admin
{
    public partial class BjudIn : Form
    {
       public string search;

        BindingSource bindingSource = new BindingSource();
        BusinessManager bm = new BusinessManager(new DatabaseContext());

        List<Alumn> TempAlumn = new List<Alumn>();

        public BjudIn()
        {
            InitializeComponent();
        }

        public void UpdateDataGrid(List<Alumn> list)
        {
            bindingSource.DataSource = list;
            dataGridView1.DataSource = bindingSource;
            HideColumns();
            
        }

        public void HideColumns()
        {
            
            dataGridView1.Columns["Användarnamn"].Visible = false;
            dataGridView1.Columns["Utgångsår"].Visible = false;
            dataGridView1.Columns["Intressen"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BjudIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonSök_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            UpdateDataGrid(bm.SearchAlumn(search));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(checkBox);
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
        }

        private void btnHämtaAllaAlumner_Click(object sender, EventArgs e)
        {
            TempAlumn = bm.GetAllAlumns();
            UpdateDataGrid(TempAlumn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

            UpdateDataGrid(TempAlumn);
        }
    }
}
