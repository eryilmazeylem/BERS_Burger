using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.EntityConfigurations
{
    public class Hamburger_CFG : IEntityTypeConfiguration<Hamburger>
    {
        public void Configure(EntityTypeBuilder<Hamburger> builder)
        {
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Adet).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Fiyat).HasColumnType("money").IsRequired();

            builder.HasData(
                new Hamburger() { HamburgerID = 1, Ad = "CheeseBurger", Adet = 1, Fiyat = 150, Aciklama = "120g Burger köftesi ile cheddar peynirinin muhteşem uyumu...", PicturePath = "CheeseBurger.jpg"},


                new Hamburger() { HamburgerID = 2, Ad = "BigKing", Adet = 1, Fiyat = 180, Aciklama = "150g Dana Burger köftesi + Göbek Salata + domates + turşu + BigKing Sos", PicturePath = "Big_King.jpg" },


                new Hamburger() { HamburgerID = 3, Ad = "Whooper", Adet = 1, Fiyat = 180, Aciklama = "120g Dana Eti + Göbek Salata + domates + turşu + soğan", PicturePath = "Whoper.jpg" },


                new Hamburger() { HamburgerID = 4, Ad = "TripleWhooper", Adet = 1, Fiyat = 300, Aciklama = "360g Burger Göbek Salata + domates + turşu + soğan", PicturePath = "Triple_Whopper.jpg" },


                new Hamburger() { HamburgerID = 5, Ad = "Jr BigMac", Adet = 1, Fiyat = 100, Aciklama = "90g Burger köftesi + domates + mayonez + ketçap + turşu", PicturePath = "jr_bigmac.jpg" },


                new Hamburger() { HamburgerID = 6, Ad = "Pastırmalı Burger", Adet = 1, Fiyat = 230, Aciklama = "150g Burger köftesi + Pastırma + domates + mayonez + ketçap + turşu", PicturePath = "Pastırmalı_burger.jpg" }
            );
        }
    }
}
