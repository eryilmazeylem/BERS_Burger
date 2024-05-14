using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.EntityConfigurations
{
    public class EkstraMalzeme_CFG : IEntityTypeConfiguration<EkstraMalzeme>
    {
        public void Configure(EntityTypeBuilder<EkstraMalzeme> builder)
        {
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Adet).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Fiyat).HasColumnType("money").IsRequired();

            builder.HasData(
                new EkstraMalzeme() { EkstraMalzemeID = 1, Ad = "Marul", Adet = 1, Fiyat = 2.5m, Aciklama = "Taza Marul", PicturePath = "marul.jpg" },


                new EkstraMalzeme() { EkstraMalzemeID = 2, Ad = "Domates", Adet = 1, Fiyat = 3.5m, Aciklama = "Ayaş domatesi", PicturePath = "Domates.jpg " },


                new EkstraMalzeme() { EkstraMalzemeID = 3, Ad = "Turşu", Adet = 1, Fiyat = 2.5m, Aciklama = "Kornişon Turşusu", PicturePath = "Tursu.jpg " },


                new EkstraMalzeme() { EkstraMalzemeID = 4, Ad = "Soğan", Adet = 1, Fiyat = 1.2m, Aciklama = "Karamelize Soğan", PicturePath = "sogan.jpg" },


                new EkstraMalzeme() { EkstraMalzemeID = 5, Ad = "Mayonez", Adet = 1, Fiyat = 0.5m, Aciklama = "1 paket mayonez", PicturePath = "Mayonez.jpg " },


                new EkstraMalzeme() { EkstraMalzemeID = 6, Ad = "Ketçap", Adet = 1, Fiyat = 0.5m, Aciklama = "1 paket ketçap", PicturePath = "Ketcap.jpg " },


                new EkstraMalzeme() { EkstraMalzemeID = 7, Ad = "Tırtıklı Patates Kızartması", Adet = 1, Fiyat = 20m, Aciklama = "Özel Baharat Soslu Tırtıklı Patates Kızartması", PicturePath = "Tirtikli_patates_kizartmasi.jpg " },


                new EkstraMalzeme() { EkstraMalzemeID = 8, Ad = "6'lı Soğan Halkası", Adet = 1, Fiyat = 30m, Aciklama = "6 Adet Kızarmış Soğan Halkası", PicturePath = "Sogan_Halkasi.jpg " },


                new EkstraMalzeme() { EkstraMalzemeID = 9, Ad = "Barbekü Sos", Adet = 1, Fiyat = 1m, Aciklama = "1 paket Barbekü Sos", PicturePath = "Barbaku_sos.jpg" },


                new EkstraMalzeme() { EkstraMalzemeID = 10, Ad = "Ranch Sos", Adet = 1, Fiyat = 1m, Aciklama = "1 paket Ranch Sos", PicturePath = "Ranche_sos.jpg" },


                new EkstraMalzeme() { EkstraMalzemeID = 11, Ad = "Mini Salata", Adet = 1, Fiyat = 10m, Aciklama = "Mevsim Yeşillikleri ile yapılmış taze salata", PicturePath = "Mini_Salata.jpg" },


                new EkstraMalzeme() { EkstraMalzemeID = 12, Ad = "Pastırma", Adet = 3, Aciklama = "Dana Pastırma", Fiyat = 50, PicturePath = "Pastirma.jpg" }

            );

        }


    }
}
