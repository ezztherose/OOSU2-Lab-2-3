using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using BusinessEntities_Framework.models;
using BusinessEntities_Framework;

namespace DataLayer.models
{
   
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Alumn> Alumner { get; set; }
        public virtual DbSet<Administratör> Administratörer { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Jobb> Jobb { get; set; }
        public virtual DbSet<Mailing> Mailing { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DatabaseContext() : base()
        {

        }

        public void Reset()
        {
            #region Remove Tables

            string connectionString = Database.Connection.ConnectionString;
            string commandText = "EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'; EXEC sp_msforeachtable 'DROP TABLE ?'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                        // throw;
                    }
                }

                conn.Close();
            }
            #endregion

            Database.Initialize(true);
            Seed();
        }

        private void Seed()
        {
            Alumner.Add(new Alumn()
            {
                Namn = "Nisse Testsson",
                Godkännande = DateTime.Now,
                AnvändarNamn = "bert",
                Password = "123",
                Utbildning = "Yrkesutbildning"
                
            });

            Alumner.Add(new Alumn()
            {
                Namn = "Bob Smith",
                Godkännande = DateTime.Now,
                AnvändarNamn = "bob",
                Password = "123",
                Utbildning = "Systemvetare",
                Utgångsår = "1785",
                Arbete = "Arbetslös",
                Intressen = "Splela spel"

            });

            Alumner.Add(new Alumn()
            {
                Namn = "Jonny Boii",
                Godkännande = DateTime.Now,
                AnvändarNamn = "jonny",
                Password = "123",
                Utbildning = "Systemarkitekt",
                Utgångsår = "1785",
                Arbete = "Apple",
                Intressen = "Jobba, jobba, jobba.."

            });

            Alumner.Add(new Alumn()
            {
                Namn = "Gustaav",
                Godkännande = DateTime.Now,
                AnvändarNamn = "Gabriel",
                Password = "123",
                Utbildning = "Systemarkitekt",
                Utgångsår = "1785",
                Arbete = "Polis",
                Intressen = "Resa. Ut och jaga."

            });

            Alumner.Add(new Alumn()
            {
                Namn = "Jesper jeemo",
                Godkännande = DateTime.Now,
                AnvändarNamn = "sjesper",
                Password = "123",
                Utbildning = "Systemarkitekt",
                Utgångsår = "1785",
                Arbete = "Microsoft",
                Intressen = "Sova och äta godis..."

            });

            Alumner.Add(new Alumn()
            {
                Namn = "Anna",
                Godkännande = DateTime.Now,
                AnvändarNamn = "anna",
                Password = "123",
                Utbildning = "Systemarkitekt",
                Utgångsår = "1785",
                Arbete = "Högskolan Borås",
                Intressen = "Forska..."

            });

            Event.Add(new Event()
            {
                Namn = "Hemmafest",
                Starttid = "19.00",
                Sluttid = "23.00",
                Plats = "Hemma hos Kajsa",
                Beskrivning ="Saftkalas",
                Datum = DateTime.Now,
                EventAlumner = null
            });

            Administratörer.Add(new Administratör()
            {
                AnvändarNamn = "root",
                Password = "password",
                Namn = "Admin",
                Mail = "admin@sit.com"
            });

            Personal.Add(new Personal()
            {
                AnvändarNamn = "johanna",
                Password = "123",
                Godkännande = DateTime.Now,
                Namn = "Johanna",
                Titel = "Professor",
                Email = "johanna@test.com"
  
            });

            SaveChanges();
        }
    }
}
