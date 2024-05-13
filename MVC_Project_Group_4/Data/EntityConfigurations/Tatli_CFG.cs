using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.EntityConfigurations
{
    public class Tatli_CFG : IEntityTypeConfiguration<Tatli>
    {
        public void Configure(EntityTypeBuilder<Tatli> builder)
        {
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Adet).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Fiyat).HasColumnType("money").IsRequired();

            builder.HasData(
                new Tatli() { TatliID = 1, Ad = "Sufle", Adet = 1, Fiyat = 50, Aciklama = "Çikolatalı ve dondurmalı enfes sufle", PicturePath = "" },
                new Tatli() { TatliID = 2, Ad = "Elmalı Tatlı", Adet = 1, Fiyat = 35, Aciklama = "Nefis Püresi ile beraber elmalı tatlı damak zevkinize birebir", PicturePath = "" },
                new Tatli() { TatliID = 3, Ad = "Çikolatalı Cookie", Adet = 1, Fiyat = 35, Aciklama = "Çikolata parçacıklı muhteşem kurabiyelerimiz", PicturePath = "" },
                new Tatli() { TatliID = 4, Ad = "Sütlaç", Adet = 1, Fiyat = 40, Aciklama = "Leziz fırınlanmış sütlaça hayır diyemezsiniz...", PicturePath = "" },
                new Tatli() { TatliID = 5, Ad = "İrmik Helvası", Adet = 1, Fiyat = 35, Aciklama = "Dondurmalı İrmik helvası", PicturePath = "" }
            );
        }
    }
}
