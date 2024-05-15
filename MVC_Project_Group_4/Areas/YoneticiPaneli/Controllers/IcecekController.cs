using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class IcecekController : Controller
    {
        private readonly BurgerDBContext db;

        public IcecekController(BurgerDBContext dbContext)
        {
            this.db = dbContext;
        }

        IcecekVM vm = new IcecekVM();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IcecekListele()
        {
            vm.Icecekler=db.Icecekler.ToList();
            return View(vm);
        }

        public IActionResult IcecekEkle()
        {
            return View(vm);
        }

        //public IActionResult MenuEkle( IcecekEkleVM ıcecekEkleVM)
        //{
        //    if(ModelState.IsValid)
        //    {

        //        Icecek ıcecek =new Icecek();
        //        ıcecek.Ad=ıcecekEkleVM.Ad;
        //        ıcecek.Fiyat = ıcecekEkleVM.Fiyat;
        //        ıcecek.Aciklama = ıcecekEkleVM.Aciklama;
        //        ıcecek.Adet = ıcecekEkleVM.Adet;

        //        Guid guid = Guid.NewGuid();
        //        string dosyaAdi = guid.ToString();
        //        dosyaAdi += menuEkle.PicturePath.FileName;
        //        string dosyaYolu = "wwwRoot/Pictures/Menuler/";
        //        menu.PicturePath = dosyaAdi;

        //    }


        //}
    }
}
