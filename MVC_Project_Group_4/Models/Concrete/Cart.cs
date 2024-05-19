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

        public void AddMenu(Menu menu,int quantity)
        {
            var line =_cardlines.FirstOrDefault(x=>x.Menu.MenuID==menu.MenuID);

            if (line==null)
            {
                _cardlines.Add(new CartLine() { Menu = menu, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteMenu(Menu menu)
        {
            _cardlines.RemoveAll(x=>x.Menu.MenuID == menu.MenuID);
        }

        public decimal Total()
        {
            return _cardlines.Sum(x=>x.Menu.Fiyat * x.Quantity);
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
       
        public Menu Menu { get; set; }
        public int Quantity { get; set; }
    }
}
