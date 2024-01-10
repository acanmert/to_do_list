using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.DataAccess.Abstract;
using to_do_list.Entities;

namespace to_do_list.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User createUser(User user)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void deleteUser(int id)
        {
            using (var userDbContext = new UserDbContext())
            {
                var deleteduser= userDbContext.Users.Find(id);
                userDbContext.Users.Remove(deleteduser);
                userDbContext.SaveChanges();
            }
        }

        public List<User> getAllUser()
        {
            using (var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User getUserById(int id)
        {
            using (var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public User updateUser(User user)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Update(user);
                return user;
            }
        }

    
    }
}
