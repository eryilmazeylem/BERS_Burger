using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Siparis
    {
    
        public int SiparisID { get; set; }

        public string? SiparisDetayAciklama { get; set; }

        public Boy Boy { get; set; }
        
        public int Adet { get; set; }

        public DateTime SiparisTarihi {  get; set; }

        public int UyeId { get; set; }


        public ICollection<SiparisMenu>? SiparisMenu { get; set; }

        public Uye? Uye { get; set; }

    }
}


        