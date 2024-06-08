using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : IGenericDal<User>
    {
        Context c = new Context();

        public void AddUser(User user)
        {

        }   
        public void Delete(User t)
        {
        }

        public User GetById(int id)
        {
            return c.Users.Find(id);
        }

        public List<User> GetListAll()
        {
            c.Users.ToList();
            return c.Users.ToList();
        }

        public void insert(User t)
        {
        }

        public void Update(User t)
        {
        }
    }
}
