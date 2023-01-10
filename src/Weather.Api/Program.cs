using Weather.Application;
using Weather.Proxy.ViaCep;
using Wheater.Proxy.Atlas;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddViaCepApi(builder.Configuration);
builder.Services.AddAtlasProxy(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();