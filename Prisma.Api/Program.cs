using Microsoft.EntityFrameworkCore;
using Prisma.Data.Contexts;
using Prisma.Data.Repositories;
using Prisma.Data.Repositories.Shared;
using Prisma.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<AddressRepository, AddressRepository>();
builder.Services.AddScoped<AddressService, AddressService>();
builder.Services.AddScoped<PrescriberRepository, PrescriberRepository>();
builder.Services.AddScoped<PrescriberService, PrescriberService>();
builder.Services.AddScoped<PatientRepository, PatientRepository>();
builder.Services.AddScoped<PatientService, PatientService>();

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
