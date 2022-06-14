using BLL.Registration;
using EvenToTheMoon.DAL.Data;
using EvenToTheMoon.DAL.Data.Repositories;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;
using System.Data;
using System.Data.SqlClient;
using TWS.BusinessLogicLayer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<INutritionRepository, NutritionRepository>();
builder.Services.AddScoped<ITourCategoriesRepository, TourCategoriesRepository>();
builder.Services.AddScoped<IToursRepository, ToursRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddMapper();
builder.Services.AddServices();

builder.Services.AddScoped((s) => new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IDbTransaction>(s =>
{
    SqlConnection conn = s.GetRequiredService<SqlConnection>();
    conn.Open();
    return conn.BeginTransaction();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
