using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StockMANAGEMENT.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfRepositoryProduct());
        public IActionResult Index()
        {
            var values = pm.ListAllProduct;
            return View(values);
        }
    }
}
