using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Siparis
    {
    
        public int SiparisID { get; set; }

        public string? SiparisDetayAciklama { get; set; }

        public Boy Boy { get; set; }
        
        public int Adet { get; set; }

        public DateTime SiparisTarihi {  get; set; }

        public int UyeId { get; set; }


        //public List<EkstraMalzeme> EkstraMalzemeler { get; set; } = new List<EkstraMalzeme>();
        //public Menu Menu{ get; set; }
        //public List<Tatli> Tatlilar { get; set; } = new List<Tatli>();
        //public List<Hamburger> Hamburgerler { get; set; } = new List<Hamburger>();
        //public List<Icecek> Icecekler { get; set; } = new List<Icecek>();

        //public List<Menu> Menuler { get; set; } = new List<Menu>();



        public ICollection<SiparisMenu>? SiparisMenu { get; set; }

        public Uye? Uye { get; set; }



        //public decimal ToplamFiyat
        //{
        //    get
        //    {
        //        decimal toplam = 0;

        //        foreach(var menu in Menuler)
        //        {

        //        if (Boy == Boy.Orta)
        //        {
        //            toplam += menu.Fiyat * 1.1m;

        //        }
        //        else if (Boy == Boy.Buyuk)
        //        {
        //            toplam += menu.Fiyat * 1.2m;

        //        }
        //        else
        //        {
        //            toplam = menu.Fiyat;

        //        }

        //        }


        //        toplam += ToplamEkstraMalzemeFiyatiGetir() + ToplamHamburgerFiyatiGetir() + ToplamIcecekFiyatiGetir() + ToplamTatliFiyatiGetir();

        //        toplam *= Adet;

        //        return toplam;

        //    }

        //}


        //public decimal ToplamEkstraMalzemeFiyatiGetir() // EK MALZEME FİYATLARINI TOPLAYAN METOD
        //{
        //    decimal toplam = 0;

        //    foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
        //    {
        //        toplam += ekstra.Fiyat;
        //    }
        //    return toplam;
        //}


        //public decimal ToplamMenuFiyatiGetir() // Menu FİYATLARINI TOPLAYAN METOD
        //{
        //    decimal toplam = 0;

        //    foreach (Menu menu in Menuler)
        //    {
        //        toplam += menu.Fiyat;
        //    }
        //    return toplam;
        //}


        //public decimal ToplamIcecekFiyatiGetir() // ICECEK FİYATLARINI TOPLAYAN METOD
        //{
        //    decimal toplam = 0;

        //    foreach (Icecek icecek in Icecekler)
        //    {
        //        toplam += icecek.Fiyat;
        //    }
        //    return toplam;
        //}


        //public decimal ToplamTatliFiyatiGetir() // TATLI FİYATLARINI TOPLAYAN METOD
        //{
        //    decimal toplam = 0;

        //    foreach (Tatli tatli in Tatlilar)
        //    {
        //        toplam += tatli.Fiyat;
        //    }
        //    return toplam;
        //}

        //public decimal ToplamHamburgerFiyatiGetir() // HAMBURGER FİYATLARINI TOPLAYAN METOD
        //{
        //    decimal toplam = 0;

        //    foreach (Hamburger hamburger in Hamburgerler)
        //    {
        //        toplam += hamburger.Fiyat;
        //    }
        //    return toplam;
        //}

        //public override string ToString()
        //{
        //    string siparis = string.Empty;

        //    siparis += Adet + " Adet " + Menu + " " + Boy + " ";

        //    string ekstraMalzemeIsimleri = EkstraMalzemeleriGetir();
        //    string HamburgerIsimleri = HamburgerleriGetir();
        //    string iceceklerIsimleri = IcecekleriGetir();
        //    string tatliIsimleri = TatlilariGetir();

        //    siparis += HamburgerIsimleri + ekstraMalzemeIsimleri + tatliIsimleri + iceceklerIsimleri;

        //    siparis += " => " + ToplamFiyat;

        //    return siparis;
        //}

        //private string EkstraMalzemeleriGetir()
        //{
        //    string ekstraMalzemeler = string.Empty;

        //    foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
        //    {

        //        ekstraMalzemeler += ekstra.Ad + ", ";
        //    }

        //    return ekstraMalzemeler;

        //}

        //private string MenuleriGetir()
        //{
        //    string menuler = string.Empty;

        //    foreach (Menu menu in Menuler)
        //    {

        //        menuler += menu.Ad + ", ";
        //    }

        //    return menuler;

        //}

        //private string IcecekleriGetir()
        //{
        //    string icecekler = string.Empty;

        //    foreach (Icecek icecek in Icecekler)
        //    {

        //        icecekler += icecek.Ad + ", ";
        //    }

        //    return icecekler;

        //}

        //private string HamburgerleriGetir()
        //{
        //    string hamburgerler = string.Empty;

        //    foreach (Hamburger hamburger in Hamburgerler)
        //    {

        //        hamburgerler += hamburger.Ad + ", ";
        //    }

        //    return hamburgerler;

        //}

        //private string TatlilariGetir()
        //{
        //    string tatlilar = string.Empty;

        //    foreach (Tatli tatli in Tatlilar)
        //    {

        //        tatlilar += tatli.Ad + ", ";
        //    }

        //    return tatlilar;

        //}

    }
}


        