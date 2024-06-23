using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfRepositorySubcategory : GenericRepository<Subcategory,Context>, ISubCategoryDal
    {
        Context c = new Context();
       
        public Subcategory GetById(int id)
        {
           return c.Subcategories.Find(id);
        }

        public List<Subcategory> GetListAll()
        {
           c.Subcategories.ToList();
            return c.Subcategories.ToList();
        }

      
    }
}
