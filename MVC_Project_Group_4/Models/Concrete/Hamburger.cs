using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Abstract;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Hamburger : Urun
    {
      
        public int HamburgerID { get; set; }



        public ICollection<MenuDetay>? MenuDetay { get; set; }

        public ICollection<SiparisDetay>? SiparisDetay { get; set; }


       
     

        
    }
}
