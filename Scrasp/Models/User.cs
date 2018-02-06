using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class User : IdentifiableEntity
    {
        public string UserName { get; private set; }
        private string password;
        private string role;

        public User(string userName, string password, string role)
        {
            UserName = userName;
            this.password = password;
            this.role = role;
        }

    }
}