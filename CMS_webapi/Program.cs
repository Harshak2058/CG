using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models; // Required for Swagger
using CMS_webapi.Repositories; // Replace this with your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Customer API", Version = "v1" });
    options.SwaggerDoc("v2", new OpenApiInfo { Title = "Customer API", Version = "v2" });
});

// Enable API versioning
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ApiVersionReader = ApiVersionReader.Combine(
        new HeaderApiVersionReader("X-API-Version"),
        new QueryStringApiVersionReader("api-version")
    );
});

// Register repositories for dependency injection (DI)
builder.Services.AddScoped<ICustomerV1Repository, CustomerV1Repository>();
builder.Services.AddScoped<ICustomerV2Repository, CustomerV2Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable Swagger only in development mode
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer API v1");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "Customer API v2");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
