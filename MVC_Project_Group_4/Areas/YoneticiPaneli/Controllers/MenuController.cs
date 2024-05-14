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

        public IActionResult Index()
        {

            return View();
        }



        public IActionResult MenuListele()
        {

            return View(db.Menuler.Include(x=>x.MenuDetay).ToList());
        }

        public IActionResult MenuEkle()
        {
            MenuVM menuVM = new MenuVM();
            menuVM.Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad");
            menuVM.EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad");
            menuVM.Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad");
            menuVM.Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad");

            return View(menuVM);
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

            MenuVM menuVM = new MenuVM();
            menuVM.Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad");
            menuVM.EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad");
            menuVM.Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad");
            menuVM.Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad");
            return View(menuVM);
            
        }

        public IActionResult MenuSil(int id)
        {
            var menu=db.Menuler.FirstOrDefault(x=>x.MenuID.Equals(id));

            FileInfo fi = new FileInfo("wwwroot/Pictures/Menuler/" + menu.PicturePath);
            fi.Delete();

            db.Menuler.Remove(menu);
            db.SaveChanges();

            return RedirectToAction(nameof(MenuListele));
        }

        //public IActionResult MenuGuncelle(int id)
        //{
        //    MenuEkleVM vM= new MenuEkleVM();    
            

            
        //}
    }
}
