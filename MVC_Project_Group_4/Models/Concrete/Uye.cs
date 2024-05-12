using Microsoft.AspNetCore.Identity;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Uye : IdentityUser<int>
    {
        public string Adres { get; set; }



        public ICollection<Siparis>? Siparisler { get; set; }
    }
}
