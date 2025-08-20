using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров с представлениями
builder.Services.AddControllersWithViews();

var app = builder.Build();

//// устанавливаем сопоставление маршрутов с контроллерами
//app.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id?}");
//app.MapControllerRoute(name: "name_age", pattern: "{controller}/{action}/{name}/{age}");

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    constraints: new { id = new IntRouteConstraint() });  // ограничения маршрутов

app.Run();