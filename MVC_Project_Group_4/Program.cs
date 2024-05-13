using Microsoft.EntityFrameworkCore;
using MVC_Project_Group_4.Data.Context;
using MVC_Project_Group_4.Models.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();




builder.Services.AddDbContext<BurgerDBContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));

builder.Services
                .AddIdentity<Uye, Rol>(x => x.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<BurgerDBContext>().AddRoles<Rol>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
