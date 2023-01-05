using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costea_Maria_ClaudiaBakery.Models
{
    public class LoginModel
    {
        [PrimaryKey]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
