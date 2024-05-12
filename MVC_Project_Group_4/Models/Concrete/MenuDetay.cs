namespace MVC_Project_Group_4.Models.Concrete
{
    public class MenuDetay
    {
        public int MenuDetayID { get; set; }

        public int MenuID { get; set; }

        public int EkMalzemeID { get; set; }

        public int HamburgerID { get; set; }

        public int IcecekID { get; set; }

        public int TatlıID { get; set; }






        public Menu? Menu { get; set; }

        public EkstraMalzeme? EkstraMalzeme { get; set; }

        public Hamburger? Hamburger { get; set; }

        public Icecek? Icecek { get; set; }

        public Tatli? Tatlı { get; set; }




    }
}
