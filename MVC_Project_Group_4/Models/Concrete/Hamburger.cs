using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Abstract;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Hamburger : Urun
    {
        //private readonly BurgerDBContext db;

        //public Hamburger()
        //{
        //}

        //public Hamburger(BurgerDBContext db)
        //{
        //    this.db = db;
        //    EkstraMalzemeleriGetir();
        //}

        public int HamburgerID { get; set; }

       


        //public List<EkstraMalzeme>? EkstraMalzemeler { get; set; }


        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisDetay>? SiparisDetay { get; set; }



        //private void EkstraMalzemeleriGetir()
        //{

        //    var defaultMalzeme1 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Marul");
        //    var defaultMalzeme2 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Soğan");
        //    var defaultMalzeme3 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Domates");
        //    var defaultMalzeme4 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Turşu");

        //    EkstraMalzemeler.Add(defaultMalzeme1);
        //    EkstraMalzemeler.Add(defaultMalzeme2);
        //    EkstraMalzemeler.Add(defaultMalzeme3);
        //    EkstraMalzemeler.Add(defaultMalzeme4);

        //}


    }
}
