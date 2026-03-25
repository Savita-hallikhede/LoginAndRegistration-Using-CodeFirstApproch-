using code_second_approch.Appdata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder .Services.AddControllersWithViews();
var conkey = builder.Configuration.GetConnectionString("DBCon");
builder.Services.AddDbContext<mainCode>(S => S.UseSqlServer(conkey));

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reg}/{action=dataShow}/{id?}");

app.Run();
