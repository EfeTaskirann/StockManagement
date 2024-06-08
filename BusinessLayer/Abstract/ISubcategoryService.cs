using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubcategoryService
    {
        void AddSubcategory(Subcategory subcategory);
        void DeleteSubcategory(Subcategory subcategory);
        void UpdateSubcategory(Subcategory subcategory);

        List<Subcategory> ListAllSubcategory { get; }

        Subcategory GetById(int id);    
    }
}
