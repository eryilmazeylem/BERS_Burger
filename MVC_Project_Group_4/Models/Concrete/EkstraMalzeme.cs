using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class EkstraMalzeme : Urun
    {
        public int EkstraMalzemeID { get; set; }

       



        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisDetay>? SiparisDetay { get; set; }

    }
}
