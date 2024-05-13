using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.IEntityTypeConfiguration
{
    public class Menu_CFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(x => x.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Adet).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.Fiyat).HasColumnType("money").IsRequired();

            builder.HasData(
                new Menu() { MenuID = 1, Ad = "Klasik Burger Menu", Adet = 1, Fiyat = 350, Aciklama = "1 Adet Cheeseburger + Tırtıklı Patates Kızartması + 1 Adet Kutu İçecek", PicturePath = "~/wwwroot/Pictures/Menuler/Klasik_burger_menu.jpg" },

                new Menu() { MenuID = 2, Ad = "Pastırmalı Burger Menu", Adet = 1, Fiyat = 350, Aciklama = "1 Adet Pastırmalı Burger + Tırtıklı Patates + 1 Adet Kutu İçecek" , PicturePath = "~/wwwroot/Pictures/Menuler/Benim_3_lum.jpg" },

                new Menu() { MenuID = 3, Ad = "2'li Fırsat Menü", Adet = 1, Fiyat = 350, Aciklama = "2 Adet Cheeseburger + Tırtıklı Patates + 2 Kutu İçecek", PicturePath = "~/wwwroot/Pictures/Menuler/Bjk_Menusu.jpg" },

                new Menu() { MenuID = 4, Ad = "3'lü Jumbo Menü", Adet = 1, Fiyat = 450, Aciklama = "3 Adet TripleWhooper Burger + 2 Adet Tırtıklı Patates + 3 Adet Kutu İçecek", PicturePath = "~/wwwroot/Pictures/Menuler/3_lu_big_king.jpg" },

                new Menu() { MenuID = 5, Ad = "CheeseBurger & SoğanHalkası Menü", Adet = 1, Fiyat = 300, Aciklama = "1 Adet CheeseBurger + 6'lı Soğan Halkası + Tırtıklı Patataes + 1adet kutu içecek", PicturePath = "~/wwwroot/Pictures/Menuler/chicken_menu.jpg" }
            
            );
        }
    }
}
