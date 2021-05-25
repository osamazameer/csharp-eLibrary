using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approps
{
    public class User
    {
        String name;
        int rollno;
        String username;
        String email;
        String password;

        public string Name { get => name; set => name = value; }
        public int Rollno { get => rollno; set => rollno = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
