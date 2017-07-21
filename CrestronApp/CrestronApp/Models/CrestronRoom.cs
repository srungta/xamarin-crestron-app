using System;
using System.Collections.Generic;
using System.Text;

namespace CrestronApp.Models
{
    public class CrestronRoom : BaseDataObject
    {
        string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        string ipAddress = string.Empty;
        public string IpAddress
        {
            get { return ipAddress; }
            set { SetProperty(ref ipAddress, value); }
        }
    }
}
