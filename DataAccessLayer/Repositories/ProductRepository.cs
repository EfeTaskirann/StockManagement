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
    public class ProductRepository : IGenericDal<Product>
    {
        Context c = new Context();

        public void AddProduct(Product product)
        {

        }   
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
