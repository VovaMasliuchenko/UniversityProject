using EvenToTheMoonEF.DAL.Data;
using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Data.Repositories;
using EvenToTheMoonEF.DAL.Interfaces;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using TWS.BusinessLogicLayer.Data;
using BLL.Registration;
using Microsoft.AspNetCore.Identity;
using EvenToTheMoonEF.DAL.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMapper();
builder.Services.AddServices();

builder.Services.AddDbContext<EvenToTheMoonDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// For Identity
builder.Services.AddIdentity<Clients, IdentityRole>()
    .AddEntityFrameworkStores<EvenToTheMoonDBContext>()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<ISellsRepository, SellsRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero,

        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var MyAllowedOrigins = "_myAllowedOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowedOrigins,
                          builder =>
                          {
                              builder.WithOrigins("http://localhost:4200")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

var app = builder.Build();

app.UseCors(MyAllowedOrigins);

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
