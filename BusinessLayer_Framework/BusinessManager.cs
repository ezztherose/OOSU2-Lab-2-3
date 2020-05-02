using BusinessEnteties.models;
using BusinessEntities_Framework;
using BusinessEntities_Framework.models;
using DataLayer.models;
using DataLayer.UnitToWork;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_Framework
{
    public class BusinessManager
    {
        public BusinessManager(DatabaseContext databaseContext)
        {
            uow = new UnitOfWork(databaseContext);
        }

        public UnitOfWork uow { get; set; }

        public Event Event { get; set; }

        // Alumner
        public List<Alumn> SearchAlumn(string search)
        {
            List<Alumn> SökAlumn = new List<Alumn>();
            foreach (Alumn alumn in uow.AlumnRepository.SearchAlumn(search.ToLower()))
                SökAlumn.Add(alumn);

            return SökAlumn;
        }

        public void AddAlumn(Alumn alumn)
        {
            uow.AlumnRepository.Add(alumn);
        }

        public void UpdateAlumn(Alumn alumn, int id)
        {
            uow.AlumnRepository.Update(alumn, id);
        }

        public List<Alumn> GetAllAlumns()
        {
            List<Alumn> alumns = new List<Alumn>();

            alumns.AddRange(uow.AlumnRepository.GetAll());

            return alumns;
        }

        public void RemoveAlumn(Alumn a)
        {
            uow.AlumnRepository.Remove(a.ID);
        }

        public Alumn LoggInAlumn(string användarnamn, string password)
        {
            Alumn alumn = uow.AlumnRepository.LoggIn(användarnamn, password);
            if (alumn != null && alumn.Password == password)
                return alumn;
            return null;
        }

        public void RegistreraPåEvent(int id, Event e)
        {
            Alumn alumn = uow.AlumnRepository.Get(id);
            e = uow.EventRepository.Get(e.ID);

            if (alumn != null && e != null)
            {
                alumn.events.Add(e);
                uow.AlumnRepository.Update(alumn, alumn.ID);
                e.EventAlumner.Add(alumn);
                uow.EventRepository.Update(e, e.ID);
            }
            uow.Complete();
        }


        // Personal
        public Personal LoggInPersonal(string användarnamn, string password)
        {
            Personal personal = uow.PersonalRepository.LoggIn(användarnamn, password);
            if (personal != null && personal.Password == password)
            {
                return personal;
            }
            return null;
        }

        public void UpdatePersonal(Personal personal,int id)
        {
            uow.PersonalRepository.Update(personal,id);
        }

        public void AddPersonal(Personal p)
        {
            uow.PersonalRepository.Add(p);
        }

        public List<Personal> GetAllPersonal()
        {
            List<Personal> personal = new List<Personal>();

            personal.AddRange(uow.PersonalRepository.GetAll());

            return personal;
        }

        public void RemovePersonal(Personal p)
        {
            uow.PersonalRepository.Remove(p.ID);
        }

        // Jobb
        public void AddJobb(Jobb jobb)
        {
            uow.JobbRepository.Add(jobb);
        }

        public void AddEvent (Event Event)
        {
            uow.EventRepository.Add(Event);
        }

        public List<Jobb> SearchJob(string search)
        {
            List<Jobb> SökJobb = new List<Jobb>();
            foreach (Jobb e in uow.JobbRepository.SearchJob(search.ToLower()))
                SökJobb.Add(e);

            return SökJobb;
        }

        public void RegistreraJobb(int id, Jobb j)
        {
            Alumn alumn = uow.AlumnRepository.Get(id);
            j = uow.JobbRepository.Get(j.ID);

            if (alumn != null && j != null)
            {
                alumn.JobbAlumn.Add(j);
                uow.AlumnRepository.Update(alumn, alumn.ID);
                j.AlumnJobb.Add(alumn);
                uow.JobbRepository.Update(j, j.ID);
            }

            uow.Complete();
        }

        public List<Jobb> GetAllJobb()
        {
            List<Jobb> jobb = new List<Jobb>();

            jobb.AddRange(uow.JobbRepository.GetAll());

            return jobb;
        }

        public List<Alumn> HämtaJobbAlumner(Jobb b)
        {
            return uow.JobbRepository.HämtaJobbAlumner(b);
        }

        public void RemoveJobb(Jobb j)
        {
            uow.JobbRepository.Remove(j.ID);
        }

        // Admin
        public Administratör LoggInAdmin(string användarnamn, string password)
        {
            Administratör administratör = uow.AdministratörRepository.LoggIn(användarnamn, password);
            if (administratör != null && administratör.Password == password)
            {
                return administratör;
            }
            return null;
        }

        // Event
        public void CreateEvent(Event e, Personal p)
        {
            uow.EventRepository.CreateEvent(e, p);
        }

        public List<Event> SearchEvent(string search)
        {
            List<Event> SökEvent = new List<Event>();
            foreach (Event e in uow.EventRepository.SearchEvent(search.ToLower()))
                SökEvent.Add(e);

            return SökEvent;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return uow.EventRepository.GetAll();
        }

        public void UpdateEvent(Event ev, int id)
        {
            uow.EventRepository.Update(ev, id);
        }

        public void RemoveEvent(Event e)
        {
            uow.EventRepository.Remove(e.ID);
        }

        public List<Alumn> HämtaEventetsAlumner(Event e)
        {
            return uow.EventRepository.HämtaEventetsAlumner(e);
        }

        // Mailing
        public IEnumerable<Mailing> GetAllMailings()
        {
            return uow.MailingRepository.GetAll();
        }

        public void UpdateMailing(Mailing m, int id)
        {
            uow.MailingRepository.Update(m, id);
        }

        public void AddMailing(Mailing m)
        {
            uow.MailingRepository.Add(m);
        }

        public void RemoveMailing(Mailing m)
        {
            uow.MailingRepository.Remove(m.ID);
        }

        public List<Alumn> HämtaTillagdaAlumner(Mailing m)
        {
            return uow.MailingRepository.HämtaTillgängligaAlumner(m);
        }
    }
}