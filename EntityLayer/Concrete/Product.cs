using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; }
        public bool ProductStatus { get; set; }


        public int Subcategory_id { get; set; }
        public Subcategory? Subcategory { get; set; }
        public Guid ProductImageId { get; set; }
        public ProductImage? ProductImage { get; set; }



    }
}
