using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project_Group_4.Models.Concrete;

namespace MVC_Project_Group_4.Data.IEntityTypeConfiguration
{
    public class Uye_CFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {

            Uye uye = new Uye
            {
                Id = 1,
                UserName = "super@deneme.com",
                NormalizedUserName = "SUPER@DENEME.COM",
                Email = "super@deneme.com",
                NormalizedEmail = "SUPER@DENEME.COM",
                Adres = "Dunya",
                EmailConfirmed = false,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            PasswordHasher<Uye> passwordHasher = new PasswordHasher<Uye>();
            uye.PasswordHash = passwordHasher.HashPassword(uye, "sprAdmn_123");
            builder.HasData(uye);
        }
    }
}
