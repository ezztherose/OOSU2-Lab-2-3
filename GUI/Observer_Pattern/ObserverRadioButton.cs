using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Observer_Pattern
{
    class ObserverRadioButton : RadioButton, IObserver
    {
        bool active = false;
        public void ObserverUpdate(ISubject subject)
        {
            if (!Checked)
            {
                ForeColor = Color.Red;
            }
            else
            {
                ForeColor = Color.Green;
            }

            active = !active;
        }
    }
}
