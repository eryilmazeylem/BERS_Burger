using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.Abstract
{
    public abstract class Urun
    {
        public string Ad { get; set; }

        public decimal Fiyat { get; set; }

        public string Aciklama { get; set; }


        public string PicturePath { get; set; }


        public int Adet { get; set; }

    }
}
