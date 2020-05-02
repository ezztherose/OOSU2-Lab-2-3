using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Observer_Pattern
{
    public partial class Observer : Button, IObserver
    {
        public Observer()
        {
            InitializeComponent();
        }

        public void ObserverUpdate(ISubject subject)
        {
            
        }

        protected override void OnPrint(PaintEventArgs e)
        {
            base.OnPrint(e);
        }
    }
}
