using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    public class User
    {
        private int id;
        private string username ;
        private string password ;

        public string Username { get { return username; } }
        public string Password { get { return password; } }
        public int ID { get { return id; } }


        public User(string username,string password)
        {
            this.id = ID;
            this.username= username;
            this.password = password;
        }
        public User()
        {

        }
        


    }
}
