using CoreWebApi.Interfaces;

namespace CoreWebApi.Models
{
    public class UserSession : IUserSession
    {
        private string _Id;

        public UserSession(string Id)
        {
            _Id = Id;
        }

        public string Id
        {
            get
            {
                return _Id;
            }
        }
    }
}
