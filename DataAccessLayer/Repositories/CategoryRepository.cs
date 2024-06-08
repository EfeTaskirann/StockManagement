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
    public class CategoryRepository : IGenericDal<Category>
    {
        Context c = new Context();

        public void AddCategory(Category category)
        {

        }

        public void Delete(Category t)
        {

        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            c.Categories.ToList();
            return c.Categories.ToList();
        }

        public void insert(Category t)
        {

        }

        public void Update(Category t)
        {

        }


    }
}
