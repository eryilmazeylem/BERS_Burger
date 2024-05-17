using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class UrunlerVM
    {
        public ICollection<Menu> Menuler { get; set; }

        public ICollection<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public ICollection<Icecek> Icecekler { get; set; }

        public ICollection<Hamburger> Hamburgerler { get; set; }

        public ICollection<Tatli> Tatlilar { get; set; }



        public Hamburger? Hamburger { get; set; }
        public EkstraMalzeme? EkstraMalzeme { get; set; }
        public Icecek? Icecek { get; set; }
        public Menu? Menu { get; set; }
        public Tatli? Tatli { get; set; }


        public Siparis? Siparis { get; set; }

    }
}
