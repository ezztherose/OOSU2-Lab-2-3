using BusinessEnteties.models;
using DataLayer.models;
using DataLayer_Framework;
using DataLayer_Framework.models;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataLayer.UnitToWork
{
    public class UnitOfWork : IDisposable
    {
        public DatabaseContext DatabaseContext { get; set; }

        public UnitOfWork(DatabaseContext context)
        {
            DatabaseContext = context;

            AlumnRepository = new AlumnRepository(DatabaseContext);
            AdministratörRepository = new AdministratörRepository(DatabaseContext);
            PersonalRepository = new PersonalRepository(DatabaseContext);
            AnvändareRepository = new AnvändareRepository(DatabaseContext);
            EventRepository = new EventRepository(DatabaseContext);
            JobbRepository = new JobbRepository(DatabaseContext);
            MailingRepository = new MailingRepository(DatabaseContext);
        }

        public IAlumnRepository AlumnRepository { get; set; }
        public IAnvändareRepository AnvändareRepository { get; set; }
        public IAdministratörRepository AdministratörRepository { get; set; }
        public IPersonalRepository PersonalRepository { get; set; }
        public IEventRepository EventRepository { get; set; }
        public IJobbRepository JobbRepository { get; set; }
        public IMailingRepository MailingRepository { get; set; }

        /// <summary>
        /// Spara ändringar som görs
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return DatabaseContext.SaveChanges();
        }

        public void Dispose()
        {
            DatabaseContext.Dispose();
        }
    }
}
