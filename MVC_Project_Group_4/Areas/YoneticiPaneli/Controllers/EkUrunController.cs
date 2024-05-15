using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class EkUrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly BurgerDBContext db;

        public EkUrunController(BurgerDBContext db)
        {
            this.db = db;
        }

        
        public IActionResult EkUrunListele()
        {
            = db.EkstraMalzemeler.ToList();
            return View();
        }
    }
}
