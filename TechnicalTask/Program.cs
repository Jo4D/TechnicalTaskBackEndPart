using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TechnicalTask.Data;
using TechnicalTask.Interfaces;
using TechnicalTask.MappingProfiles;
using TechnicalTask.Repositories;
using TechnicalTask.Services.EmployeeServices;

var builder = WebApplication.CreateBuilder(args);
var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionstring);
});
// Add services to the container.
builder.Services.AddAutoMapper(typeof(Mapping).Assembly);
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
}); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(typeof(Mapping));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder => builder
                 .AllowAnyHeader()
                 .AllowAnyMethod()
                 .AllowAnyOrigin());
app.UseAuthorization();

app.MapControllers();

app.Run();
