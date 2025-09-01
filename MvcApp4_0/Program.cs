var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров с представлениями
builder.Services.AddControllersWithViews();

// внедряем сервис ITimeService
builder.Services.AddTransient<ITimeService, SimpleTimeService>();

var app = builder.Build();


/*
 * 1 шаблон только для маршрута  /Home/index
 * 2 шаблон только для контроллера Home с любым методом. дефолтное значение метода-about
 * 3 добавить метод Contact в контроллер  Home. и шаблон только для него с передачей параметров 1-тип int(age) (default-5) 2-тип name
*/

// Устанавливаем сопоставление маршрутов с контроллерами
/*
// 1. Шаблон ТОЛЬКО для маршрута /Home/Index (точное совпадение)
app.MapControllerRoute(
    name: "exactHomeIndex",
    pattern: "Home/Index",
    defaults: new { controller = "Home", action = "Index" });

// 2. Шаблон для контроллера Home с любым методом (дефолтный - about)
app.MapControllerRoute(
    name: "homeAnyAction",
    pattern: "Home/{action=About}",
    defaults: new { controller = "Home" });

// 3. Шаблон для метода Contact с параметрами
app.MapControllerRoute(
    name: "homeContact",
    pattern: "Home/Contact/{age:int=5}/{name?}",
    defaults: new { controller = "Home", action = "Contact" });

// Общий дефолтный маршрут (должен быть последним)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
*/

// добавляем поддержку контроллеров, которые располагаются в области
app.MapControllerRoute(
    name: "Account",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// добавляем поддержку для контроллеров, которые располагаются вне области
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// app.MapControllers();

app.Run();

public interface ITimeService
{
    string Time { get; }
}
public class SimpleTimeService : ITimeService
{
    public string Time => DateTime.Now.ToShortTimeString();
}