using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Areas.UyePaneli.Controllers
{
    public class SiparisController : Controller
    {
        private readonly BurgerDBContext db;

        public SiparisController(BurgerDBContext db)
        {
            this.db = db;
        }
        static List<Urun> SepeteEklenenUrunler = new List<Urun>();




        public IActionResult Index()
        {

            return View();


        }

        public IActionResult HamburgerDetay(int id)
        {
           var Hamburger = db.Hamburgerler.FirstOrDefault(x=>x.HamburgerID==id);
            
           SepeteEklenenUrunler.Add(Hamburger);

            return View();
        
        }

        public IActionResult IcecekDetay(int id)
        {
            var Icecek = db.Icecekler.FirstOrDefault(x => x.IcecekID == id);

            SepeteEklenenUrunler.Add(Icecek);

            return View();

        }

        public IActionResult TatliDetay(int id)
        {
            var Tatli = db.Tatlilar.FirstOrDefault(x => x.TatliID == id);

            SepeteEklenenUrunler.Add(Tatli);

            return View();

        }

        public IActionResult EkMalzemeDetay(int id)
        {
            var Ekmalzeme = db.EkstraMalzemeler.FirstOrDefault(x => x.EkstraMalzemeID == id);

            SepeteEklenenUrunler.Add(Ekmalzeme);

            return View();

        }

        public IActionResult MenuDetay(int id)
        {
            var Menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);

            SepeteEklenenUrunler.Add(Menu);

            return View();

        }

    }
}
