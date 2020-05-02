using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_WPF.models
{
    class AdministratörModel
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string AnvändarNamn { get; set; }
        public string Password { get; set; }
        public string Namn { get; set; }

        public AdministratörModel()
        {

        }
    }
}
