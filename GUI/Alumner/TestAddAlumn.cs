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

namespace GUI
{
    public partial class TestAddAlumn : Form
    {
        public string namn;
        public string arbete;
        public string utgångsår;
        public string utbildning;
        public string lösen;
        public string intresse;
        public string användarNamn;

        BusinessManager BusinessManager = new BusinessManager(new DatabaseContext());
      


        public TestAddAlumn()
        {
            InitializeComponent();

            comboBoxTypAvAnvändare.Items.Add("Alumn");
            comboBoxTypAvAnvändare.Items.Add("Student");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            arbete = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            utgångsår = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            utbildning = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            lösen = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            användarNamn = textBox6.Text;
        }

        private void richTextBoxIntressen_TextChanged(object sender, EventArgs e)
        {
            intresse = richTextBoxIntressen.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBoxTypAvAnvändare == null)
            {
                MessageBox.Show("Vilken typ", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxTypAvAnvändare.SelectedItem.ToString() == "Alumn")
            {
                BusinessManager.AddAlumn(new Alumn()
                {
                    Godkännande = new DateTime(2020, 02, 19),
                    Namn = namn,
                    Arbete = arbete,
                    Utgångsår = utgångsår,
                    Utbildning = utbildning,
                    Password = lösen,
                    Intressen = intresse,
                    AnvändarNamn = "a" + användarNamn
                }) ;
            }
            else if (comboBoxTypAvAnvändare.SelectedItem.ToString() == "Student")
            {
                // Registrera student
            }
            

            BusinessManager.uow.Complete();
            MessageBox.Show("Ditt konto är nu skapat", "Registrerat", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TestAddAlumn_Load(object sender, EventArgs e)
        {

        }
    }
}
