using Weather.Application;
using Weather.Proxy.ViaCep;
using Wheater.Proxy.Atlas;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddViaCepApi(builder.Configuration);
builder.Services.AddAtlasProxy(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddControllers();

builder.Services.AddCors(opt => opt.AddDefaultPolicy(p => 
    p.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()));

var app = builder.Build();

app.MapControllers();
app.UseCors();

app.Run();