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

        public IActionResult Sepet(HamburgerVM hamburgerVM) 
        {

            return View();

        }


        [HttpPost]
        public IActionResult HamburgerDetay(int id)
        {
            HamburgerVM hamburgerVM = new HamburgerVM();

            hamburgerVM.Hamburger = db.Hamburgerler.FirstOrDefault(x=>x.HamburgerID==id);
            
            hamburgerVM.Hamburgerler.Add(hamburgerVM.Hamburger);

           return View(hamburgerVM);
        
        }
        
        public IActionResult IcecekDetay(int id)
        {

            IcecekVM ıcecekVM = new IcecekVM();

            ıcecekVM.Icecek = db.Icecekler.FirstOrDefault(x => x.IcecekID == id);

            ıcecekVM.Icecekler.Add(ıcecekVM.Icecek);

            return View(ıcecekVM);

        }
        
        public IActionResult TatliDetay(int id)
        {
            TatliVM tatliVM = new TatliVM();

            tatliVM.Tatli = db.Tatlilar.FirstOrDefault(x => x.TatliID == id);

            tatliVM.Tatlilar.Add(tatliVM.Tatli);

            return View(tatliVM);

        }
       
        public IActionResult EkMalzemeDetay(int id)
        {
            EkstraMalzemeVM ekstraMalzemeVM = new EkstraMalzemeVM();

            ekstraMalzemeVM.EkstraMalzeme = db.EkstraMalzemeler.FirstOrDefault(x => x.EkstraMalzemeID == id);

            ekstraMalzemeVM.EkstraMalzemeler.Add(ekstraMalzemeVM.EkstraMalzeme);

            return View(ekstraMalzemeVM);

        }
        
        public IActionResult MenuDetay(int id)
        {
            MenuVM menuVM = new MenuVM();

            menuVM.Menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);

            menuVM.Menuler.Add(menuVM.Menu);

            return View(menuVM);

        }

    }
}
