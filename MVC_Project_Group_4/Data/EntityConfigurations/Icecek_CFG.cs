using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.EntityConfigurations
{
    public class Icecek_CFG : IEntityTypeConfiguration<Icecek>
    {
        public void Configure(EntityTypeBuilder<Icecek> builder)
        {
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Adet).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Fiyat).HasColumnType("money").IsRequired();

            builder.HasData(
                new Icecek() { IcecekID = 1, Ad = "Coca-Cola", Adet = 1, Fiyat = 30, Aciklama = "Kutu İçecek", PicturePath = "Coca_cola.jpg" },
                new Icecek() { IcecekID = 2, Ad = "Coca-Cola-Zero", Adet = 1, Fiyat = 30, Aciklama = "Kutu İçecek", PicturePath = "Coca_cola_zero.jpg" },
                new Icecek() { IcecekID = 3, Ad = "Fanta", Adet = 1, Fiyat = 30, Aciklama = "Kutu İçecek", PicturePath = "Fanta.jpg" },
                new Icecek() { IcecekID = 4, Ad = "Sprite", Adet = 1, Fiyat = 30, Aciklama = "Kutu İçecek", PicturePath = "Sprite.jpg" },
                new Icecek() { IcecekID = 5, Ad = "Ayran", Adet = 1, Fiyat = 30, Aciklama = "Büyük Ayran", PicturePath = "Buyuk_Ayran.jpg" }
                
                
                );
        }
    }
}
