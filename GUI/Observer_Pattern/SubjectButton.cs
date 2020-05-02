using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Observer_Pattern
{
    class SubjectButton : Button
    {
        public Subject Subject { get; set; } = new Subject();
    }
}
