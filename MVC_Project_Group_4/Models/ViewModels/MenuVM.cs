using Microsoft.AspNetCore.Mvc.Rendering;

using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class MenuVM
    {
   

        public MenuEkleVM MenuEkle { get; set; }


   
        



        public List<Menu>? Menuler { get; set; } = new List<Menu>();

        public Menu Menu { get; set; }

    }
}
