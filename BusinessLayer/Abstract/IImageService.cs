using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class IImageService
    {
        void AddProductImage(ProductImage ProductImage);
        void DeleteProductImage(ProductImage ProductImage);
        void UpdateProductImage(ProductImage ProductImage);
        List<ProductImage> GetListAllProductImage();
        Category GetById(int id);

    }
}
