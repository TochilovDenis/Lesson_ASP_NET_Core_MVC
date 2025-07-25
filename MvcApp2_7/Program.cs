var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddMvc(); // добавляем сервисы MVC

builder.Services.AddControllers();  // добавляем поддержку контроллеров

var app = builder.Build();

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();