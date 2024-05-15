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
            vm.Icecekler = db.Icecekler.ToList();
            return View(vm);
        }

        public IActionResult IcecekEkle()
        {
            return View(vm.IcecekEkleVM);
        }

        [HttpPost]
        public IActionResult IcecekEkle(IcecekEkleVM ıcecekEkleVM)
        {
            if (ModelState.IsValid)
            {

                Icecek ıcecek = new Icecek();
                ıcecek.Ad = ıcecekEkleVM.Ad;
                ıcecek.Fiyat = ıcecekEkleVM.Fiyat;
                ıcecek.Aciklama = ıcecekEkleVM.Aciklama;
                ıcecek.Adet = ıcecekEkleVM.Adet;

                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += ıcecekEkleVM.PicturePath.FileName;
                string dosyaYolu = "wwwRoot/Pictures/Icecekler/";
                ıcecek.PicturePath = dosyaAdi;


                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                ıcecekEkleVM.PicturePath.CopyTo(fs);
                fs.Close();

                db.Icecekler.Add(ıcecek);
                db.SaveChanges();
                return RedirectToAction(nameof(IcecekListele));

            }
            return View(vm);


        }

        public IActionResult IcecekSil(int id)
        {
            var icecek = db.Icecekler.FirstOrDefault(x => x.IcecekID.Equals(id));
            FileInfo fi = new FileInfo("wwwRoot/Pictures/Icecekler/" + icecek.PicturePath);
            fi.Delete();
            db.Icecekler.Remove(icecek);

            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infosil"] = "Menü Başarıyla Silindi";
                    db.SaveChanges();
                    return RedirectToAction(nameof(IcecekListele));
                }
            }
            catch (Exception)
            {

                TempData["infosil"] = "Menü Silerken Hata Oluştu";
            }

            return RedirectToAction(nameof(IcecekListele));

        }


        public IActionResult IcecekGuncelle(int id)
        {
            IcecekEkleVM vm = db.Icecekler.Where(x => x.IcecekID.Equals(id)).Select(x => new IcecekEkleVM()
            {
                Aciklama = x.Aciklama,
                Ad = x.Ad,
                Adet = x.Adet,
                Fiyat = x.Fiyat,
            }).FirstOrDefault();
            return View(vm);
        }

        [HttpPost]
        public IActionResult IcecekGuncelle(IcecekEkleVM ıcecekEkleVM, int id)
        {
            Icecek ıcecek = db.Icecekler.FirstOrDefault(x => x.IcecekID.Equals(id));
            ıcecek.Ad = ıcecekEkleVM.Ad;
            ıcecek.Adet = ıcecekEkleVM.Adet;
            ıcecek.Aciklama = ıcecekEkleVM.Aciklama;
            ıcecek.Fiyat = ıcecekEkleVM.Fiyat;

            FileInfo fi = new FileInfo("wwwroot/Pictures/Icecekler/" + ıcecek.PicturePath);
            fi.Delete();

            Guid guid = Guid.NewGuid();

            string dosyaAdi = guid.ToString();

            dosyaAdi += ıcecekEkleVM.PicturePath.FileName;

            string dosyaYolu = "wwwRoot/Pictures/Icecekler/";

            ıcecek.PicturePath = dosyaAdi;

            FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);

            ıcecekEkleVM.PicturePath.CopyTo(fs);

            fs.Close();

            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infoguncelle"] = "İçecek başarıyla güncellendi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(IcecekListele));
                }
            }
            catch (Exception)
            {
                TempData["infoguncelle"] = "İçecek güncellenirken hata oluştu!";
            }

            return RedirectToAction(nameof(IcecekListele));
        }

    }
}