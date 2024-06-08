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
    public class SubcategoryRepository : IGenericDal<Subcategory>
    {
        Context c = new Context();

        public void AddSubcategory(Subcategory subcategory)
        {

        }

        public void Delete(Subcategory t)
        {

        }

        public Subcategory GetById(int id)
        {
            return c.Subcategories.Find(id);
        }

        public List<Subcategory> GetListAll()
        {
            c.Subcategories.ToList();
            return c.Subcategories.ToList();
        }

        public void insert(Subcategory t)
        {

        }

        public void Update(Subcategory t)
        {

        }



    }
}
