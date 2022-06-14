using Homework18.Data;
using Homework18.Domain;
using System.Linq;

namespace Homework18.Services
{
    public interface IAuthService
    {
        User Login(User login);
    }
    public class AuthService : IAuthService
    {

        private readonly PersonContext _users;
        public AuthService(PersonContext users)
        {
            _users = users;
        }

        public User Login(User login)
        {
            if (string.IsNullOrEmpty(login.Username)||(string.IsNullOrEmpty(login.Password)))
            {
                return null;
            }
            var user = _users.Users.FirstOrDefault(x => x.Username == login.Username);
            if (user==null)
            {
                return null;

            }
            if (user.Password!=login.Password)
            {
                return null;
            }

            return user;
        }
    }
}
