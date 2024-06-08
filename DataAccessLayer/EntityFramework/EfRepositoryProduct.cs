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

    public class EfRepositoryProduct : GenericRepository<Product, Context>, IProductDal
    {
        Context c = new Context();
        public void Delete(Product t)
        {
        }

        public Product GetById(int id)
        {
            return c.Products.Find(id);
        }

        public List<Product> GetListAll()
        {
           c.Products.ToList();
            return c.Products.ToList();
        }

        public void insert(Product t)
        {
            
        }

        public void Update(Product t)
        {
            
        }
    }
}
