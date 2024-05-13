using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class YoneticiPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
