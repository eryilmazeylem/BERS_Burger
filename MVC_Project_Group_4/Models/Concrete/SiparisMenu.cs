namespace MVC_Project_Group_4.Models.Concrete
{
    public class SiparisMenu
    {
        public int SiparisMenuID { get; set; }

        public int MenuID { get; set; }

        public int SiparisID { get; set; }




        public Menu? Menu { get; set; }

        public Siparis? Siparis { get; set; }
    }
}
