using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Project_Group_4.Models.Concrete;
using MVC_Project_Group_4.Models.ViewModels;
using System.Reflection;

namespace MVC_Project_Group_4.Data.Context
{
    public class BurgerDBContext : IdentityDbContext<Uye,Rol,int>
    {
        public BurgerDBContext()
        {

        }

        public BurgerDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { UserId = 1 , RoleId = 1 });

        }



        public DbSet<LoginVM> LoginVM { get; set; }
        public DbSet<LoginVM> RegisterVM { get; set; }

        



    }
}
