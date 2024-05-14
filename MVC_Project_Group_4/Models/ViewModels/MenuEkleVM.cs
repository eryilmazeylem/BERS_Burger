using System.ComponentModel.DataAnnotations;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class MenuEkleVM
    {
        public string Ad { get; set; }

        public decimal Fiyat { get; set; }

        public string Aciklama { get; set; }


        public IFormFile? PicturePath { get; set; }


        public int Adet { get; set; }



        [Display(Name = "Hamburger")]
        public int HamburgerID { get; set; }
        [Display(Name = "Ekstra Malzeme")]
        public int EkstraMalzemeID { get; set; }
        [Display(Name = "Tatlı")]
        public int TatliID { get; set; }
        [Display(Name = "İçecek")]
        public int IcecekID { get; set; }



    }
}
