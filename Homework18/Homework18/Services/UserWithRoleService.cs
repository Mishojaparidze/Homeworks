using Homework18.Data;
using Homework18.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Homework18.Services
{

    public interface IUserWithRoleServiceWithRole
    {
        UserWithRole Login(UserWithRole user);
        object Login(User user);
    }
    public class UserWithRoleService: IUserWithRoleServiceWithRole
    {
        private readonly PersonContext _users;
        public UserWithRoleService(PersonContext users)
        {
            _users = users;
        }
        public UserWithRoleService()
        {
            new UserWithRole{ Role = Role.Admin};
            new UserWithRole { Role =Role.User };
        }

        
            

            public UserWithRole Login(UserWithRole login)
        {


            if (string.IsNullOrEmpty(login.Username) || (string.IsNullOrEmpty(login.Password)))
            {
                return null;
            }
            var user = _users.Users.FirstOrDefault(x => x.Username == login.Username);
            if (user == null)
            {
                return null;

            }
            if (user.Password!= login.Password)
            {
                return null;
            }

            return login;
        }
    }
}
