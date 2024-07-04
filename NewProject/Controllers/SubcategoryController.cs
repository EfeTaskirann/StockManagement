using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StockMANAGEMENT.Controllers
{
    public class SubcategoryController : Controller
    {

        SubcategoryManager sc = new SubcategoryManager(new EfRepositorySubcategory());
        CategoryManager categoryM = new CategoryManager(new EfRepositoryCategory());


        public IActionResult Index()
        {
           var values = sc.ListAllSubcategory;
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = new SelectList(categoryM.ListAllCategory, "Category_id", "Category_name");
            return View();
        }

        [HttpPost]
        public IActionResult Add(Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                sc.AddSubcategory(subcategory);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(categoryM.ListAllCategory, "Category_id", "Category_name", subcategory.Category_id);
            return View(subcategory);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var subcategory = sc.GetById(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            ViewBag.Categories = new SelectList(categoryM.ListAllCategory, "Category_id", "Category_name", subcategory.Category_id);
            return View(subcategory);
        }

        [HttpPost]
        public IActionResult Edit(Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                sc.UpdateSubcategory(subcategory);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(categoryM.ListAllCategory, "Category_id", "Category_name", subcategory.Category_id);
            return View(subcategory);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var subcategory = sc.GetById(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            return View(subcategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var subcategory = sc.GetById(id);
            if (subcategory != null)
            {
                sc.DeleteSubcategory(subcategory);
            }
            return RedirectToAction("Index");
        }
    }
}
