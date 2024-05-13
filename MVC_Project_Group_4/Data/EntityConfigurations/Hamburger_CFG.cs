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
        }
    }
}
