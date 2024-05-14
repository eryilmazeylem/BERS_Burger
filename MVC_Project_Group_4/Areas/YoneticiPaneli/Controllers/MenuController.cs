using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class MenuController : Controller
    {
        private readonly BurgerDBContext db;

        public MenuController()
        {
        }

        public MenuController(BurgerDBContext dbContext)
        {
            this.db = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Menuler()
        {
            return View();
        }
    }
}
