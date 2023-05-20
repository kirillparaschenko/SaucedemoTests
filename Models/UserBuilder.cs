using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Models
{
    public class UserBuilder
    {
        private User user;
        public UserBuilder() 
        {
            user = new User();
        }

        public UserBuilder SetUsername (string userName)
        {
            user.Username = userName;
            return this;
        }
        public UserBuilder SetPassword(string password)
        {
            user.Password = password;
            return this;
        }
        public UserBuilder SetUserName(string userName)
        {
            user.Username = userName;
            return this;
        }
        public UserBuilder SetUserFirstName(string userFirstName)
        {
            user.UserFirstName = userFirstName;
            return this;
        }
        public UserBuilder SetUserLastName(string userLastName)
        {
            user.UserLastName = userLastName;
            return this;
        }
        public UserBuilder SetUserPostalCode(string userPostalCode)
        {
            user.UserPostalCode = userPostalCode;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }
}
