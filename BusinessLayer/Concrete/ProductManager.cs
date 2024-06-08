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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void AddProduct(Product product)
        {
            _productDal.insert(product);
        }

        public void DeleteProduct(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int id) => _productDal.GetById(id);

        public void UpdateProduct(Product product)
        {
           _productDal.Update(product);
        }

        public List<Product> ListAllProduct => _productDal.GetListAll();
    }
}
