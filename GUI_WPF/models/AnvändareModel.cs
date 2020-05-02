using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_WPF.models
{
    class AnvändareModel
    {
        public int ID { get; set; }
        public DateTime Godkännande { get; set; }
        public string Password { get; set; }
        public string AnvändarNamn { get; set; }
        public string Namn { get; set; }
    }
}
