namespace MVC_Project_Group_4.Models.ViewModels
{
    public class TatliEkleVM
    {
        public string Ad { get; set; }

        public decimal Fiyat { get; set; }

        public string Aciklama { get; set; }


        public IFormFile? PicturePath { get; set; }


        public int Adet { get; set; }
    }
}
