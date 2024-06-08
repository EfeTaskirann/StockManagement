using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StockMANAGEMENT.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfRepositoryUser());

        public IActionResult Index()
        {
            var values = um.ListAllUser;
            return View(values);
        }
    }
}
