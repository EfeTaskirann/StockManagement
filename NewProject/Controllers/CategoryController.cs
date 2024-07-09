using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace NewProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfRepositoryCategory());
        public IActionResult Index()
        {
            var values = cm.GetListAllCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = cm.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                cm.UpdateCategory(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                cm.AddCategory(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = cm.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = cm.GetById(id);
            if (category != null)
            {
                cm.DeleteCategory(category);
            }
            return RedirectToAction("Index");
        }
    }
}

