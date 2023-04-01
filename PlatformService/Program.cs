using Microsoft.EntityFrameworkCore;
using PlatformService.DAL;
using PlatformService.DAL.Interfaces;
using PlatformService.DAL.Repos;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddRouting(r =>
{
    r.LowercaseQueryStrings = true;
});

//автомаппер
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(x => 
    x.UseInMemoryDatabase("InMem"));

builder.Services.AddScoped<IPlatfromRepo, PlatformRepo>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

PrepDb.PrepPopulation(app);

app.Run();
