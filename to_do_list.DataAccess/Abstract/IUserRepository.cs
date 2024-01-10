using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Entities;

namespace to_do_list.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> getAllUser();
        User getUserById(int id);
        User createUser(User user);
        User updateUser(User user);
        void deleteUser(int id);
    }
}
