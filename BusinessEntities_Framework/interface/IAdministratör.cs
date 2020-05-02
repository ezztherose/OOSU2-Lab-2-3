using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEnteties
{
    public interface IAdministratör
    {
         string Mail { get; set; }
         string AnvändarNamn { get; set; }
         string Password { get; set; }
         string Namn { get; set; }
    }
}
