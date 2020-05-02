using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessEnteties.models
{
    public class Administratör : IAdministratör
    {
        public int Id { get; set; }
        public string Mail { get; set;}
        public string AnvändarNamn { get; set; }
        public string Password { get; set; }
        public string Namn { get; set; }

        public Administratör()
        {

        }

    }
}
