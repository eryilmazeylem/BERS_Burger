using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class IcecekVM
    {
        public IcecekEkleVM IcecekEkleVM { get; set; }
        public List<Icecek> Icecekler { get; set; }
        public Icecek Icecek { get; set; }
    }
}
