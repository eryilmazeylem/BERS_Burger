using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;
using System.Drawing;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class MenuController : Controller
    {
        private readonly BurgerDBContext db;


        public MenuController(BurgerDBContext dbContext)
        {
            this.db = dbContext;
        }
        MenuVM vm = new MenuVM();

        public IActionResult Index()
        {

            return View();
        }



        public IActionResult MenuListele()
        {
            vm.Menuler = db.Menuler.Include(x => x.MenuDetay).ThenInclude(x=>x.EkstraMalzeme).Include(x=>x.MenuDetay).ThenInclude(x=>x.Hamburger).ToList();
            return View(vm);
        }

        public IActionResult MenuEkle()
        {
            
            vm.Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad");
            vm.EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad");
            vm.Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad");
            vm.Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad");

            return View(vm);
        }

        [HttpPost]
        public IActionResult MenuEkle(MenuEkleVM menuEkle)
        {
            if(ModelState.IsValid)
            {
           
                Menu menu= new Menu();
                menu.Ad=menuEkle.Ad;
                menu.Fiyat=menuEkle.Fiyat;
                menu.Aciklama=menuEkle.Aciklama;
                menu.Adet=menuEkle.Adet;
                
                
                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += menuEkle.PicturePath.FileName;
                string dosyaYolu = "wwwRoot/Pictures/Menuler/";
                menu.PicturePath = dosyaAdi;

                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                menuEkle.PicturePath.CopyTo(fs);
                fs.Close();

                db.Menuler.Add(menu);
                db.SaveChanges();
                return RedirectToAction(nameof(MenuListele));
            }

            
            vm.Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad");
            vm.EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad");
            vm.Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad");
            vm.Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad");
            return View(vm);
            
        }

        public IActionResult MenuSil(int id)
        {
            var menu=db.Menuler.FirstOrDefault(x=>x.MenuID.Equals(id));

            FileInfo fi = new FileInfo("wwwroot/Pictures/Menuler/" + menu.PicturePath);
            fi.Delete();
            

            db.Menuler.Remove(menu);
            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infosil"] = "Menü başarıyla silindi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(MenuListele));
                }
            }
            catch (Exception)
            {

                TempData["infosil"] = "Menü silinirken hata oluştu!";
            }
            

            return RedirectToAction(nameof(MenuListele));
        }

  

        public IActionResult MenuGuncelle(int id)
        {
            MenuEkleVM vm = db.Menuler.Where(x => x.MenuID.Equals(id))
                .Select(x => new MenuEkleVM()
            {
                Aciklama = x.Aciklama,
                Ad = x.Ad,
                Adet = x.Adet,
                Fiyat = x.Fiyat,
                

            }).FirstOrDefault();

       
            return View(vm);
        }

        [HttpPost]
        public IActionResult MenuGuncelle(MenuEkleVM menuEkle,int id)
        {

            Menu menu = db.Menuler.FirstOrDefault(x=>x.MenuID.Equals(id));

            menu.Ad= menuEkle.Ad;
            menu.Adet= menuEkle.Adet;
            menu.Aciklama=menuEkle.Aciklama;
            menu.Fiyat= menuEkle.Fiyat;

            FileInfo fi = new FileInfo("wwwroot/Pictures/Menuler/" + menu.PicturePath);
            fi.Delete();

            Guid guid = Guid.NewGuid();

            string dosyaAdi = guid.ToString();

            dosyaAdi += menuEkle.PicturePath.FileName;

            string dosyaYolu = "wwwRoot/Pictures/Menuler/";

            menu.PicturePath = dosyaAdi;

            FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);

            menuEkle.PicturePath.CopyTo(fs);

            fs.Close();

            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infoguncelle"] = "Menü başarıyla güncellendi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(MenuListele));
                }
            }
            catch(Exception) {

                TempData["infoguncelle"] = "Menü güncellenirken hata oluştu!";
            }
          
            return RedirectToAction(nameof(MenuListele));



        }
    }
}
