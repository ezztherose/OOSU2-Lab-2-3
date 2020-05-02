
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Data;
//using System.Linq;



//namespace DataLayer.models
//{
   
//    public class DatabaseContext : DbContext
//    {
       

//        public virtual DbSet<Alumn> Alumner { get; set; }
//        public virtual DbSet<Student> Studenter { get; set; }
//        public virtual DbSet<Administratör> Administratörer { get; set; }
//        public virtual DbSet<Personal> Personal { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            // För lokal databas
//           //  Server = (localdb)\\mssqllocaldb; Database = MvcMovieContext - 2; Trusted_Connection = True; MultipleActiveResultSets = true"

//            optionsBuilder.UseSqlServer("Data Source=sqlutb2.hb.se,56077; Initial Catalog=osu2009; user id=osu2009; password=wb5329; Persist Security Info=True");
//            base.OnConfiguring(optionsBuilder);
//            // Data Source=sqlutb2.hb.se,56077;Initial Catalog=osu2009;User ID=osu2009;
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);


//            // modelBuilder.Entity<Användare>().HasKey(x => x.Id);
//        }




//        // FRÅGA!!!
//        public DatabaseContext()
//            : base()
//        {

//        }

//    }
//}
