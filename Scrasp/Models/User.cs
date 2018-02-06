using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class User : IdentifiableEntity
    {
        private string userName;
        private string password;
        private string role;

        public User(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
    }
}