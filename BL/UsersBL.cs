using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UsersBL
    {
        public User GetUserAsync(string name, string Password)
        {
            UsersService usersService = new UsersService();
            return  usersService.GetUser(name, Password);
        }
    }
}
