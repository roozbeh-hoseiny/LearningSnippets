using InternalServiceInController.AppCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<WeatherForecastService>();
builder.Services.AddControllers()
    .ConfigureApplicationPartManager(manager => {
        manager.FeatureProviders.Add(new MyControllerFeatureProvider());
    }); ;
var app = builder.Build();
app.MapControllers();
app.Run();
