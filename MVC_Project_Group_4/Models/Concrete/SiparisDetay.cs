namespace MVC_Project_Group_4.Models.Concrete
{
    public class SiparisDetay
    {
        public int SiparisDetayID { get; set; }

        public int SiparisID { get; set; }

        public int EkMalzemeID { get; set; }

        public int HamburgerID { get; set; }

        public int IcecekID { get; set; }

        public int TatliID { get; set; }



        public Siparis? Siparis { get; set; }

        public EkstraMalzeme? EkstraMalzeme { get; set; }

        public Hamburger? Hamburger { get; set; }

        public Icecek? Icecek { get; set; }

        public Tatli? Tatli { get; set; }


    }
}
