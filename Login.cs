using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginInMVC4WithEF.Models
{
    public class Login
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string passwordsalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean IsActive { get; set; }
    }
}