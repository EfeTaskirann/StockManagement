using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StockMANAGEMENT.Controllers
{
    public class SubcategoryController : Controller
    {
        SubcategoryManager sc = new SubcategoryManager(new EfRepositorySubcategory());

        public IActionResult Index()
        {
           var values = sc.ListAllSubcategory;
            return View(values);
        }
    }
}
