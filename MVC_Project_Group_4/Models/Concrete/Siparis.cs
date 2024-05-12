using MVC_Project_Group_4.Models.Abstract;

namespace MVC_Project_Group_4.Models.Concrete
{
    public class Siparis
    {
    
        public int SiparisID { get; set; }

        public Menu Menu { get; set; }

        public ICollection<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public Boy Boy { get; set; }

        public int Adet { get; set; }


        public decimal Toplam               
        {
            get                             
            {
                decimal toplam = 0;

                if (Boy == Boy.Orta)
                {
                    toplam += Menu.Fiyat * 1.1m; 

                }
                else if (Boy == Boy.Buyuk)
                {
                    toplam += Menu.Fiyat * 1.2m;

                }
                else
                {
                    toplam = Menu.Fiyat;

                }

                toplam += ToplamEkstraMalzemeFiyatiGetir();

                toplam *= Adet;

                return toplam;

            }

        }


        public decimal ToplamEkstraMalzemeFiyatiGetir() // EK MALZEME FİYATLARINI TOPLAYAN METOD
        {
            decimal toplam = 0;

            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                toplam += ekstra.Fiyat;
            }
            return toplam;
        }


        public override string ToString()
        {
            string bilgi = string.Empty;

            bilgi += Adet + " Adet " + Menu + " " + Boy + " ";

            string ekstraMalzemeIsimleri = EkstraMalzemeleriGetir();

            bilgi += ekstraMalzemeIsimleri;

            bilgi += " => " + Toplam;

            return bilgi;
        }

        private string EkstraMalzemeleriGetir()
        {
            string ekstraMalzemeler = string.Empty;

            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {

                ekstraMalzemeler += ekstra.Ad + ", ";
            }

            return ekstraMalzemeler;
        }
    }
}
