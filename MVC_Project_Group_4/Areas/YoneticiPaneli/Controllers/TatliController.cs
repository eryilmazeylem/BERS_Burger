using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class TatliController : Controller
    {
        private readonly BurgerDBContext db;
        public IActionResult Index()
        {
            return View();
        }
        TatliVM vm = new TatliVM();

        public TatliController(BurgerDBContext db)
        {
            this.db = db;
        }

        public IActionResult TatliListele()
        {
            vm.Tatlilar=db.Tatlilar.ToList();
            return View(vm);
        }
        public IActionResult TatliEkle() 
        { 
        return View(vm.TatliEkleVM);
        }

        [HttpPost]
        public IActionResult TatliEkle(TatliEkleVM tatliEkleVM)
        {
            if(ModelState.IsValid)
            {
                Tatli tatli=new Tatli();
                tatli.Ad=tatliEkleVM.Ad;
                tatli.Fiyat = tatliEkleVM.Fiyat;
                tatli.Aciklama = tatliEkleVM.Aciklama;
                tatli.Adet=tatliEkleVM.Adet;

                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += tatliEkleVM.PicturePath.FileName;
                string dosyaYolu = "wwwRoot/Pictures/Tatlilar/";
                tatli.PicturePath = dosyaAdi;

                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                tatliEkleVM.PicturePath.CopyTo(fs);
                fs.Close();

                db.Tatlilar.Add(tatli);
                db.SaveChanges();
                return RedirectToAction(nameof(TatliListele));
            }
            return View(vm);
        }

        public IActionResult TatliSil(int id)
        {
            var tatli=db.Tatlilar.FirstOrDefault(x=>x.TatliID == id);

            FileInfo fi = new FileInfo("wwwroot/Pictures/Tatlilar/" + tatli.PicturePath);
            fi.Delete();

            db.Tatlilar.Remove(tatli);


            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infosil"] = "Tatlı başarıyla silindi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(TatliListele));
                }
            }
            catch (Exception)
            {

                TempData["infosil"] = "Tatlı silinirken hata oluştu!";
            }

            return RedirectToAction(nameof(TatliListele));
        }

        public IActionResult TatliGuncelle(int id)
        {
        TatliEkleVM vm=db.Tatlilar.Where(x=>x.TatliID.Equals(id)).Select(x=>new TatliEkleVM()
        {
            Aciklama = x.Aciklama,
            Ad = x.Ad,
            Adet = x.Adet,
            Fiyat = x.Fiyat,
        }).FirstOrDefault();    
        
            return View(vm);    
        }

        [HttpPost]
        public IActionResult TatliGuncelle(TatliEkleVM tatli, int id)
        {
            Tatli tat = db.Tatlilar.FirstOrDefault(x => x.TatliID.Equals(id));

            tat.Ad = tatli.Ad;
            tat.Adet = tatli.Adet;
            tat.Aciklama = tatli.Aciklama;
            tat.Fiyat = tatli.Fiyat;

            FileInfo fi = new FileInfo("wwwroot/Pictures/Tatlilar/" + tat.PicturePath);
            fi.Delete();

            Guid guid = Guid.NewGuid();

            string dosyaAdi = guid.ToString();

            dosyaAdi += tatli.PicturePath.FileName;

            string dosyaYolu = "wwwRoot/Pictures/Tatlilar/";

            tat.PicturePath = dosyaAdi;

            FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);

            tatli.PicturePath.CopyTo(fs);

            fs.Close();

            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infoguncelle"] = "Tatlı başarıyla güncellendi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(TatliListele));
                }
            }
            catch (Exception)
            {

                TempData["infoguncelle"] = "Tatlı güncellenirken hata oluştu!";
            }

            return RedirectToAction(nameof(TatliListele));





        }
    }
}
