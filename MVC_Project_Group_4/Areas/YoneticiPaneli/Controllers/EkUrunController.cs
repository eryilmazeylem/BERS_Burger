using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;

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

        EkstraMalzemeVM vm=new EkstraMalzemeVM();

        public IActionResult EkstraMalzemeListele()
        {
            vm.EkstraMalzemeler=db.EkstraMalzemeler.ToList();
            return View(vm);
        }
       
        public IActionResult EkstraMalzemeEkle()
        {
            return View(vm.EkstraMalzemeEkleVM);
        }

        [HttpPost]
        public IActionResult EkstraMalzemeEkle(EkstraMalzemeEkleVM ekstra)
        {
            if(ModelState.IsValid)
            {
                EkstraMalzeme ekstraMalzeme=new EkstraMalzeme();
                ekstraMalzeme.Ad = ekstra.Ad;
                ekstraMalzeme.Fiyat=ekstra.Fiyat;
                ekstraMalzeme.Aciklama=ekstra.Aciklama;
                ekstraMalzeme.Adet=ekstra.Adet;

                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += ekstra.PicturePath.FileName;
                string dosyaYolu = "wwwRoot/Pictures/Ek_Urunler/";
                ekstraMalzeme.PicturePath = dosyaAdi;

                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                ekstra.PicturePath.CopyTo(fs);
                fs.Close();

                db.EkstraMalzemeler.Add(ekstraMalzeme);
                db.SaveChanges();
                return RedirectToAction(nameof(EkstraMalzemeListele));
            }

            return View(vm);
        }
        public IActionResult EkstraMalzemeSil(int id)
        {
            var ekstraMalzeme= db.EkstraMalzemeler.FirstOrDefault(x=>x.EkstraMalzemeID==id);

            FileInfo fi = new FileInfo("wwwroot/Pictures/Ek_Urunler/" + ekstraMalzeme.PicturePath);
            fi.Delete();

            db.EkstraMalzemeler.Remove(ekstraMalzeme);
            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infosil"] = "Ekstra malzeme başarıyla silindi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(EkstraMalzemeListele));
                }
            }
            catch (Exception)
            {

                TempData["infosil"] = "Ekstra malzeme silinirken hata oluştu!";
            }

            return RedirectToAction(nameof(EkstraMalzemeListele));
        }
    }
}
