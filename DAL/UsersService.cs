using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class UsersService
    {

        public User GetUser(string name, string password)
        {

            using (var db = new DBContext())
            {
                /* User temp = new User();
                 temp.Id = 12;
                 temp.Name = "yishai";
                 temp.Password = "1234";
                 temp.Role = UserRole.ADMIN;

                 db.Users.Add(temp);
                 db.SaveChanges();
                 */
                
                var user =  (from item in db.Users
                            where item.Name == name && password == item.Password
                            select item).ToList().First();
                
                if (user!=null)
                {
                    return user;
                }
               
                else
                {
                    throw new Exception("Critical error, we can't get the user details, check your DB");
                }
            }
        }
    }
}

