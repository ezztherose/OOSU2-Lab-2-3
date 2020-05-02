using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_WPF.models
{
    class AlumnModel
    {
        public string Utbildning { get; set; }
        public string Arbete { get; set; }
        public string Utgångsår { get; set; }
        public string Intressen { get; set; }

        public ICollection<EventModel> events = new List<EventModel>();
        public ICollection<JobbModel> JobbAlumn = new List<JobbModel>();

        public AlumnModel()
        {

        }
    }
}

