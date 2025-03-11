using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using CustomerManagementSystem.Interfaces;
using CustomerManagementSystem.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});

builder.Services.AddScoped<ICustomerV1Repository, CustomerV1Repository>();
builder.Services.AddScoped<ICustomerV2Repository, CustomerV2Repository>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Customer Management API", Version = "v1" });
    c.SwaggerDoc("v2", new OpenApiInfo { Title = "Customer Management API", Version = "v2" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer Management API V1");
    c.SwaggerEndpoint("/swagger/v2/swagger.json", "Customer Management API V2");
    c.RoutePrefix = string.Empty; // Serve Swagger UI at the app's root
});

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();