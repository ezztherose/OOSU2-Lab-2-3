using BusinessEnteties.models;
using BusinessEntities_Framework;
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

namespace GUI.Alumner
{
    public partial class AlumnJobb : Form
    {
        public string search;
        public Alumn Alumn { get; set; }

        public Jobb jobb = new Jobb();

        BusinessManager businessManager = new BusinessManager(new DatabaseContext());

        public AlumnJobb(Alumn alumn)
        {
            InitializeComponent();
            Alumn = alumn;
            dataGridView1.DataSource = businessManager.GetAllJobb();
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessManager.GetAllJobb();
            dataGridView1.AutoSize = true;
        }

        private void HideColumns()
        {
            dataGridView1.Columns["Sluttid"].Visible = false;
        }

        private void buttonSök_Click(object sender, EventArgs e)
        {
            search = textBoxSearch.Text;
            UpdateDataGrid();

            businessManager.SearchJob(search);
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                jobb = (Jobb)dataGridView1.CurrentRow.DataBoundItem;
            }

            businessManager.RegistreraJobb(Alumn.ID, jobb);
            MessageBox.Show("Registrerad");
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Alum_student AS = new Alum_student(Alumn);
            this.Hide();
            AS.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AlumnJobb_Load(object sender, EventArgs e)
        {

        }
    }
}
