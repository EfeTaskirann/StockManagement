using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Subcategory
    {
        [Key]
        public int Subcategory_id { get; set; }
        public string? Subcategory_name { get; set; }

        public bool Subcategory_status { get; set; }
        public int Category_id { get; set; }
        public  Category? Category { get; set; }
    }
}
