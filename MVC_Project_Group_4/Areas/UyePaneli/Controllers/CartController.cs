using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;
using Newtonsoft.Json;
namespace MVC_Project_Group_4.Areas.UyePaneli.Controllers
{
    [Authorize(Roles ="Uye")]
    [Area("UyePaneli")]
    public class CartController : Controller
    {
        private readonly BurgerDBContext db;

        public CartController(BurgerDBContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(GetCart());
        }


        [HttpPost]
        public IActionResult AddToCart(string type,int id,string size)
        {    
            var product = GetProductByIdAndType(type,id);
           
            if (product != null)
            {
                Cart _cart = GetCart();
                _cart.AddProduct(product,1);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(_cart));
            }

            return RedirectToAction("Index");
        }

        private object GetProductByIdAndType(string type, int id)
        {
            switch (type)
            {
                case "MenuDetay":
                    return db.Menuler.FirstOrDefault(x => x.MenuID == id);
                case "IcecekDetay":
                    return db.Icecekler.FirstOrDefault(x => x.IcecekID == id);
                case "TatliDetay":
                    return db.Tatlilar.FirstOrDefault(x => x.TatliID == id);
                case "HamburgerDetay":
                    return db.Hamburgerler.FirstOrDefault(x => x.HamburgerID == id);
                case "EkMalzemeDetay":
                    return db.EkstraMalzemeler.FirstOrDefault(x => x.EkstraMalzemeID == id);
                default:
                    return null;
            }
        }

       

        public IActionResult RemoveFromCart(string type, int id)
        {
            var product = GetProductByIdAndType(type, id);

            if (product != null)
            {
                Cart _cart = GetCart();
                _cart.RemoveProduct(product);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(_cart));
            }

            return RedirectToAction("Index");
        }


        public Cart GetCart() 
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = string.IsNullOrEmpty(cartJson) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cartJson);

            if (string.IsNullOrEmpty(cartJson))
            {
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            }

            return cart;

        }

        public IActionResult SiparisOnay()
        {
            return View();
        }
    }
}
