using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class HamburgerVM
    {
        public HamburgerEkleVM HamburgerEkleVM { get; set; }

        public List<Hamburger>? Hamburgerler { get; set; } = new List<Hamburger>();

        public Hamburger Hamburger { get; set; }
    }
}
