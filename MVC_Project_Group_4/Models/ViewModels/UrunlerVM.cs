using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class UrunlerVM
    {
        public ICollection<Menu>? Menuler { get; set; }

        public ICollection<EkstraMalzeme>? EkstraMalzemeler { get; set; }

        public ICollection<Icecek>? Icecekler { get; set; }

        public ICollection<Hamburger>? Hamburgerler { get; set; }

        public ICollection<Tatli>? Tatlilar { get; set; }



    }
}
