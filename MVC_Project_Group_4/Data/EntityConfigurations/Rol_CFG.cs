using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.EntityConfigurations
{
    public class Rol_CFG : IEntityTypeConfiguration<Rol>


    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasData
            (new Rol
            {
                Id = 1,
                Name = "Yonetici",
                NormalizedName = "YONETICI",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },

            new Rol
            {
                Id = 2,
                Name = "Uye",
                NormalizedName = "UYE",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }
    }
}
