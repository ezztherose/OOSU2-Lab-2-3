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
    public partial class Mailing_SeDeltagare : Form
    {
        public Personal Personal { get; set; }
        public Mailing Mailing { get; set; }
        BusinessManager BusinessManager { get; set; } = new BusinessManager(new DatabaseContext());

        public Mailing_SeDeltagare(Personal p, Mailing m)
        {
            InitializeComponent();
            Personal = p;
            Mailing = m;
            DataGrid();
            HideColums();
        }

        private void DataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BusinessManager.HämtaTillagdaAlumner(Mailing);
            HideColums();
        }

        private void HideColums()
        {
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Godkännande"].Visible = false;
            dataGridView1.Columns["AnvändarNamn"].Visible = false;
            dataGridView1.Columns["Utbildning"].Visible = false;
            dataGridView1.Columns["Arbete"].Visible = false;
            dataGridView1.Columns["Utgångsår"].Visible = false;
            dataGridView1.Columns["Intressen"].Visible = false;
            dataGridView1.Columns["events"].Visible = false;
            dataGridView1.Columns["JobbAlumn"].Visible = false;
            dataGridView1.Columns["mailings"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mailing_Personal mp = new Mailing_Personal(Personal);
            this.Hide();
            mp.Show();
        }
    }
}
