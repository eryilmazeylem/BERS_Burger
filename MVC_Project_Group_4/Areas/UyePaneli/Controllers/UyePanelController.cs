using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.ViewModels;

namespace MVC_Project_Group_4.Areas.UyePaneli.Controllers
{
    [Area("UyePaneli")]
    public class UyePanelController : Controller
    {
        private readonly BurgerDBContext db;

        public UyePanelController(BurgerDBContext db)
        {
            this.db = db;
        }
        UrunlerVM vm = new UrunlerVM();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Urunler()
        {
            vm.Hamburgerler = db.Hamburgerler.ToList();
            vm.EkstraMalzemeler = db.EkstraMalzemeler.ToList();
            vm.Tatlilar = db.Tatlilar.ToList();
            vm.Icecekler = db.Icecekler.ToList();
            vm.Menuler = db.Menuler.ToList();

            return View(vm);
        }

    }
}
