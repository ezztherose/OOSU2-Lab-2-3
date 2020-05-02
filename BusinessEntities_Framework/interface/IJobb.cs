using BusinessEnteties.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_Framework
{
    interface IJobb
    {
        string Anställningsfrom { get; set; }
        string Sysselsättningsgrad { get; set; }
        DateTime SistaAnsökningsdag { get; set; }
        ICollection<Alumn> AlumnJobb { get; set; }
        Personal personal { get; set; }
    }
}
