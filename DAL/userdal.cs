using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using approps;

namespace DAL
{
    public class userdal
    {
        dbcon db = new dbcon();
        public bool addUser(User U)
        {
            string qry = "INSERT INTO users (name,email,username,password,rollno) VALUES ('" + U.Name + "', '" + U.Email + "', '" + U.Username + "', '" + U.Password + "', '" + U.Rollno + "')";
            return db.UDI(qry);
        }
        public bool deleteUser(User U)
        {
            string qry = "Delete from users where rollno='" + U.Rollno + "'";
            return db.UDI(qry);
        }
        public bool updateUser(User U)
        {
            string qry = "UPDATE users SET name='" + U.Name + "', email='" + U.Email + "', username='" + U.Username + "', password='" + U.Password + "' WHERE rollno = '" + U.Rollno + "'";
            return db.UDI(qry);
        }
        public DataTable searchUser(User U)
        {
            string qry = "SELECT * FROM users WHERE rollno = '" + U.Rollno + "'";
            return db.Search(qry);
        }
        public DataTable allUsers()
        {
            string qry = "SELECT * FROM users";
            return db.Search(qry);
        }
    }
}
