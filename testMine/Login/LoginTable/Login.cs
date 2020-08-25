using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testMine.Login.LoginTable
{
    public class LoginList
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
