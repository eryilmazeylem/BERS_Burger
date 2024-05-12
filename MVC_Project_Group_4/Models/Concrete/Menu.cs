using Microsoft.Extensions.FileProviders;
using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Menu : Urun
    {
        public int MenuID { get; set; }

      




        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisMenu>? SiparisMenu { get; set; }



    }
}
