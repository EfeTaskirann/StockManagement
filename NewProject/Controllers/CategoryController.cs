using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfRepositoryCategory());
        public IActionResult Index()
        {
            var values = cm.ListAllCategory;
            return View(values);
        }
    }
}
