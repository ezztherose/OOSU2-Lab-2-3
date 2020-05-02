using BusinessEntities_Framework;
using BusinessEntities_Framework.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEnteties.models
{
    public class Personal : IAnvändare, IPersonal
    {
        public int ID {get; set;}
        public string AnvändarNamn { get; set; }
        public string Password { get; set; }
        public DateTime Godkännande { get; set; }
        public string Namn { get; set; }
        public string Titel { get; set; }
        public string Email { get; set; }

        public Personal ()
        {

        }
    }
}
