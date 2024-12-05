using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TCS_Employee_Entity_CodeFirstApproach;
using TCS_Employee_Entity_CodeFirstApproach.Interfaces;
using TCS_Employee_Entity_CodeFirstApproach.Repositories;
using TCS_Employee_Entity_CodeFirstApproach.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<EmployeeContext>(Options=>
Options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


builder.Services.AddScoped<IOrdersRepository,OrdersRepository>();
builder.Services.AddScoped<IOrdersService,OrdersService>();

builder.Services.AddScoped<IDepartementRepository, DepartementRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
