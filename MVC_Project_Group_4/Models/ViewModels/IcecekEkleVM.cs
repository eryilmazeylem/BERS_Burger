using System.ComponentModel.DataAnnotations;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class IcecekEkleVM
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
    }
}
