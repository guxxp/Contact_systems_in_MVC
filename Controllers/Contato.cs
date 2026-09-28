using Microsoft.AspNetCore.Mvc;

namespace Contact_systems_in_MVC.Controllers
{
    public class Contato : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
