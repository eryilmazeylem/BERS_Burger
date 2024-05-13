using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.EntityConfigurations
{
    public class Siparis_CFG : IEntityTypeConfiguration<Siparis>
    {
        public void Configure(EntityTypeBuilder<Siparis> builder)
        {
            builder.Property(x => x.SiparisDetayAciklama).HasColumnType("varchar").HasMaxLength(300);
            builder.Property(x => x.SiparisTarihi).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Adet).IsRequired();


        }
    }
}
