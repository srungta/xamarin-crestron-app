using System;
using System.Collections.Generic;
using System.Text;

namespace CrestronApp.Models
{
    public class CrestronRoom : BaseDataObject
    {
        string name = string.Empty;
        string ipAddress = string.Empty;
        public long ipId = 7;
        public string userName = string.Empty;
        public string password = string.Empty;
        public int port = 12345;
        public bool useSsl = false;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string IpAddress
        {
            get { return ipAddress; }
            set { SetProperty(ref ipAddress, value); }
        }

        public long IpId
        {
            get { return ipId; }
            set { SetProperty(ref ipId, value); }
        }
        public string UserName
        {
            get { return ipAddress; }
            set { SetProperty(ref ipAddress, value); }
        }
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        public int Port
        {
            get { return port; }
            set { SetProperty(ref port, value); }
        }
        public bool UseSsl
        {
            get { return useSsl; }
            set { SetProperty(ref useSsl, value); }
        }
    }
}
