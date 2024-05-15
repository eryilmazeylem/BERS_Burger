using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class HamburgerController : Controller
    {
        private readonly BurgerDBContext db;

        public HamburgerController(BurgerDBContext db)
        {
            this.db = db;
        }

        HamburgerVM vm = new HamburgerVM();

        public IActionResult HamburgerlerListele()
        {
            vm.Hamburgerler = db.Hamburgerler.ToList();
            return View(vm);
        }

        public IActionResult HamburgerOlustur()
        {

            return View(vm.HamburgerEkleVM);
        }

        [HttpPost]
        public IActionResult HamburgerOlustur(HamburgerEkleVM ekleVM)
        {
            if (ModelState.IsValid)
            {
                Hamburger yenihb = new Hamburger();

                yenihb.Ad = ekleVM.Ad;
                yenihb.Adet = ekleVM.Adet;
                yenihb.Aciklama = ekleVM.Aciklama;
                yenihb.Fiyat = ekleVM.Fiyat;

                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += ekleVM.PicturePath.FileName;
                string dosyaYolu = "wwwRoot/Pictures/Hamburgerler/";
                yenihb.PicturePath = dosyaAdi;

                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                ekleVM.PicturePath.CopyTo(fs);
                fs.Close();

                db.Hamburgerler.Add(yenihb);
                db.SaveChanges();
                return RedirectToAction(nameof(HamburgerlerListele));
            }

            return View(vm.HamburgerEkleVM);

        }

        public IActionResult HamburgerSil(int id)
        {
            var hmbrg = db.Hamburgerler.FirstOrDefault(x=>x.HamburgerID.Equals(id));

            FileInfo fi = new FileInfo("wwwroot/Pictures/Hamburgerler/" + hmbrg.PicturePath);
            fi.Delete();


            db.Hamburgerler.Remove(hmbrg);

            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infosil"] = "Hamburger başarıyla silindi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(HamburgerlerListele));
                }
            }
            catch (Exception)
            {

                TempData["infosil"] = "Hamburger silinirken hata oluştu!";
            }


            return RedirectToAction(nameof(HamburgerlerListele));

        }

        public IActionResult HamburgerGuncelle(int id)
        {
            Hamburger hamburger = db.Hamburgerler.FirstOrDefault(x=>x.HamburgerID == id);

            HamburgerEkleVM ekleVM = new HamburgerEkleVM();

            if (hamburger != null)
            {

                ekleVM.Ad = hamburger.Ad;
                ekleVM.Adet = hamburger.Adet;
                ekleVM.Aciklama = hamburger.Aciklama;
                ekleVM.Fiyat = hamburger.Fiyat;
                return View(ekleVM);

            }
            TempData["infoguncelle"] = "Hamburger güncellenirken hata oluştu!";
            return RedirectToAction("HamburgerListele");
        }

        [HttpPost]
        public IActionResult HamburgerGuncelle(int id, HamburgerEkleVM ekleVM)
        {

            Hamburger hmbrg = db.Hamburgerler.FirstOrDefault(x => x.HamburgerID.Equals(id));

            hmbrg.Ad = ekleVM.Ad;
            hmbrg.Adet = ekleVM.Adet;
            hmbrg.Aciklama = ekleVM.Aciklama;
            hmbrg.Fiyat = ekleVM.Fiyat;

            FileInfo fi = new FileInfo("wwwroot/Pictures/Hamburgerler/" + hmbrg.PicturePath);
            fi.Delete();

            Guid guid = Guid.NewGuid();

            string dosyaAdi = guid.ToString();

            dosyaAdi += ekleVM.PicturePath.FileName;

            string dosyaYolu = "wwwRoot/Pictures/Hamburgerler/";

            hmbrg.PicturePath = dosyaAdi;

            FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);

            ekleVM.PicturePath.CopyTo(fs);

            fs.Close();

            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infoguncelle"] = "Hamburger başarıyla güncellendi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(HamburgerlerListele));
                }
            }
            catch (Exception)
            {

                TempData["infoguncelle"] = "Hamburger güncellenirken hata oluştu!";
            }

            return RedirectToAction(nameof(HamburgerlerListele));

        }

    }
}
