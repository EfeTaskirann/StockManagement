using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.insert(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

        public User GetById(int id) => _userDal.GetById(id);

        public List<User> ListAllUser => _userDal.GetListAll();

    }
}
