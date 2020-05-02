using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEnteties
{
    public interface IAnvändare
    {
        DateTime Godkännande { get; set; }
        string Password { get; set; }
        string AnvändarNamn { get; set; }
        string Namn { get; set; }
        int ID { get; set; }
    }
}
