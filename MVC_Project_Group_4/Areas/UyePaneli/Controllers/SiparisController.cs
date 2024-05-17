using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Abstract;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;

namespace MVC_Project_Group_4.Areas.UyePaneli.Controllers
{
    [Area("UyePaneli")]
    public class SiparisController : Controller
    {
        private readonly BurgerDBContext db;

        public SiparisController(BurgerDBContext db)
        {
            this.db = db;
        }

        UrunlerVM vm = new UrunlerVM();


        public IActionResult Index()
        {

            return View();


        }



        [HttpPost]
        public IActionResult HamburgerDetay(int id)
        {
            Hamburger hamburger = new Hamburger();

            hamburger = db.Hamburgerler.FirstOrDefault(x=>x.HamburgerID==id);
            
            vm.Hamburgerler.Add(hamburger);

            return View(vm);
        
        }
        
        public IActionResult IcecekDetay(int id)
        {
            Icecek icecek = db.Icecekler.FirstOrDefault(x => x.IcecekID == id);

            vm.Icecekler.Add(icecek);

            return View(vm);

        }
        
        public IActionResult TatliDetay(int id)
        {
            Tatli tatli = db.Tatlilar.FirstOrDefault(x => x.TatliID == id);

            vm.Tatlilar.Add(tatli);

            return View(vm);

        }
       
        public IActionResult EkMalzemeDetay(int id)
        {
            EkstraMalzeme ekMalzeme = db.EkstraMalzemeler.FirstOrDefault(x => x.EkstraMalzemeID == id);

            vm.EkstraMalzemeler.Add(ekMalzeme);

            return View(vm);

        }
        
        public IActionResult MenuDetay(int id)
        {
            Menu menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);

            vm.Menuler.Add(menu);

            return View(vm);

        }

    }
}
