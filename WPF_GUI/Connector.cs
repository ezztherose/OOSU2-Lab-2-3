using BusinessLayer_Framework;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GUI
{
    public class Connector
    {
        public static BusinessLayer_Framework.BusinessManager BusinessManager { get; set; } =
            new BusinessManager(new DatabaseContext());
    }
}
