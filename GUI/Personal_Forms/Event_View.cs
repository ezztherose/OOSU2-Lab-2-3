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
    public partial class Event_View : Form
    {
        public Personal Personal { get; set; }
        public Event Event { get; set; }
        Event ev = new Event();
        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());
        List<Event> AllaEvent = new List<Event>();


        public Event_View(Personal p)
        {
            InitializeComponent();
            Personal = p;

            dataGridViewEvent.DataSource = BusinessManager.GetAllEvents();
            AllaEvent.AddRange(BusinessManager.GetAllEvents());
        }

        private void UpdateGridEvent()
        {
            dataGridViewEvent.DataSource = null;
            dataGridViewEvent.DataSource = AllaEvent;
        }

        private void UpdateGridAlumner()
        {
            dataGridViewEventAlumner.DataSource = null;
        }

        private void HideColumsEvent()
        {
            dataGridViewEventAlumner.Columns["Godkännande"].Visible = false;
            dataGridViewEventAlumner.Columns["Password"].Visible = false;
            dataGridViewEventAlumner.Columns["AnvändarNamn"].Visible = false;
            dataGridViewEventAlumner.Columns["ID"].Visible = false;
            dataGridViewEventAlumner.Columns["Utbildning"].Visible = false;
            dataGridViewEventAlumner.Columns["Arbete"].Visible = false;
            dataGridViewEventAlumner.Columns["Utgångsår"].Visible = false;
            dataGridViewEventAlumner.Columns["Intressen"].Visible = false;
            dataGridViewEventAlumner.Columns["events"].Visible = false;
            dataGridViewEventAlumner.Columns["JobbAlumn"].Visible = false;
            dataGridViewEventAlumner.Columns["mailings"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personal_Profil pp = new Personal_Profil(Personal);
            this.Hide();
            pp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGridAlumner();

            if (dataGridViewEvent.CurrentRow != null)
            {
                ev = (Event)dataGridViewEvent.CurrentRow.DataBoundItem;
                BusinessManager.HämtaEventetsAlumner(ev);
            }

            dataGridViewEventAlumner.DataSource = BusinessManager.HämtaEventetsAlumner(ev);
            HideColumsEvent();
        }

        private void dataGridViewEventAlumner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
