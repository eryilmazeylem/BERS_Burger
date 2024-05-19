using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Menu : Urun
    {
        public int MenuID { get; set; }


        public Boy? Boy { get; set; }



        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisMenu>? SiparisMenu { get; set; }



        public decimal ToplamFiyat
        {
            get
            {
                decimal toplam = 0;




                if (Boy == Concrete.Boy.Orta)
                {
                    toplam += Fiyat * 1.1m;

                }
                else if (Boy == Concrete.Boy.Buyuk)
                {
                    toplam += Fiyat * 1.2m;

                }
                else
                {
                    toplam = Fiyat;

                }



                toplam *= Adet;

                return toplam;

            }

        }

    }
}
