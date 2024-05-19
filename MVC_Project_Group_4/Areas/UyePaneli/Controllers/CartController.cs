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

            ViewBag.userSession = HttpContext.Session.GetString("Email");

            return View(GetCart());
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {

           
            var menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);
           
            if (menu != null)
            {
                Cart _cart = new Cart();
                string jsonCart = HttpContext.Session.GetString("Cart");
                if (jsonCart!=null)
                {
                     _cart = JsonConvert.DeserializeObject<Cart>(jsonCart);
                }
              
                _cart.AddMenu(menu, 1);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(_cart));
               
            }
            return RedirectToAction("Index");

        }





        public IActionResult RemoveFromCart(int id)
        {
            var menu = db.Menuler.FirstOrDefault(x => x.MenuID == id);

            if (menu != null)
            {
                
                GetCart().DeleteMenu(menu);
            }
            return RedirectToAction("Index");
        }





        public Cart GetCart() //Session her kullanıcıya özel oluşturulan bir depo.
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            Console.WriteLine(cartJson);
            var cart = string.IsNullOrEmpty(cartJson) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cartJson);

            if (string.IsNullOrEmpty(cartJson))
            {
                Console.WriteLine("djfsdljgsldg");
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            }
             cartJson = HttpContext.Session.GetString("Cart");
            Console.WriteLine(cartJson);
            return cart;

            

            //var cart = (Cart)Session["Cart"];
            //if (cart == null)
            //{
            //    cart = new Cart();
            //    Session["Cart"] = cart;
            //}
            //return cart;



        }

    }
}
