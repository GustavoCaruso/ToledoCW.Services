using Microsoft.EntityFrameworkCore;
using ToledoCW.Services.Configurations;
using ToledoCW.Services.Infraestructure;
using ToledoCW.Services.Infraestructure.Repositorios;
using ToledoCW.Services.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices(builder.Configuration);

var app = builder.Build();


await app.UseWebApplication(builder.Configuration);
app.Run();