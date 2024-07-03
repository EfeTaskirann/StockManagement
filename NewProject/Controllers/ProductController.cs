using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StockMANAGEMENT.Controllers;

public class ProductController : Controller
{
    ProductManager pm = new ProductManager(new EfRepositoryProduct());
    SubcategoryManager subCategoryM = new SubcategoryManager(new EfRepositorySubcategory());


    public IActionResult Index()
    {
        var values = pm.ListAllProduct;
        return View(values);
    }
    [HttpGet]
    public IActionResult Add()
    {
        ViewBag.Subcategories = new SelectList(subCategoryM.ListAllSubcategory, "Subcategory_id", "Subcategory_name");
        return View();
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        if (ModelState.IsValid)
        {
            pm.AddProduct(product);
            return RedirectToAction("Index");
        }
        ViewBag.Subcategories = new SelectList(subCategoryM.ListAllSubcategory, "Subcategory_id", "Subcategory_name", product.Subcategory_id);
        return View(product);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var product = pm.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        ViewBag.Subcategories = new SelectList(subCategoryM.ListAllSubcategory, "Subcategory_id", "Subcategory_name", product.Subcategory_id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product product)
    {
        if (ModelState.IsValid)
        {
            pm.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        ViewBag.Subcategories = new SelectList(subCategoryM.ListAllSubcategory, "Subcategory_id", "Subcategory_name", product.Subcategory_id);
        return View(product);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var product = pm.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var product = pm.GetById(id);
        if (product != null)
        {
            pm.DeleteProduct(product);
        }
        return RedirectToAction("Index");
    }

    //private SelectList GetSubcategoriesSelectList()
    //{
    //    // Burada alt kategorileri SelectList olarak döndürebilirsiniz
    //    // Örnek olarak, alt kategorileri veritabanından çekerek veya elle ekleyerek yapabilirsiniz
    //    return new SelectList(new List<SelectListItem>
    //    {
    //        new SelectListItem { Value = "1", Text = "Subcategory 1" },
    //        new SelectListItem { Value = "2", Text = "Subcategory 2" },
    //        new SelectListItem { Value = "3", Text = "Subcategory 3" },
    //    }, "Value", "Text");
    //}

}

