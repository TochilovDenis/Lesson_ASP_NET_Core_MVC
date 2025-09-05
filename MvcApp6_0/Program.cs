var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров с представлениями
builder.Services.AddControllersWithViews();

// внедряем сервис ITimeService
builder.Services.AddTransient<ITimeService, SimpleTimeService>();

var app = builder.Build();

app.UseStaticFiles(); // Ensure this line is present

app.MapControllers();
app.Run();

public interface ITimeService
{
    string Time { get; }
}
public class SimpleTimeService : ITimeService
{
    public string Time => DateTime.Now.ToShortTimeString();
}