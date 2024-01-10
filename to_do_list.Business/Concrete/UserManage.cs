using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Business.Abstract;
using to_do_list.DataAccess.Concrete;
using to_do_list.Entities;

namespace to_do_list.Business.Concrete
{
    public class UserManage : IUserService

    {
        private UserRepository _userRepository;
        public UserManage()
        {
            _userRepository = new UserRepository();
        }

        public User createUser(User user)
        {

            return _userRepository.createUser(user);
        }

        public void deleteUser(int id,string password)
        {
            var deletedUser = _userRepository.getUserById(id);
            if (deletedUser.Password == password)
            {
                _userRepository.deleteUser(id);

            }

        }

        public List<User> getAllUser()
        {
            return _userRepository.getAllUser();
        }

        public User checkUser(int id,string password)
        {
            var checkUser= _userRepository.getUserById(id);
            if (checkUser.Password == password)
            {
                return checkUser;
            }
            else
            {
                User emptyUser = new User();
                return emptyUser;

            }
                
        }

        public User updateUser(User user)
        {
            return _userRepository.updateUser(user);
        }
    }
}
