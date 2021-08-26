using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    class UserManagement
    {
       public static List<User> users = new  List<User>();

        public bool AddUser(User user)
        {
            foreach (var u in users)
            {
                if(u==user)
                {
                    return false;
                }
            }
            users.Add(user);
            return true;
        }

        public List<User> GetUsers()
        {
            return users;
        }
       
    }
}
