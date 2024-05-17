using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class TatliVM
    {
        public TatliEkleVM TatliEkleVM { get; set; }
        public List<Tatli>? Tatlilar { get; set; } = new List<Tatli>();
        public Tatli? Tatli { get; set; }
    }
}
