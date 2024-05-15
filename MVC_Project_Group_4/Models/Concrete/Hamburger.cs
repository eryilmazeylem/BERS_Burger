using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Hamburger : Urun
    {
        private readonly BurgerDBContext db;

        public Hamburger()
        {
            EkstraMalzemeleriGetir();
        }

        public Hamburger(BurgerDBContext db)
        {
            this.db = db;
        }

        public int HamburgerID { get; set; }



        [NotMapped]
        public List<EkstraMalzeme>? HamburgerMalzemeleri { get; set; } = new List<EkstraMalzeme>();


        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisDetay>? SiparisDetay { get; set; }



        private void EkstraMalzemeleriGetir()
        {
            if(HamburgerMalzemeleri is null)
            {
                var defaultMalzeme1 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Marul");
                var defaultMalzeme2 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Soğan");
                var defaultMalzeme3 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Domates");
                var defaultMalzeme4 = db.EkstraMalzemeler.FirstOrDefault(x => x.Ad == "Turşu");

                HamburgerMalzemeleri.Add(defaultMalzeme1);
                HamburgerMalzemeleri.Add(defaultMalzeme2);
                HamburgerMalzemeleri.Add(defaultMalzeme3);
                HamburgerMalzemeleri.Add(defaultMalzeme4);

            }

        }


    }
}
