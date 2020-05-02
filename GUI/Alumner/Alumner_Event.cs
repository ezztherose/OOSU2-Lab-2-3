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

namespace GUI.Alumner
{
    public partial class Alumner_Event : Form
    {
        public string search;
        public Alumn Alumn { get; set; }
        public Event ev = new Event();

        BusinessManager businessManager = new BusinessManager(new DatabaseContext());
       
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
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["p"].Visible = false;
        }

        public Alumner_Event(Alumn alumn)
        {
            InitializeComponent();
            Alumn = alumn;
            dataGridView1.DataSource = businessManager.GetAllEvents();
            HideColumns();
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Alum_student a_s = new Alum_student(Alumn);
            this.Hide();
            a_s.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSök_Click(object sender, EventArgs e)
        {
            search = textBox1.Text;
            UpdateDataGrid();

            businessManager.SearchEvent(search);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search = textBox1.Text;
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                ev = (Event)dataGridView1.CurrentRow.DataBoundItem;
            }

            businessManager.RegistreraPåEvent(Alumn.ID, ev);

            MessageBox.Show($"Registrerad: {ev.Namn}");

            Alum_student a_s = new Alum_student(Alumn);
            this.Hide();
            a_s.Show();
        }

        private void Alumner_Event_Load(object sender, EventArgs e)
        {

        }
    }
}
