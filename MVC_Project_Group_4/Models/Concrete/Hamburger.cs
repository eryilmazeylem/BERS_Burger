using MVC_Project_Group_4.Models.Abstract;
using System.Security.Cryptography;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Hamburger : Urun
    {
        public int HamburgerID { get; set; }



        public List<EkstraMalzeme>? MalzemeListesi { get; set; } // buna bakılacak



        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisDetay>? SiparisDetay { get; set; }

    }
}
