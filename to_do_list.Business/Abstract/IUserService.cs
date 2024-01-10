using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Entities;

namespace to_do_list.Business.Abstract
{
   public interface IUserService
    {
        List<User> getAllUser();
        User checkUser(int id, string password);
        User createUser(User user);
        User updateUser(User user);
        void deleteUser(int id, string password);
    }
}
