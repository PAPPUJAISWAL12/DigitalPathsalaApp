using DigitalpathsalaTestapp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DisitalPathsalaAppContext>(o => o.UseSqlServer(builder.Configuration["conn"]));
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name:"default",
    pattern:"{Controller=Home}/{Action=Index}/{id?}"
    );

app.Run();
