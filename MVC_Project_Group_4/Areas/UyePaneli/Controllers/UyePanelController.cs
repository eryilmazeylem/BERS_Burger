using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_Group_4.Areas.UyePaneli.Controllers
{
    [Area("UyePaneli")]
    public class UyePanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}
