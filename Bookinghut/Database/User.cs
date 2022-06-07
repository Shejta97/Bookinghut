using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookinghut.Database
{
    public class User
    {
        [Key]

        public int UserID { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Mail { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }

    }
}
