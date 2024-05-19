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
        public IActionResult AddToCart(string type,int id)
        {


            //var menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);


            //if (menu != null)
            //{
            //    Cart _cart = new Cart();
            //    string jsonCart = HttpContext.Session.GetString("Cart");
            //    if (jsonCart != null)
            //    {
            //        _cart = JsonConvert.DeserializeObject<Cart>(jsonCart);
            //    }

            //    _cart.AddMenu(menu, 1);
            //    HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(_cart));

            //}
            //return RedirectToAction("Index");

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

        //public IActionResult RemoveFromCart(int id)
        //{

        //    var menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);

        //    if (menu != null)
        //    {
        //        Cart _cart = GetCart();
        //        _cart.RemoveProduct(menu);
        //        HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(_cart));
        //    }

        //    return RedirectToAction("Index");

        //}


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


        public Cart GetCart() //Session her kullanıcıya özel oluşturulan bir depo.
        {
            //var cartJson = HttpContext.Session.GetString("Cart");
            //Console.WriteLine(cartJson);
            //var cart = string.IsNullOrEmpty(cartJson) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cartJson);

            //if (string.IsNullOrEmpty(cartJson))
            //{
            //    Console.WriteLine("djfsdljgsldg");
            //    HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            //}
            // cartJson = HttpContext.Session.GetString("Cart");
            //Console.WriteLine(cartJson);
            //return cart;



            //var cart = (Cart)Session["Cart"];
            //if (cart == null)
            //{
            //    cart = new Cart();
            //    Session["Cart"] = cart;
            //}
            //return cart;


            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = string.IsNullOrEmpty(cartJson) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cartJson);

            if (string.IsNullOrEmpty(cartJson))
            {
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            }

            return cart;

        }

       


    }
}
