using Newtonsoft.Json;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Cart
    {
        private List<CartLine> _cardlines=new List<CartLine>();

        public List<CartLine> CartLines
        {
            get
            {
                return _cardlines;
            }
        }

        public void AddMenu(Menu menu, int quantity)
        {
            var line = _cardlines.FirstOrDefault(x => x.Menu?.MenuID == menu.MenuID);

            if (line == null)
            {
                _cardlines.Add(new CartLine() { Menu = menu, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        private void AddIcecek(Icecek icecek, int quantity)
        {
            var line = _cardlines.FirstOrDefault(x => x.Icecek?.IcecekID==icecek.IcecekID);

            if (line == null)
            {
                _cardlines.Add(new CartLine() { Icecek = icecek, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        private void AddTatli(Tatli tatli, int quantity)
        {
            var line = _cardlines.FirstOrDefault(x => x.Tatli?.TatliID == tatli.TatliID);

            if (line == null)
            {
                _cardlines.Add(new CartLine() { Tatli = tatli, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        private void AddHamburger(Hamburger hamburger, int quantity)
        {
            var line = _cardlines.FirstOrDefault(x => x.Hamburger?.HamburgerID == hamburger.HamburgerID);

            if (line == null)
            {
                _cardlines.Add(new CartLine() {Hamburger=hamburger, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        private void AddEkstraMalzeme(EkstraMalzeme ekstraMalzeme, int quantity)
        {
            var line = _cardlines.FirstOrDefault(x => x.EkstraMalzeme?.EkstraMalzemeID == ekstraMalzeme.EkstraMalzemeID);

            if (line == null)
            {
                _cardlines.Add(new CartLine() { EkstraMalzeme=ekstraMalzeme, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }

        }

        public void AddProduct(object product, int quantity)
        {
            // Tipine göre ürünü ekleyin
            if (product is Menu)
            {
                AddMenu((Menu)product, quantity);
            }
            else if (product is Icecek)
            {
                AddIcecek((Icecek)product, quantity);
            }
            else if (product is Tatli)
            {
                AddTatli((Tatli)product, quantity);
            }
            else if (product is Hamburger)
            {
                AddHamburger((Hamburger)product, quantity);
            }
            else if (product is EkstraMalzeme)
            {
                AddEkstraMalzeme((EkstraMalzeme)product, quantity);
            }
        }

        public void DeleteMenu(Menu menu)
        {
            _cardlines.RemoveAll(x=>x.Menu.MenuID == menu.MenuID);
        }


        public void RemoveProduct(object product)
        {
            if (product is Menu menu)
            {
                _cardlines.RemoveAll(x => x.Menu?.MenuID == menu.MenuID);
            }
            else if (product is Icecek icecek)
            {
                _cardlines.RemoveAll(x => x.Icecek?.IcecekID == icecek.IcecekID);
            }
            else if (product is Tatli tatli)
            {
                _cardlines.RemoveAll(x => x.Tatli?.TatliID == tatli.TatliID);
            }
            else if (product is Hamburger hamburger)
            {
                _cardlines.RemoveAll(x => x.Hamburger?.HamburgerID == hamburger.HamburgerID);
            }
            else if (product is EkstraMalzeme ekstraMalzeme)
            {
                _cardlines.RemoveAll(x => x.EkstraMalzeme?.EkstraMalzemeID == ekstraMalzeme.EkstraMalzemeID);
            }
        }

        //public decimal Total()
        //{
        //    return _cardlines.Sum(x=>x.Menu.Fiyat * x.Quantity);
        //}

        public decimal Total()
        {
            return _cardlines.Sum(x =>
            {
                if (x.Menu != null)
                    return x.Menu.ToplamFiyat * x.Quantity;
                if (x.Hamburger != null)
                    return x.Hamburger.Fiyat * x.Quantity;
                if (x.Icecek != null)
                    return x.Icecek.Fiyat * x.Quantity;
                if (x.Tatli != null)
                    return x.Tatli.Fiyat * x.Quantity;
                if (x.EkstraMalzeme != null)
                    return x.EkstraMalzeme.Fiyat * x.Quantity;

                return 0; // Bu durumda hiçbir ürün tipi mevcut değilse 0 döner
            });
        }


        public string CartToJson()
        {
           return JsonConvert.SerializeObject(this);
        }

        public void Clear()
        {
            _cardlines.Clear();
        }
    }

   

    public class CartLine
    {
       
        public Icecek Icecek { get; set; }
        public Tatli Tatli { get; set; }
        public Hamburger Hamburger { get; set; }
        public EkstraMalzeme EkstraMalzeme { get; set; }
       
        public Menu Menu { get; set; }
        public int Quantity { get; set; }
    }
}
