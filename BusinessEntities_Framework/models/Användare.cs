using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEnteties.models
{
    public abstract class Användare : IAnvändare
    {
        public int ID { get; set; } 
        public DateTime Godkännande { get; set; }
        public string Password { get; set; }
        public string AnvändarNamn { get; set; }
        public string Namn { get; set; }
    }

   
}
