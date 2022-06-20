using Application.Common.Interfaces;
using Application.Sells.Commands;
using Application.Sells.Queries;
using Infrastructure.DataAccess;
using MediatR;
using MongoDB.Driver;
using System.Data.Common;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IMongoClient>(s =>
        new MongoClient(builder.Configuration.GetValue<string>("SellsDatabase:ConnectionString")));

builder.Services.AddScoped<IEvenToTheMoonDbConnection, EvenToTheMoonDbConnection>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddMediatR(typeof(CreateSellsCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetSellsById).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteSellsCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateSellsCommand).GetTypeInfo().Assembly);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var MyAllowedOrigins = "_myAllowedOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowedOrigins,
                          builder =>
                          {
                              builder.WithOrigins("http://localhost:3000")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

var app = builder.Build();

app.UseCors(MyAllowedOrigins);

app.UseHttpsRedirection();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
