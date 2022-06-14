using Homework18.Data;
using Homework18.Domain;
using System.Linq;

namespace Homework18.Services
{

    public interface IUserActionService
    {
        User Register(User register);
    }
    public class UserActionService: IUserActionService
    {
        private readonly PersonContext _users;
        public UserActionService(PersonContext users)
        {
            _users = users;
        }

       
        public User Register(User register)
        {
            if (string.IsNullOrEmpty(register.Username) || (string.IsNullOrEmpty(register.Password)))
            {
                return null;
            }
            var user = _users.Users.FirstOrDefault(x => x.Username == register.Username);
            if (user == null)
            {
                return null;

            }
            if (user.Password != register.Password)
            {
                return null;
            }

            return user;
        }
    }
}
