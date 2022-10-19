using BasicAuthInWebApi.Models;
using System;
using System.Linq;

namespace BasicAuthInWebApi.BasicAuth
{
    public class UserValidate
    {
        public static bool Login(string UserName, string Password)
        {
            using (BasicAuthEntities entities = new BasicAuthEntities())
            {
                return entities.Users.Any(x => x.UserName.Equals(UserName,
                    StringComparison.OrdinalIgnoreCase) && x.Password == Password);
            }
        }
    }
}