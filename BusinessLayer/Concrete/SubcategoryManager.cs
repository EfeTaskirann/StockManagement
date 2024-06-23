using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubcategoryManager : ISubcategoryService
    {
        ISubCategoryDal _subcategoryDal;
        public SubcategoryManager(ISubCategoryDal subcategoryDal) 
        {
            _subcategoryDal = subcategoryDal;   
        }

        public void AddSubcategory(Subcategory subcategory)
        {
            _subcategoryDal.insert(subcategory);
        }

        public void DeleteSubcategory(Subcategory subcategory)
        {
            _subcategoryDal.Delete(subcategory);
        }

        public void UpdateSubcategory(Subcategory subcategory)
        {
            _subcategoryDal.Update(subcategory);
        }

        public Subcategory GetById(int id) => _subcategoryDal.GetById(id);

        public List<Subcategory> ListAllSubcategory => _subcategoryDal.GetListAll();
    }
}

  
   


   
