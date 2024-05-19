using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class MenuEkleVM
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Ad { get; set; }


        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        public decimal Fiyat { get; set; }


        public string Aciklama { get; set; }



        [Required(ErrorMessage = "Lütfen bir resim yükleyin")]
        public IFormFile? PicturePath { get; set; }



        [Range(1, int.MaxValue, ErrorMessage = "Adet 0'dan büyük olmalıdır.")]
        public int Adet { get; set; }


        public List<string>? MenuAciklama { get; set; } = new List<string>();



        public SelectList? Hamburgerler { get; set; }

        public SelectList? EkMalzemeler { get; set; }

        public SelectList? Tatlilar { get; set; }

        public SelectList? Icecekler { get; set; }


        public int SelectedHamburgerID { get; set; }
        public int SelectedEkMalzemeID { get; set; }
        public int SelectedTatliID { get; set; }
        public int SelectedIcecekID { get; set; }



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
