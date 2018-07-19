namespace CrestronApp.Models
{
    public class CrestronRoom : BaseDataObject
    {
        public long ipId = 7;
        public string password = string.Empty;
        public int port = 41794;
        public string userName = string.Empty;
        public bool useSsl = false;
        string ipAddress = string.Empty;
        string name = string.Empty;

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
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
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
        public string UserName
        {
            get { return ipAddress; }
            set { SetProperty(ref ipAddress, value); }
        }
        public bool UseSsl
        {
            get { return useSsl; }
            set { SetProperty(ref useSsl, value); }
        }
    }
}
