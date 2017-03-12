namespace CoreWebApi.Models
{
    public class UserSession
    {
        private string _id;
        private AppTenant _tenant;

        public UserSession(string Id, AppTenant tenant)
        {
            _id = Id;
            _tenant = tenant;
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }

        public AppTenant Tenant
        {
            get
            {
                return _tenant;
            }
        }
    }
}
