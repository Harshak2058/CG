using WEBAPIFirst.Interface;
using WEBAPIFirst.Repository;
using WEBAPIFirst.Swagger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICustomerV1Repository, CustomerV1Repository>();
builder.Services.AddTransient<ICustomerV2Repository, CustomerV2Repository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
       
    options.OperationFilter<SwaggerDefaultValues>();    
});

builder.Services.AddApiVersioning(opt=>
    opt.ApiVersionReader=new QueryStringApiVersionReader()
    );

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
