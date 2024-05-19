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

            vm.Menuler = db.Menuler.Include(x => x.MenuDetay).ThenInclude(x => x.EkstraMalzeme).Include(x => x.MenuDetay).ThenInclude(x => x.Hamburger).ToList();

            return View(vm);
        }


        public IActionResult MenuEkle()
        {

            var boylar = Enum.GetValues(typeof(Boy)).Cast<Boy>().Select(x => new SelectListItem
            {
                Value = ((int)x).ToString(),
                Text = x.ToString()
            }).ToList();

            vm = new MenuVM
            {
                MenuEkle = new MenuEkleVM
                {
                    Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad"),
                    EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad"),
                    Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad"),
                    Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad"),

                    Boylar = new SelectList(boylar, "Value", "Text")
                }
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult MenuEkle(MenuEkleVM menuEkle)
        {
            if (ModelState.IsValid)
            {

                Menu menu = new Menu();
                menu.Ad = menuEkle.Ad;
                menu.Fiyat = menuEkle.Fiyat;
                menu.Aciklama = menuEkle.Aciklama;
                menu.Adet = menuEkle.Adet;


                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += menuEkle.PicturePath.FileName;
                string dosyaYolu = "wwwRoot/Pictures/Menuler/";
                menu.PicturePath = dosyaAdi;

                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                menuEkle.PicturePath.CopyTo(fs);
                fs.Close();


                Boy selectedBoy = menuEkle.SelectedBoy;
                menu.Boy = selectedBoy;


                menuEkle.Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad");
                menuEkle.EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad");
                menuEkle.Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad");
                menuEkle.Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad");



                var selectedHamburger = db.Hamburgerler.Find(menuEkle.SelectedHamburgerID)?.Ad;
                var selectedEkMalzeme = db.EkstraMalzemeler.Find(menuEkle.SelectedEkMalzemeID)?.Ad;
                var selectedTatli = db.Tatlilar.Find(menuEkle.SelectedTatliID)?.Ad;
                var selectedIcecek = db.Icecekler.Find(menuEkle.SelectedIcecekID)?.Ad;

                if (!string.IsNullOrEmpty(selectedHamburger)) menuEkle.MenuAciklama.Add(selectedHamburger);
                if (!string.IsNullOrEmpty(selectedEkMalzeme)) menuEkle.MenuAciklama.Add(selectedEkMalzeme);
                if (!string.IsNullOrEmpty(selectedTatli)) menuEkle.MenuAciklama.Add(selectedTatli);
                if (!string.IsNullOrEmpty(selectedIcecek)) menuEkle.MenuAciklama.Add(selectedIcecek);

                if (menuEkle.MenuAciklama.Count > 0)
                {
                    menu.Aciklama += string.Join(" + ", menuEkle.MenuAciklama);
                }


                db.Menuler.Add(menu);
                db.SaveChanges();
                return RedirectToAction(nameof(MenuListele));
            }


            menuEkle.Hamburgerler = new SelectList(db.Hamburgerler.ToList(), "HamburgerID", "Ad");
            menuEkle.EkMalzemeler = new SelectList(db.EkstraMalzemeler.ToList(), "EkstraMalzemeID", "Ad");
            menuEkle.Tatlilar = new SelectList(db.Tatlilar.ToList(), "TatliID", "Ad");
            menuEkle.Icecekler = new SelectList(db.Icecekler.ToList(), "IcecekID", "Ad");
            var boylar = Enum.GetValues(typeof(Boy)).Cast<Boy>().Select(b => new SelectListItem
            {
                Value = ((int)b).ToString(),
                Text = b.ToString()
            }).ToList();

            menuEkle.Boylar = new SelectList(boylar, "Value", "Text");


            return View(vm);

        }



        public IActionResult MenuSil(int id)
        {
            var menu = db.Menuler.FirstOrDefault(x => x.MenuID.Equals(id));

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

            var boylar = Enum.GetValues(typeof(Boy)).Cast<Boy>().Select(x => new SelectListItem
            {
                Value = ((int)x).ToString(),
                Text = x.ToString()
            }).ToList();


            MenuEkleVM vm = db.Menuler.Where(x => x.MenuID.Equals(id))
                .Select(x => new MenuEkleVM()
                {
                    Aciklama = x.Aciklama,
                    Ad = x.Ad,
                    Adet = x.Adet,
                    Fiyat = x.Fiyat,
                    Boylar = new SelectList(boylar, "Value", "Text")


                }).FirstOrDefault();

            return View(vm);
        }

        [HttpPost]
        public IActionResult MenuGuncelle(MenuEkleVM menuEkle, int id)
        {

            Menu menu = db.Menuler.FirstOrDefault(x => x.MenuID.Equals(id));

            menu.Ad = menuEkle.Ad;
            menu.Adet = menuEkle.Adet;
            menu.Aciklama = menuEkle.Aciklama;
            menu.Fiyat = menuEkle.Fiyat;

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

            Boy selectedBoy = menuEkle.SelectedBoy;
            menu.Boy = selectedBoy;


            try
            {
                if (db.SaveChanges() > 0)
                {
                    TempData["infoguncelle"] = "Menü başarıyla güncellendi.";
                    db.SaveChanges();
                    return RedirectToAction(nameof(MenuListele));
                }
            }
            catch (Exception)
            {

                TempData["infoguncelle"] = "Menü güncellenirken hata oluştu!";
            }

            return RedirectToAction(nameof(MenuListele));

        }
    }
}
